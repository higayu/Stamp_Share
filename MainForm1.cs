using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MyCreate;
using System.IO;
using System.Xml.Linq;
using Microsoft.Office.Interop.Excel;
using System.Collections;
using Microsoft.VisualBasic;

namespace string_stamp1 {
    public partial class MainForm1 : Form {
        public MainForm1() {
            InitializeComponent();
        }

        //DB作成
        public static SQLite_URL_Pass subData;
        public static bool Update_Flg=false;
        private string Select_Table_Name;

        public string Get_Table {
            get { return Select_Table_Name; }
            set {

               Select_Table_Name= value;
               Select_ResetData(ref dataGridView1,Select_Table_Name);
            }
        }

        public string history_Name = @"history\";
        string FolderPath;

        public static void Set_CripBord(string moji) {
            #region //---------------------------------//
            //クリップボードに文字列をコピーする
            Clipboard.SetText(moji);
            #endregion //--------------------------------//
        }

        public static string Past_CripBord() {
            string memo="";

            System.Windows.Forms.IDataObject data = Clipboard.GetDataObject();
            if (data != null) {

                if (data.GetDataPresent(typeof(string))) {
                    memo = Clipboard.GetText();//クリップボードゲット
                }
            }
            return memo;
        }


        private void Form1_Load(object sender, EventArgs e) {
            dataGridView1.AllowDrop = true;
            //strList = new List<string>();

            //-------------------------------------------------------------------//
            FolderPath = Exe_Path.exe_Path() + history_Name;
            //--------------------------------------------------------------------//
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;

            //----------------------------------------------------------------------//
            //--------------------------------------------------------------------//

            //-------------------------------------------------------------------------//
            // アプリケーションの設定を読み込む
                    Properties.Settings.Default.Reload();
                try {
                    Console.WriteLine("コンソール１");
                    System.Diagnostics.Debug.WriteLine("デバッグ");
                } catch (Exception) {
                    button1.Enabled = false;
                }
        }

        private void Form1_Shown(object sender, EventArgs e) {

            subData = new SQLite_URL_Pass(Exe_Path.exe_Path()+ @"SubDataList\subdata.db");
            dataGridView1.ColumnCount = 4;
            Select_Table_Name = "strstanp";

            Select_ResetData(ref dataGridView1, Select_Table_Name);
        }



