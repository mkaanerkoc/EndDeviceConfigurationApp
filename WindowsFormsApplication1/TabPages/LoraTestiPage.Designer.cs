namespace WindowsFormsApplication1.TabPages
{
    partial class LoraTestiPage
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearReceivedMsgsBtn = new System.Windows.Forms.Button();
            this.sendGetEchoSettingsBtn = new System.Windows.Forms.Button();
            this.rxPkgRSSITb = new System.Windows.Forms.TextBox();
            this.sendReceiveLoRaPackageCmdBtn = new System.Windows.Forms.Button();
            this.receiveLoRaRxPkgFromUARTCb = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rxPkgToTb = new System.Windows.Forms.TextBox();
            this.rxPkgFromTb = new System.Windows.Forms.TextBox();
            this.rxPkgDestinationTb = new System.Windows.Forms.TextBox();
            this.rxPkgSourceTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.goruntulemeSecimiCb = new System.Windows.Forms.ComboBox();
            this.rxLoRaMsgTb = new System.Windows.Forms.TextBox();
            this.rxPkgListView = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.getNeighbourListBtn = new System.Windows.Forms.Button();
            this.neighborListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txLoraPkgDestTb = new System.Windows.Forms.TextBox();
            this.txLoRaPackageDataTb = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sendLoRaPackageBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.loraMessageTypeCb = new System.Windows.Forms.ComboBox();
            this.loraServiceTypeCb = new System.Windows.Forms.ComboBox();
            this.loraTimeOutTb = new System.Windows.Forms.TextBox();
            this.loraRetryCountTb = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.loraSendngPackageDataViewTypeCb = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearReceivedMsgsBtn);
            this.groupBox1.Controls.Add(this.sendGetEchoSettingsBtn);
            this.groupBox1.Controls.Add(this.rxPkgRSSITb);
            this.groupBox1.Controls.Add(this.sendReceiveLoRaPackageCmdBtn);
            this.groupBox1.Controls.Add(this.receiveLoRaRxPkgFromUARTCb);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rxPkgToTb);
            this.groupBox1.Controls.Add(this.rxPkgFromTb);
            this.groupBox1.Controls.Add(this.rxPkgDestinationTb);
            this.groupBox1.Controls.Add(this.rxPkgSourceTb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.goruntulemeSecimiCb);
            this.groupBox1.Controls.Add(this.rxLoRaMsgTb);
            this.groupBox1.Controls.Add(this.rxPkgListView);
            this.groupBox1.Location = new System.Drawing.Point(490, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 551);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LoRa Mesaj Yanıtı";
            // 
            // clearReceivedMsgsBtn
            // 
            this.clearReceivedMsgsBtn.Location = new System.Drawing.Point(18, 504);
            this.clearReceivedMsgsBtn.Name = "clearReceivedMsgsBtn";
            this.clearReceivedMsgsBtn.Size = new System.Drawing.Size(294, 37);
            this.clearReceivedMsgsBtn.TabIndex = 18;
            this.clearReceivedMsgsBtn.Text = "Temizle";
            this.clearReceivedMsgsBtn.UseVisualStyleBackColor = true;
            this.clearReceivedMsgsBtn.Click += new System.EventHandler(this.clearReceivedMsgsBtn_Click);
            // 
            // sendGetEchoSettingsBtn
            // 
            this.sendGetEchoSettingsBtn.Location = new System.Drawing.Point(247, 36);
            this.sendGetEchoSettingsBtn.Name = "sendGetEchoSettingsBtn";
            this.sendGetEchoSettingsBtn.Size = new System.Drawing.Size(65, 35);
            this.sendGetEchoSettingsBtn.TabIndex = 17;
            this.sendGetEchoSettingsBtn.Text = "Getir";
            this.sendGetEchoSettingsBtn.UseVisualStyleBackColor = true;
            this.sendGetEchoSettingsBtn.Click += new System.EventHandler(this.sendGetEchoSettingsBtn_Click);
            // 
            // rxPkgRSSITb
            // 
            this.rxPkgRSSITb.Location = new System.Drawing.Point(479, 224);
            this.rxPkgRSSITb.Name = "rxPkgRSSITb";
            this.rxPkgRSSITb.Size = new System.Drawing.Size(129, 22);
            this.rxPkgRSSITb.TabIndex = 16;
            // 
            // sendReceiveLoRaPackageCmdBtn
            // 
            this.sendReceiveLoRaPackageCmdBtn.Location = new System.Drawing.Point(175, 36);
            this.sendReceiveLoRaPackageCmdBtn.Name = "sendReceiveLoRaPackageCmdBtn";
            this.sendReceiveLoRaPackageCmdBtn.Size = new System.Drawing.Size(66, 35);
            this.sendReceiveLoRaPackageCmdBtn.TabIndex = 15;
            this.sendReceiveLoRaPackageCmdBtn.Text = "Kaydet";
            this.sendReceiveLoRaPackageCmdBtn.UseVisualStyleBackColor = true;
            this.sendReceiveLoRaPackageCmdBtn.Click += new System.EventHandler(this.sendReceiveLoRaPackageCmdBtn_Click);
            // 
            // receiveLoRaRxPkgFromUARTCb
            // 
            this.receiveLoRaRxPkgFromUARTCb.AutoSize = true;
            this.receiveLoRaRxPkgFromUARTCb.Location = new System.Drawing.Point(18, 44);
            this.receiveLoRaRxPkgFromUARTCb.Name = "receiveLoRaRxPkgFromUARTCb";
            this.receiveLoRaRxPkgFromUARTCb.Size = new System.Drawing.Size(151, 21);
            this.receiveLoRaRxPkgFromUARTCb.TabIndex = 14;
            this.receiveLoRaRxPkgFromUARTCb.Text = "LoRa Mesajlarını Al";
            this.receiveLoRaRxPkgFromUARTCb.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Signal Strength";
            // 
            // rxPkgToTb
            // 
            this.rxPkgToTb.Location = new System.Drawing.Point(480, 195);
            this.rxPkgToTb.Name = "rxPkgToTb";
            this.rxPkgToTb.Size = new System.Drawing.Size(129, 22);
            this.rxPkgToTb.TabIndex = 12;
            // 
            // rxPkgFromTb
            // 
            this.rxPkgFromTb.Location = new System.Drawing.Point(480, 165);
            this.rxPkgFromTb.Name = "rxPkgFromTb";
            this.rxPkgFromTb.Size = new System.Drawing.Size(129, 22);
            this.rxPkgFromTb.TabIndex = 11;
            // 
            // rxPkgDestinationTb
            // 
            this.rxPkgDestinationTb.Location = new System.Drawing.Point(479, 136);
            this.rxPkgDestinationTb.Name = "rxPkgDestinationTb";
            this.rxPkgDestinationTb.Size = new System.Drawing.Size(129, 22);
            this.rxPkgDestinationTb.TabIndex = 10;
            // 
            // rxPkgSourceTb
            // 
            this.rxPkgSourceTb.Location = new System.Drawing.Point(479, 107);
            this.rxPkgSourceTb.Name = "rxPkgSourceTb";
            this.rxPkgSourceTb.Size = new System.Drawing.Size(129, 22);
            this.rxPkgSourceTb.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "To Unit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "From Unit ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Destination Unit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Source Unit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Paket Mesaj İçeriği";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Görüntüleme Seçimi";
            // 
            // goruntulemeSecimiCb
            // 
            this.goruntulemeSecimiCb.FormattingEnabled = true;
            this.goruntulemeSecimiCb.Items.AddRange(new object[] {
            "HEXADECIMAL",
            "DECIMAL",
            "STRING ASCII"});
            this.goruntulemeSecimiCb.Location = new System.Drawing.Point(505, 508);
            this.goruntulemeSecimiCb.Name = "goruntulemeSecimiCb";
            this.goruntulemeSecimiCb.Size = new System.Drawing.Size(121, 24);
            this.goruntulemeSecimiCb.TabIndex = 2;
            // 
            // rxLoRaMsgTb
            // 
            this.rxLoRaMsgTb.Location = new System.Drawing.Point(327, 307);
            this.rxLoRaMsgTb.Multiline = true;
            this.rxLoRaMsgTb.Name = "rxLoRaMsgTb";
            this.rxLoRaMsgTb.Size = new System.Drawing.Size(300, 185);
            this.rxLoRaMsgTb.TabIndex = 1;
            // 
            // rxPkgListView
            // 
            this.rxPkgListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader6,
            this.columnHeader5});
            this.rxPkgListView.FullRowSelect = true;
            this.rxPkgListView.GridLines = true;
            this.rxPkgListView.Location = new System.Drawing.Point(18, 93);
            this.rxPkgListView.MultiSelect = false;
            this.rxPkgListView.Name = "rxPkgListView";
            this.rxPkgListView.Size = new System.Drawing.Size(294, 405);
            this.rxPkgListView.TabIndex = 0;
            this.rxPkgListView.UseCompatibleStateImageBehavior = false;
            this.rxPkgListView.SelectedIndexChanged += new System.EventHandler(this.rxPkgListView_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Package Type ";
            this.columnHeader7.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Saat";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "RSSI";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.getNeighbourListBtn);
            this.groupBox2.Controls.Add(this.neighborListView);
            this.groupBox2.Location = new System.Drawing.Point(20, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 200);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unite Komsuları";
            // 
            // getNeighbourListBtn
            // 
            this.getNeighbourListBtn.Location = new System.Drawing.Point(38, 153);
            this.getNeighbourListBtn.Name = "getNeighbourListBtn";
            this.getNeighbourListBtn.Size = new System.Drawing.Size(377, 37);
            this.getNeighbourListBtn.TabIndex = 1;
            this.getNeighbourListBtn.Text = "Komşu Bilgilerini Getir";
            this.getNeighbourListBtn.UseVisualStyleBackColor = true;
            this.getNeighbourListBtn.Click += new System.EventHandler(this.getNeighbourListBtn_Click);
            // 
            // neighborListView
            // 
            this.neighborListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.neighborListView.FullRowSelect = true;
            this.neighborListView.GridLines = true;
            this.neighborListView.Location = new System.Drawing.Point(38, 24);
            this.neighborListView.Name = "neighborListView";
            this.neighborListView.Size = new System.Drawing.Size(377, 123);
            this.neighborListView.TabIndex = 0;
            this.neighborListView.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Degree";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "RSSI";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Last Package Rx";
            this.columnHeader4.Width = 100;
            // 
            // txLoraPkgDestTb
            // 
            this.txLoraPkgDestTb.Location = new System.Drawing.Point(123, 23);
            this.txLoraPkgDestTb.MaxLength = 16;
            this.txLoraPkgDestTb.Name = "txLoraPkgDestTb";
            this.txLoraPkgDestTb.Size = new System.Drawing.Size(231, 22);
            this.txLoraPkgDestTb.TabIndex = 7;
            // 
            // txLoRaPackageDataTb
            // 
            this.txLoRaPackageDataTb.Location = new System.Drawing.Point(20, 209);
            this.txLoRaPackageDataTb.MaxLength = 230;
            this.txLoRaPackageDataTb.Multiline = true;
            this.txLoRaPackageDataTb.Name = "txLoRaPackageDataTb";
            this.txLoRaPackageDataTb.Size = new System.Drawing.Size(453, 126);
            this.txLoRaPackageDataTb.TabIndex = 8;
            this.txLoRaPackageDataTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txLoRaPackageDataTb_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // sendLoRaPackageBtn
            // 
            this.sendLoRaPackageBtn.Location = new System.Drawing.Point(401, 21);
            this.sendLoRaPackageBtn.Name = "sendLoRaPackageBtn";
            this.sendLoRaPackageBtn.Size = new System.Drawing.Size(72, 90);
            this.sendLoRaPackageBtn.TabIndex = 10;
            this.sendLoRaPackageBtn.Text = "Gönder";
            this.sendLoRaPackageBtn.UseVisualStyleBackColor = true;
            this.sendLoRaPackageBtn.Click += new System.EventHandler(this.sendLoRaPackageBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Hedef(ler)";
            // 
            // loraMessageTypeCb
            // 
            this.loraMessageTypeCb.FormattingEnabled = true;
            this.loraMessageTypeCb.Items.AddRange(new object[] {
            "Ping Message",
            "Echo Message",
            "Uncategorized Reliable Msg",
            "Uncategorized Unreliable Msg"});
            this.loraMessageTypeCb.Location = new System.Drawing.Point(123, 55);
            this.loraMessageTypeCb.Name = "loraMessageTypeCb";
            this.loraMessageTypeCb.Size = new System.Drawing.Size(231, 24);
            this.loraMessageTypeCb.TabIndex = 14;
            // 
            // loraServiceTypeCb
            // 
            this.loraServiceTypeCb.FormattingEnabled = true;
            this.loraServiceTypeCb.Items.AddRange(new object[] {
            "UNICAST",
            "MULTICAST",
            "BROADCAST"});
            this.loraServiceTypeCb.Location = new System.Drawing.Point(123, 86);
            this.loraServiceTypeCb.Name = "loraServiceTypeCb";
            this.loraServiceTypeCb.Size = new System.Drawing.Size(231, 24);
            this.loraServiceTypeCb.TabIndex = 15;
            // 
            // loraTimeOutTb
            // 
            this.loraTimeOutTb.Location = new System.Drawing.Point(149, 124);
            this.loraTimeOutTb.Name = "loraTimeOutTb";
            this.loraTimeOutTb.Size = new System.Drawing.Size(63, 22);
            this.loraTimeOutTb.TabIndex = 17;
            // 
            // loraRetryCountTb
            // 
            this.loraRetryCountTb.Location = new System.Drawing.Point(360, 123);
            this.loraRetryCountTb.Name = "loraRetryCountTb";
            this.loraRetryCountTb.Size = new System.Drawing.Size(34, 22);
            this.loraRetryCountTb.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Mesaj Türü";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Servis Türü ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Zaman Aşımı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(252, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "Deneme Sayısı";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "Gönderilecek Data";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(177, 183);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 17);
            this.label14.TabIndex = 19;
            this.label14.Text = "Görüntüleme Seçimi";
            // 
            // loraSendngPackageDataViewTypeCb
            // 
            this.loraSendngPackageDataViewTypeCb.FormattingEnabled = true;
            this.loraSendngPackageDataViewTypeCb.Items.AddRange(new object[] {
            "HEXADECIMAL",
            "DECIMAL",
            "STRING ASCII"});
            this.loraSendngPackageDataViewTypeCb.Location = new System.Drawing.Point(318, 179);
            this.loraSendngPackageDataViewTypeCb.Name = "loraSendngPackageDataViewTypeCb";
            this.loraSendngPackageDataViewTypeCb.Size = new System.Drawing.Size(155, 24);
            this.loraSendngPackageDataViewTypeCb.TabIndex = 18;
            this.loraSendngPackageDataViewTypeCb.SelectedIndexChanged += new System.EventHandler(this.loraSendngPackageDataViewTypeCb_SelectedIndexChanged);
            // 
            // LoraTestiPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.loraSendngPackageDataViewTypeCb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.loraRetryCountTb);
            this.Controls.Add(this.loraTimeOutTb);
            this.Controls.Add(this.loraServiceTypeCb);
            this.Controls.Add(this.loraMessageTypeCb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sendLoRaPackageBtn);
            this.Controls.Add(this.txLoRaPackageDataTb);
            this.Controls.Add(this.txLoraPkgDestTb);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoraTestiPage";
            this.Size = new System.Drawing.Size(1137, 585);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button getNeighbourListBtn;
        private System.Windows.Forms.ListView neighborListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView rxPkgListView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rxPkgToTb;
        private System.Windows.Forms.TextBox rxPkgFromTb;
        private System.Windows.Forms.TextBox rxPkgDestinationTb;
        private System.Windows.Forms.TextBox rxPkgSourceTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox goruntulemeSecimiCb;
        private System.Windows.Forms.TextBox rxLoRaMsgTb;
        private System.Windows.Forms.TextBox txLoraPkgDestTb;
        private System.Windows.Forms.TextBox txLoRaPackageDataTb;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button sendLoRaPackageBtn;
        private System.Windows.Forms.CheckBox receiveLoRaRxPkgFromUARTCb;
        private System.Windows.Forms.Button sendReceiveLoRaPackageCmdBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox rxPkgRSSITb;
        private System.Windows.Forms.Button sendGetEchoSettingsBtn;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ComboBox loraMessageTypeCb;
        private System.Windows.Forms.ComboBox loraServiceTypeCb;
        private System.Windows.Forms.TextBox loraTimeOutTb;
        private System.Windows.Forms.MaskedTextBox loraRetryCountTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox loraSendngPackageDataViewTypeCb;
        private System.Windows.Forms.Button clearReceivedMsgsBtn;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}
