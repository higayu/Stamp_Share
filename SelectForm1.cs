using MyCreate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.IO;

namespace MyCreate {
    public partial class SelectForm1 : Form {


        public SelectForm1() {
            InitializeComponent();
        }

        private void Table_ReSet() {
            listBox1.Items.Clear();
            List<string> list = new List<string>();
            if (string_stamp1.MainForm1.subData.Get_TableList(ref list)) {
                listBox1.Items.AddRange(list.ToArray());
            }
        }

        #region  // -------------【  Lodeイベント  】---------------------------------------//
        private void SelectForm1_Load(object sender, EventArgs e) {
            Table_ReSet();
        }
        //------------    【   末尾  】     ----------------//
        #endregion


        private void button1_Click(object sender, EventArgs e) {
           string_stamp1.Program.mainForm.Get_Table = listBox1.Text;
           this.Close();
        }

        private void CANCEL_btn_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }



        private void SelectForm1_FormClosing(object sender, FormClosingEventArgs e) {

        }

        private void 新規テーブル追加ToolStripMenuItem_Click(object sender, EventArgs e) {

            string moji = Interaction.InputBox("入力画面", "新規データベースの追加");

            if (moji == "") { MessageBox.Show("キャンセル"); return; }
            if (string_stamp1.MainForm1.subData.New_Table(moji) ){
                MessageBox.Show("テーブル追加成功(*'▽')！！");
                Table_ReSet();
            } else {
                MessageBox.Show("データベースの追加失敗...");
            }
        }

    }
}