        public static void Select_ResetData(ref DataGridView dgv,string Select_Table_Name) {
            dgv.Rows.Clear();
            #region -------------【  SELECT文 】---------------------------------------//
            if (subData.Get_SELECT_ALL(Select_Table_Name)) {

                DebugUtils.DumpDataTable(subData.strStanpSrc);

                for (int i = 0; i < subData.strStanpSrc.Rows.Count; i++) {
                    dgv.Rows.Add();
                    DataGridViewRow newRow = dgv.Rows[i];
                    DataRow row = subData.strStanpSrc.Rows[i];
                    for (int j = 0; j < row.ItemArray.Length; j++) {

                        var item = row.ItemArray[j];
                        newRow.Cells[j + 1].Value = item.ToString();
                    }
                }

                //dataGridView1.DataSource = subData.strStanpSrc;//データソース
                if (dgv.ColumnCount > 0) {
                    dgv.Columns[0].FillWeight = 10;
                }
            }
            //------------    【   末尾  】     ----------------//
            #endregion
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            DataGridView dgv = (DataGridView)sender;
            //"Button"列ならば、ボタンがクリックされた
            if (e.ColumnIndex == 1) {
                //https://dobon.net/vb/dotnet/datagridview/datagridviewbuttoncolumn.html
                Set_CripBord(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                DataGridViewButtonColumn column = new DataGridViewButtonColumn();
                string[] mojis = { dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() };
                //// フォルダ内の全てのテキストファイルのパスを取得
                //while (true) {
                //    string[] textFiles = Directory.GetFiles(FolderPath, "*.txt");
                //    if (textFiles.Length > 20) {
                //        Text_IO.txtDelete(textFiles[0]);
                //    } else { break; }
                //}
                //Text_IO.TextFileReWrite(Exe_Path.exe_Path() + history_Name + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + ".txt", dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                //AddRowToDataGridView2(mojis, false);
                //System.Diagnostics.Debug.Write("行の追加");
            } else if (e.ColumnIndex == 0) {
                // null/true/false のいづれかなので、現在値が null だったら その逆の？ true、現在値がどちらかだったら、逆のどちらかをセット
                var cell = dataGridView1.CurrentCell as DataGridViewCheckBoxCell;
                var isChecked = cell.Value is null ? true : (bool)cell.Value ? false : true;
                cell.Value = isChecked;

                dataGridView1.RefreshEdit();
                dataGridView1.NotifyCurrentCellDirty(true);
            }
        }




        #region -------------【  サブデータ　の追加、更新、削除  】---------------------------------------//
        private void Stanp_更新ToolStripMenuItem2_Click(object sender, EventArgs e) {

            int row = dataGridView1.CurrentCell.RowIndex;
            string ID = dataGridView1.Rows[row].Cells[3].Value.ToString();
            string[] InsertStr = new string[] { dataGridView1.Rows[row].Cells[1].Value.ToString(), dataGridView1.Rows[row].Cells[2].Value.ToString() };
            Update_Flg = true;
            MyCreate.subForm subForm = new subForm(ID,InsertStr, Select_Table_Name);
            subForm.Show();
        }

        private void Stanp_追加ToolStripMenuItem2_Click(object sender, EventArgs e) {
         
            string ID = "";
            string[] InsertStr = new string[] { };

            MyCreate.subForm subForm = new subForm(ID, InsertStr, Select_Table_Name);
            subForm.Show();
        }

        private void Stanp_削除ToolStripMenuItem2_Click(object sender, EventArgs e) {
            if (dataGridView_CheckBox_Cheked_Counter(dataGridView1) > 0) {

                List<string> idList = new List<string>();

                for (int i = 0; i < dataGridView1.RowCount; i++) {
                    if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value)) {
                        idList.Add("\t" + dataGridView1.Rows[i].Cells[1].Value.ToString());
                    }
                }


                string idary = MyCreate.Str_Line.List_Joint_moji(idList);
                DialogResult dr = MessageBox.Show($"「id＝\n{idary}」\n" +
                    $"を削除します。\n本当によろしいですか？\n", "確認", MessageBoxButtons.OKCancel);
                if (dr == System.Windows.Forms.DialogResult.OK) {

                    for (int i = 0; i < dataGridView1.RowCount; i++) {
                        if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value)) {
                            string id = dataGridView1.Rows[i].Cells[3].Value.ToString();
                            subData.Delete_Query(Select_Table_Name, id);
                        }
                    }
                } else//OK以外の動作
                { return; }

            } else {
                MessageBox.Show("チェックされた項目がありません");
            }
            Get_Table = Get_Table;
        }
        //------------    【   末尾  】     ----------------//
        #endregion

        private void テーブルの変更ToolStripMenuItem_Click(object sender, EventArgs e) {
            MyCreate.SelectForm1 selectForm1 = new SelectForm1();
            selectForm1.Show();
        }


        #region -------------【 データRESET 】---------------------------------------//
        private void SubData_ReSet(MyCreate.TableNum tableNum) {

                    if (subData.Get_SELECT_ALL(Select_Table_Name)) {

                    } else {
                        MessageBox.Show("更新失敗(´；ω；`)ｳｩｩ");
                    }
        }
        //------------    【   末尾  】     ----------------//
        #endregion

        private int dataGridView_CheckBox_Cheked_Counter(DataGridView dgv) {
            // カウンタ変数を初期化する
            int cnt = 0;

            // datagridviewの行数分処理を繰り返すForeach文
            foreach (DataGridViewRow row in dgv.Rows) {
                // チェックボックスの状態(チェックの有無)を取得し、chkに格納する
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                if (chk.Value != DBNull.Value && Convert.ToBoolean(chk.Value)) {
                    // chk(チェックボックスのセル)の値がDBNull.Valueでないこと、かつチェックボックスにチェックが付いている場合
                    // カウンタをインクリメントする
                    cnt++;
                }
            }
            return cnt;
        }

        private void MainForm1_FormClosing(object sender, FormClosingEventArgs e) {
            subData.DataBaseListCloseing();
        }



        private void button1_Click(object sender, EventArgs e) {
            if (Select_Table_Name == "") { return; }
            string moji = Interaction.InputBox("入力画面", "新規テーブルの追加");
            string sql = "";
                MessageBox.Show("追加クエリ");
            if (string_stamp1.MainForm1.subData.INSERT_SQL(InsertSet(moji),Select_Table_Name, ref sql)) {
                this.DialogResult = DialogResult.OK;
                this.Close();
            } else { MessageBox.Show("追加失敗！！"); }
        }

       private Dictionary<string, string> InsertSet(string moji) {
            Dictionary<string, string> valset = new Dictionary<string, string>();
            valset.Add("text1", moji);
            valset.Add("text2", richTextBox1.Text);
            return valset;
       }

        private void button2_Click(object sender, EventArgs e) {
            System.Windows.Forms.IDataObject data = Clipboard.GetDataObject();
            if (data != null) {

                if (data.GetDataPresent(typeof(string))) {
                    richTextBox1.Text = Clipboard.GetText();//クリップボードゲット
                }
            }
        }

        private void テキストClearToolStripMenuItem_Click(object sender, EventArgs e) {
            richTextBox1.Clear();
        }

        private void テキストファイルで保存ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (dataGridView_CheckBox_Cheked_Counter(dataGridView1) > 0) {

                List<string> idList = new List<string>();

                for (int i = 0; i < dataGridView1.RowCount; i++) {
                    if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value)) {
                        idList.Add("\t" + dataGridView1.Rows[i].Cells[1].Value.ToString());
                    }
                }


                string idary = MyCreate.Str_Line.List_Joint_moji(idList);
                DialogResult dr = MessageBox.Show($"「id＝\n{idary}」\n" +
                    $"を保存します。\n本当によろしいですか？\n", "確認", MessageBoxButtons.OKCancel);
                if (dr == System.Windows.Forms.DialogResult.OK) {

                    for (int i = 0; i < dataGridView1.RowCount; i++) {
                        if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value)) {
                            Text_IO.TextFileReWrite(Exe_Path.DownLoad_path() + dataGridView1.Rows[i].Cells[1].Value.ToString() + ".txt", dataGridView1.Rows[i].Cells[2].Value.ToString());
                        }
                    }
                } else//OK以外の動作
                { return; }



            } else {
                MessageBox.Show("チェックされた項目がありません");
            }
        }
    }

}
