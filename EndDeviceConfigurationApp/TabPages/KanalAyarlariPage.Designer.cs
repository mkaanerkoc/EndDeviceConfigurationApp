namespace WindowsFormsApplication1.TabPages
{
    partial class KanalAyarlariPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kanallarListView = new System.Windows.Forms.ListView();
            this.getChannelsBtn = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.getChannelsBtn);
            this.groupBox1.Controls.Add(this.kanallarListView);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1119, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kanal Listesi";
            // 
            // kanallarListView
            // 
            this.kanallarListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.kanallarListView.Location = new System.Drawing.Point(18, 76);
            this.kanallarListView.Name = "kanallarListView";
            this.kanallarListView.Size = new System.Drawing.Size(1085, 186);
            this.kanallarListView.TabIndex = 0;
            this.kanallarListView.UseCompatibleStateImageBehavior = false;
            // 
            // getChannelsBtn
            // 
            this.getChannelsBtn.Location = new System.Drawing.Point(813, 21);
            this.getChannelsBtn.Name = "getChannelsBtn";
            this.getChannelsBtn.Size = new System.Drawing.Size(278, 37);
            this.getChannelsBtn.TabIndex = 1;
            this.getChannelsBtn.Text = "Kanalları Getir";
            this.getChannelsBtn.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cihaz Tag";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Giriş/Çıkış";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Periyot";
            // 
            // KanalAyarlariPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "KanalAyarlariPage";
            this.Size = new System.Drawing.Size(1142, 593);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView kanallarListView;
        private System.Windows.Forms.Button getChannelsBtn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
