namespace WindowsFormsApplication1.TabPages
{
    partial class DepolamaPage
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label29 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(228, 367);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 46);
            this.button4.TabIndex = 7;
            this.button4.Text = "Dosyayı Sil";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(79, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 46);
            this.button3.TabIndex = 6;
            this.button3.Text = "Dosyayı İndir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Location = new System.Drawing.Point(32, 58);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(444, 232);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İsim";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Boyut";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Olusturulma Tarihi";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(29, 26);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(113, 17);
            this.label29.TabIndex = 4;
            this.label29.Text = "Mevcut Dosyalar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(444, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "SD Card Dosyalarını Getir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DepolamaPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label29);
            this.Name = "DepolamaPage";
            this.Size = new System.Drawing.Size(1109, 603);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button button1;
    }
}
