
namespace string_stamp1 {
    partial class MainForm1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.StanpDataGv1Context = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.追加ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.更新ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.チェック項目を全て削除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.テーブルの変更ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.テキストファイルで保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.テキストClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.historyStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.削除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.テキストファイル保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.StanpDataGv1Context.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.historyStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6});
            this.dataGridView1.ContextMenuStrip = this.StanpDataGv1Context;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(297, 238);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 30F;
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 30;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // StanpDataGv1Context
            // 
            this.StanpDataGv1Context.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StanpDataGv1Context.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StanpDataGv1Context.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.追加ToolStripMenuItem2,
            this.更新ToolStripMenuItem2,
            this.チェック項目を全て削除ToolStripMenuItem,
            this.テーブルの変更ToolStripMenuItem,
            this.テキストファイルで保存ToolStripMenuItem});
            this.StanpDataGv1Context.Name = "StanpContext";
            this.StanpDataGv1Context.Size = new System.Drawing.Size(315, 184);
            // 
            // 追加ToolStripMenuItem2
            // 
            this.追加ToolStripMenuItem2.Name = "追加ToolStripMenuItem2";
            this.追加ToolStripMenuItem2.Size = new System.Drawing.Size(314, 36);
            this.追加ToolStripMenuItem2.Text = "入力追加";
            this.追加ToolStripMenuItem2.Click += new System.EventHandler(this.Stanp_追加ToolStripMenuItem2_Click);
            // 
            // 更新ToolStripMenuItem2
            // 
            this.更新ToolStripMenuItem2.Name = "更新ToolStripMenuItem2";
            this.更新ToolStripMenuItem2.Size = new System.Drawing.Size(314, 36);
            this.更新ToolStripMenuItem2.Text = "更新";
            this.更新ToolStripMenuItem2.Click += new System.EventHandler(this.Stanp_更新ToolStripMenuItem2_Click);
            // 
            // チェック項目を全て削除ToolStripMenuItem
            // 
            this.チェック項目を全て削除ToolStripMenuItem.Name = "チェック項目を全て削除ToolStripMenuItem";
            this.チェック項目を全て削除ToolStripMenuItem.Size = new System.Drawing.Size(314, 36);
            this.チェック項目を全て削除ToolStripMenuItem.Text = "チェック項目を全て削除";
            this.チェック項目を全て削除ToolStripMenuItem.Click += new System.EventHandler(this.Stanp_削除ToolStripMenuItem2_Click);
            // 
            // テーブルの変更ToolStripMenuItem
            // 
            this.テーブルの変更ToolStripMenuItem.Name = "テーブルの変更ToolStripMenuItem";
            this.テーブルの変更ToolStripMenuItem.Size = new System.Drawing.Size(314, 36);
            this.テーブルの変更ToolStripMenuItem.Text = "テーブルの変更";
            this.テーブルの変更ToolStripMenuItem.Click += new System.EventHandler(this.テーブルの変更ToolStripMenuItem_Click);
            // 
            // テキストファイルで保存ToolStripMenuItem
            // 
            this.テキストファイルで保存ToolStripMenuItem.Name = "テキストファイルで保存ToolStripMenuItem";
            this.テキストファイルで保存ToolStripMenuItem.Size = new System.Drawing.Size(314, 36);
            this.テキストファイルで保存ToolStripMenuItem.Text = "テキストファイルで保存";
            this.テキストファイルで保存ToolStripMenuItem.Click += new System.EventHandler(this.テキストファイルで保存ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 32);
            this.panel1.TabIndex = 10;
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(77, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(147, 32);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.テキストClearToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(216, 40);
            // 
            // テキストClearToolStripMenuItem
            // 
            this.テキストClearToolStripMenuItem.Name = "テキストClearToolStripMenuItem";
            this.テキストClearToolStripMenuItem.Size = new System.Drawing.Size(215, 36);
            this.テキストClearToolStripMenuItem.Text = "テキストClear";
            this.テキストClearToolStripMenuItem.Click += new System.EventHandler(this.テキストClearToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "paste";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(224, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "push";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // historyStrip1
            // 
            this.historyStrip1.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.historyStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.historyStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.削除ToolStripMenuItem,
            this.テキストファイル保存ToolStripMenuItem});
            this.historyStrip1.Name = "historyStrip1";
            this.historyStrip1.Size = new System.Drawing.Size(319, 88);
            // 
            // 削除ToolStripMenuItem
            // 
            this.削除ToolStripMenuItem.Name = "削除ToolStripMenuItem";
            this.削除ToolStripMenuItem.Size = new System.Drawing.Size(318, 42);
            this.削除ToolStripMenuItem.Text = "削除";
            // 
            // テキストファイル保存ToolStripMenuItem
            // 
            this.テキストファイル保存ToolStripMenuItem.Name = "テキストファイル保存ToolStripMenuItem";
            this.テキストファイル保存ToolStripMenuItem.Size = new System.Drawing.Size(318, 42);
            this.テキストファイル保存ToolStripMenuItem.Text = "テキストファイル保存";
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 270);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm1";
            this.Text = "MainForm1_Share_Ver";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.StanpDataGv1Context.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.historyStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip StanpDataGv1Context;
        private System.Windows.Forms.ToolStripMenuItem 追加ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 更新ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem チェック項目を全て削除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem テーブルの変更ToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.ContextMenuStrip historyStrip1;
        private System.Windows.Forms.ToolStripMenuItem 削除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem テキストファイル保存ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem テキストClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem テキストファイルで保存ToolStripMenuItem;
    }
}

