namespace WindowsFormsApplication1.TabPages
{
    partial class CihazKonfigurasyonPage
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.setRoutingInfoBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.setStaticRoutingInfoBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.st_rtNextHopTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.st_rtDestTb = new System.Windows.Forms.TextBox();
            this.st_rtFromTb = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.getRoutingInfoBtn = new System.Windows.Forms.Button();
            this.staticRoutingInfoListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button14 = new System.Windows.Forms.Button();
            this.getLoraTxPowerBtn = new System.Windows.Forms.Button();
            this.getDeviceLoRaGatewayIDbtn = new System.Windows.Forms.Button();
            this.getDeviceLoRaIDbtn = new System.Windows.Forms.Button();
            this.getDeviceUniqueIDbtn = new System.Windows.Forms.Button();
            this.getLoraConfigurationsBtn = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.setDeviceLoRaGatewayIDbtn = new System.Windows.Forms.Button();
            this.setDeviceLoRaIDbtn = new System.Windows.Forms.Button();
            this.setDeviceUniqueIDbtn = new System.Windows.Forms.Button();
            this.setLoraConfigurationsBtn = new System.Windows.Forms.Button();
            this.devGatewayIDTb = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.devSpreadingFactorCb = new System.Windows.Forms.ComboBox();
            this.devCodingRateCb = new System.Windows.Forms.ComboBox();
            this.devBandwidthCb = new System.Windows.Forms.ComboBox();
            this.devFreqTb = new System.Windows.Forms.TextBox();
            this.devTxPowerTb = new System.Windows.Forms.TextBox();
            this.devLoraIDTb = new System.Windows.Forms.TextBox();
            this.devUniqueIDTb = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.setRoutingInfoBtn);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.getRoutingInfoBtn);
            this.groupBox3.Controls.Add(this.staticRoutingInfoListView);
            this.groupBox3.Location = new System.Drawing.Point(469, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(647, 542);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yönlendirme Rotası";
            // 
            // setRoutingInfoBtn
            // 
            this.setRoutingInfoBtn.Location = new System.Drawing.Point(18, 271);
            this.setRoutingInfoBtn.Name = "setRoutingInfoBtn";
            this.setRoutingInfoBtn.Size = new System.Drawing.Size(283, 31);
            this.setRoutingInfoBtn.TabIndex = 3;
            this.setRoutingInfoBtn.Text = "Yönlendirme Bilgisini Güncelle";
            this.setRoutingInfoBtn.UseVisualStyleBackColor = true;
            this.setRoutingInfoBtn.Click += new System.EventHandler(this.setRoutingInfoBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.setStaticRoutingInfoBtn);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.st_rtNextHopTb);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.st_rtDestTb);
            this.groupBox4.Controls.Add(this.st_rtFromTb);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Location = new System.Drawing.Point(307, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(331, 281);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktarıcı Bilgisi";
            // 
            // setStaticRoutingInfoBtn
            // 
            this.setStaticRoutingInfoBtn.Location = new System.Drawing.Point(238, 25);
            this.setStaticRoutingInfoBtn.Name = "setStaticRoutingInfoBtn";
            this.setStaticRoutingInfoBtn.Size = new System.Drawing.Size(75, 79);
            this.setStaticRoutingInfoBtn.TabIndex = 8;
            this.setStaticRoutingInfoBtn.Text = "Kaydet";
            this.setStaticRoutingInfoBtn.UseVisualStyleBackColor = true;
            this.setStaticRoutingInfoBtn.Click += new System.EventHandler(this.setStaticRoutingInfoBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Next Hop";
            // 
            // st_rtNextHopTb
            // 
            this.st_rtNextHopTb.Location = new System.Drawing.Point(123, 82);
            this.st_rtNextHopTb.Name = "st_rtNextHopTb";
            this.st_rtNextHopTb.Size = new System.Drawing.Size(100, 22);
            this.st_rtNextHopTb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destination";
            // 
            // st_rtDestTb
            // 
            this.st_rtDestTb.Location = new System.Drawing.Point(123, 55);
            this.st_rtDestTb.Name = "st_rtDestTb";
            this.st_rtDestTb.Size = new System.Drawing.Size(100, 22);
            this.st_rtDestTb.TabIndex = 3;
            // 
            // st_rtFromTb
            // 
            this.st_rtFromTb.Location = new System.Drawing.Point(123, 28);
            this.st_rtFromTb.Name = "st_rtFromTb";
            this.st_rtFromTb.Size = new System.Drawing.Size(100, 22);
            this.st_rtFromTb.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(178, 225);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 50);
            this.button5.TabIndex = 1;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(65, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 50);
            this.button4.TabIndex = 0;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // getRoutingInfoBtn
            // 
            this.getRoutingInfoBtn.Location = new System.Drawing.Point(18, 226);
            this.getRoutingInfoBtn.Name = "getRoutingInfoBtn";
            this.getRoutingInfoBtn.Size = new System.Drawing.Size(283, 31);
            this.getRoutingInfoBtn.TabIndex = 1;
            this.getRoutingInfoBtn.Text = "Yönlendirme Bilgisini Getir";
            this.getRoutingInfoBtn.UseVisualStyleBackColor = true;
            this.getRoutingInfoBtn.Click += new System.EventHandler(this.getRoutingInfoBtn_Click);
            // 
            // staticRoutingInfoListView
            // 
            this.staticRoutingInfoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.staticRoutingInfoListView.FullRowSelect = true;
            this.staticRoutingInfoListView.GridLines = true;
            this.staticRoutingInfoListView.Location = new System.Drawing.Point(18, 34);
            this.staticRoutingInfoListView.Name = "staticRoutingInfoListView";
            this.staticRoutingInfoListView.Size = new System.Drawing.Size(283, 168);
            this.staticRoutingInfoListView.TabIndex = 0;
            this.staticRoutingInfoListView.UseCompatibleStateImageBehavior = false;
            this.staticRoutingInfoListView.ItemActivate += new System.EventHandler(this.staticRoutingInfoListView_ItemActivate);
            this.staticRoutingInfoListView.SelectedIndexChanged += new System.EventHandler(this.staticRoutingInfoListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "From";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Destination";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Next Hop";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button14);
            this.groupBox2.Controls.Add(this.getLoraTxPowerBtn);
            this.groupBox2.Controls.Add(this.getDeviceLoRaGatewayIDbtn);
            this.groupBox2.Controls.Add(this.getDeviceLoRaIDbtn);
            this.groupBox2.Controls.Add(this.getDeviceUniqueIDbtn);
            this.groupBox2.Controls.Add(this.getLoraConfigurationsBtn);
            this.groupBox2.Controls.Add(this.button13);
            this.groupBox2.Controls.Add(this.button12);
            this.groupBox2.Controls.Add(this.setDeviceLoRaGatewayIDbtn);
            this.groupBox2.Controls.Add(this.setDeviceLoRaIDbtn);
            this.groupBox2.Controls.Add(this.setDeviceUniqueIDbtn);
            this.groupBox2.Controls.Add(this.setLoraConfigurationsBtn);
            this.groupBox2.Controls.Add(this.devGatewayIDTb);
            this.groupBox2.Controls.Add(this.label36);
            this.groupBox2.Controls.Add(this.devSpreadingFactorCb);
            this.groupBox2.Controls.Add(this.devCodingRateCb);
            this.groupBox2.Controls.Add(this.devBandwidthCb);
            this.groupBox2.Controls.Add(this.devFreqTb);
            this.groupBox2.Controls.Add(this.devTxPowerTb);
            this.groupBox2.Controls.Add(this.devLoraIDTb);
            this.groupBox2.Controls.Add(this.devUniqueIDTb);
            this.groupBox2.Controls.Add(this.label33);
            this.groupBox2.Controls.Add(this.label32);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 354);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LoRa Ayarları";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(359, 200);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 36);
            this.button14.TabIndex = 27;
            this.button14.Text = "Getir";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // getLoraTxPowerBtn
            // 
            this.getLoraTxPowerBtn.Location = new System.Drawing.Point(359, 158);
            this.getLoraTxPowerBtn.Name = "getLoraTxPowerBtn";
            this.getLoraTxPowerBtn.Size = new System.Drawing.Size(75, 36);
            this.getLoraTxPowerBtn.TabIndex = 26;
            this.getLoraTxPowerBtn.Text = "Getir";
            this.getLoraTxPowerBtn.UseVisualStyleBackColor = true;
            // 
            // getDeviceLoRaGatewayIDbtn
            // 
            this.getDeviceLoRaGatewayIDbtn.Location = new System.Drawing.Point(359, 116);
            this.getDeviceLoRaGatewayIDbtn.Name = "getDeviceLoRaGatewayIDbtn";
            this.getDeviceLoRaGatewayIDbtn.Size = new System.Drawing.Size(75, 36);
            this.getDeviceLoRaGatewayIDbtn.TabIndex = 25;
            this.getDeviceLoRaGatewayIDbtn.Text = "Getir";
            this.getDeviceLoRaGatewayIDbtn.UseVisualStyleBackColor = true;
            this.getDeviceLoRaGatewayIDbtn.Click += new System.EventHandler(this.getDeviceLoRaGatewayIDbtn_Click);
            // 
            // getDeviceLoRaIDbtn
            // 
            this.getDeviceLoRaIDbtn.Location = new System.Drawing.Point(359, 72);
            this.getDeviceLoRaIDbtn.Name = "getDeviceLoRaIDbtn";
            this.getDeviceLoRaIDbtn.Size = new System.Drawing.Size(75, 36);
            this.getDeviceLoRaIDbtn.TabIndex = 24;
            this.getDeviceLoRaIDbtn.Text = "Getir";
            this.getDeviceLoRaIDbtn.UseVisualStyleBackColor = true;
            this.getDeviceLoRaIDbtn.Click += new System.EventHandler(this.getDeviceLoRaIDbtn_Click);
            // 
            // getDeviceUniqueIDbtn
            // 
            this.getDeviceUniqueIDbtn.Location = new System.Drawing.Point(359, 27);
            this.getDeviceUniqueIDbtn.Name = "getDeviceUniqueIDbtn";
            this.getDeviceUniqueIDbtn.Size = new System.Drawing.Size(75, 36);
            this.getDeviceUniqueIDbtn.TabIndex = 23;
            this.getDeviceUniqueIDbtn.Text = "Getir";
            this.getDeviceUniqueIDbtn.UseVisualStyleBackColor = true;
            this.getDeviceUniqueIDbtn.Click += new System.EventHandler(this.getDeviceUniqueIDbtn_Click);
            // 
            // getLoraConfigurationsBtn
            // 
            this.getLoraConfigurationsBtn.Location = new System.Drawing.Point(359, 249);
            this.getLoraConfigurationsBtn.Name = "getLoraConfigurationsBtn";
            this.getLoraConfigurationsBtn.Size = new System.Drawing.Size(75, 90);
            this.getLoraConfigurationsBtn.TabIndex = 22;
            this.getLoraConfigurationsBtn.Text = "Getir";
            this.getLoraConfigurationsBtn.UseVisualStyleBackColor = true;
            this.getLoraConfigurationsBtn.Click += new System.EventHandler(this.getLoraConfigurationsBtn_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(278, 200);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 36);
            this.button13.TabIndex = 21;
            this.button13.Text = "Kaydet";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(278, 158);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 36);
            this.button12.TabIndex = 20;
            this.button12.Text = "Kaydet";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // setDeviceLoRaGatewayIDbtn
            // 
            this.setDeviceLoRaGatewayIDbtn.Location = new System.Drawing.Point(278, 116);
            this.setDeviceLoRaGatewayIDbtn.Name = "setDeviceLoRaGatewayIDbtn";
            this.setDeviceLoRaGatewayIDbtn.Size = new System.Drawing.Size(75, 36);
            this.setDeviceLoRaGatewayIDbtn.TabIndex = 19;
            this.setDeviceLoRaGatewayIDbtn.Text = "Kaydet";
            this.setDeviceLoRaGatewayIDbtn.UseVisualStyleBackColor = true;
            this.setDeviceLoRaGatewayIDbtn.Click += new System.EventHandler(this.setDeviceLoRaGatewayIDbtn_Click);
            // 
            // setDeviceLoRaIDbtn
            // 
            this.setDeviceLoRaIDbtn.Location = new System.Drawing.Point(278, 72);
            this.setDeviceLoRaIDbtn.Name = "setDeviceLoRaIDbtn";
            this.setDeviceLoRaIDbtn.Size = new System.Drawing.Size(75, 36);
            this.setDeviceLoRaIDbtn.TabIndex = 18;
            this.setDeviceLoRaIDbtn.Text = "Kaydet";
            this.setDeviceLoRaIDbtn.UseVisualStyleBackColor = true;
            this.setDeviceLoRaIDbtn.Click += new System.EventHandler(this.setDeviceLoRaIDbtn_Click);
            // 
            // setDeviceUniqueIDbtn
            // 
            this.setDeviceUniqueIDbtn.Location = new System.Drawing.Point(278, 27);
            this.setDeviceUniqueIDbtn.Name = "setDeviceUniqueIDbtn";
            this.setDeviceUniqueIDbtn.Size = new System.Drawing.Size(75, 36);
            this.setDeviceUniqueIDbtn.TabIndex = 17;
            this.setDeviceUniqueIDbtn.Text = "Kaydet";
            this.setDeviceUniqueIDbtn.UseVisualStyleBackColor = true;
            this.setDeviceUniqueIDbtn.Click += new System.EventHandler(this.setDeviceUniqueIDbtn_Click);
            // 
            // setLoraConfigurationsBtn
            // 
            this.setLoraConfigurationsBtn.Location = new System.Drawing.Point(278, 249);
            this.setLoraConfigurationsBtn.Name = "setLoraConfigurationsBtn";
            this.setLoraConfigurationsBtn.Size = new System.Drawing.Size(75, 90);
            this.setLoraConfigurationsBtn.TabIndex = 16;
            this.setLoraConfigurationsBtn.Text = "Kaydet";
            this.setLoraConfigurationsBtn.UseVisualStyleBackColor = true;
            this.setLoraConfigurationsBtn.Click += new System.EventHandler(this.setLoraConfigurationsBtn_Click);
            // 
            // devGatewayIDTb
            // 
            this.devGatewayIDTb.Location = new System.Drawing.Point(162, 122);
            this.devGatewayIDTb.Name = "devGatewayIDTb";
            this.devGatewayIDTb.Size = new System.Drawing.Size(100, 22);
            this.devGatewayIDTb.TabIndex = 15;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(57, 126);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(88, 17);
            this.label36.TabIndex = 14;
            this.label36.Text = "Gateway ID :";
            // 
            // devSpreadingFactorCb
            // 
            this.devSpreadingFactorCb.FormattingEnabled = true;
            this.devSpreadingFactorCb.Items.AddRange(new object[] {
            "64",
            "128",
            "256",
            "512",
            "1024",
            "2048",
            "4096"});
            this.devSpreadingFactorCb.Location = new System.Drawing.Point(162, 315);
            this.devSpreadingFactorCb.Name = "devSpreadingFactorCb";
            this.devSpreadingFactorCb.Size = new System.Drawing.Size(100, 24);
            this.devSpreadingFactorCb.TabIndex = 13;
            // 
            // devCodingRateCb
            // 
            this.devCodingRateCb.FormattingEnabled = true;
            this.devCodingRateCb.Items.AddRange(new object[] {
            "4/5",
            "4/6",
            "4/7",
            "4/8"});
            this.devCodingRateCb.Location = new System.Drawing.Point(162, 283);
            this.devCodingRateCb.Name = "devCodingRateCb";
            this.devCodingRateCb.Size = new System.Drawing.Size(100, 24);
            this.devCodingRateCb.TabIndex = 12;
            // 
            // devBandwidthCb
            // 
            this.devBandwidthCb.FormattingEnabled = true;
            this.devBandwidthCb.Items.AddRange(new object[] {
            "125 Khz",
            "250 Khz",
            "500 Khz"});
            this.devBandwidthCb.Location = new System.Drawing.Point(162, 249);
            this.devBandwidthCb.Name = "devBandwidthCb";
            this.devBandwidthCb.Size = new System.Drawing.Size(100, 24);
            this.devBandwidthCb.TabIndex = 11;
            // 
            // devFreqTb
            // 
            this.devFreqTb.Location = new System.Drawing.Point(162, 207);
            this.devFreqTb.Name = "devFreqTb";
            this.devFreqTb.Size = new System.Drawing.Size(100, 22);
            this.devFreqTb.TabIndex = 10;
            // 
            // devTxPowerTb
            // 
            this.devTxPowerTb.Location = new System.Drawing.Point(162, 165);
            this.devTxPowerTb.Name = "devTxPowerTb";
            this.devTxPowerTb.Size = new System.Drawing.Size(100, 22);
            this.devTxPowerTb.TabIndex = 9;
            // 
            // devLoraIDTb
            // 
            this.devLoraIDTb.Location = new System.Drawing.Point(162, 81);
            this.devLoraIDTb.Name = "devLoraIDTb";
            this.devLoraIDTb.Size = new System.Drawing.Size(100, 22);
            this.devLoraIDTb.TabIndex = 8;
            // 
            // devUniqueIDTb
            // 
            this.devUniqueIDTb.Location = new System.Drawing.Point(162, 35);
            this.devUniqueIDTb.Name = "devUniqueIDTb";
            this.devUniqueIDTb.Size = new System.Drawing.Size(100, 22);
            this.devUniqueIDTb.TabIndex = 7;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(22, 318);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(125, 17);
            this.label33.TabIndex = 6;
            this.label33.Text = "Spreading Factor: ";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(45, 285);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(98, 17);
            this.label32.TabIndex = 5;
            this.label32.Text = "Coding Rate : ";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(55, 252);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(85, 17);
            this.label31.TabIndex = 4;
            this.label31.Text = "Bandwidth : ";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(76, 210);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(71, 17);
            this.label28.TabIndex = 3;
            this.label28.Text = "Frekans : ";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(71, 170);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(76, 17);
            this.label27.TabIndex = 2;
            this.label27.Text = "TX Gücü : ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(41, 85);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(106, 17);
            this.label26.TabIndex = 1;
            this.label26.Text = "Cihaz LoRa ID :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(27, 40);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(117, 17);
            this.label25.TabIndex = 0;
            this.label25.Text = "Cihaz Unique ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bluetooth Cihaz Adi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 29;
            this.button1.Text = "Getir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 28;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 424);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 30;
            // 
            // CihazKonfigurasyonPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "CihazKonfigurasyonPage";
            this.Size = new System.Drawing.Size(1124, 549);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button getRoutingInfoBtn;
        private System.Windows.Forms.ListView staticRoutingInfoListView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button getLoraTxPowerBtn;
        private System.Windows.Forms.Button getDeviceLoRaGatewayIDbtn;
        private System.Windows.Forms.Button getDeviceLoRaIDbtn;
        private System.Windows.Forms.Button getDeviceUniqueIDbtn;
        private System.Windows.Forms.Button getLoraConfigurationsBtn;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button setDeviceLoRaGatewayIDbtn;
        private System.Windows.Forms.Button setDeviceLoRaIDbtn;
        private System.Windows.Forms.Button setDeviceUniqueIDbtn;
        private System.Windows.Forms.Button setLoraConfigurationsBtn;
        private System.Windows.Forms.TextBox devGatewayIDTb;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.ComboBox devSpreadingFactorCb;
        private System.Windows.Forms.ComboBox devCodingRateCb;
        private System.Windows.Forms.ComboBox devBandwidthCb;
        private System.Windows.Forms.TextBox devFreqTb;
        private System.Windows.Forms.TextBox devTxPowerTb;
        private System.Windows.Forms.TextBox devLoraIDTb;
        private System.Windows.Forms.TextBox devUniqueIDTb;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button setRoutingInfoBtn;
        private System.Windows.Forms.Button setStaticRoutingInfoBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox st_rtNextHopTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox st_rtDestTb;
        private System.Windows.Forms.TextBox st_rtFromTb;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}
