namespace WindowsFormsApplication1.TabPages
{
    partial class CihazBaglantisiPage
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
            this.label38 = new System.Windows.Forms.Label();
            this.deviceStatLbl = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.commandBt4 = new System.Windows.Forms.Button();
            this.clearRxBoxBtn = new System.Windows.Forms.Button();
            this.commandBt3 = new System.Windows.Forms.Button();
            this.rxDataBox = new System.Windows.Forms.TextBox();
            this.connectDeviceBtn = new System.Windows.Forms.Button();
            this.devicesList = new System.Windows.Forms.ComboBox();
            this.refreshDevicesBtn = new System.Windows.Forms.Button();
            this.commandBt2 = new System.Windows.Forms.Button();
            this.commandBt1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.getDeviceTimeBtn = new System.Windows.Forms.Button();
            this.getDeviceDateBtn = new System.Windows.Forms.Button();
            this.setDeviceDateBtn = new System.Windows.Forms.Button();
            this.setDeviceTimeBtn = new System.Windows.Forms.Button();
            this.devHourCb = new System.Windows.Forms.ComboBox();
            this.devMinCb = new System.Windows.Forms.ComboBox();
            this.devSecCb = new System.Windows.Forms.ComboBox();
            this.devYearCb = new System.Windows.Forms.ComboBox();
            this.devMonthCb = new System.Windows.Forms.ComboBox();
            this.devDayCb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(33, 181);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(104, 17);
            this.label38.TabIndex = 25;
            this.label38.Text = "Cihaz Bilgileri : ";
            // 
            // deviceStatLbl
            // 
            this.deviceStatLbl.AutoSize = true;
            this.deviceStatLbl.Location = new System.Drawing.Point(148, 146);
            this.deviceStatLbl.Name = "deviceStatLbl";
            this.deviceStatLbl.Size = new System.Drawing.Size(114, 17);
            this.deviceStatLbl.TabIndex = 24;
            this.deviceStatLbl.Text = "Cihaz Bağlı Değil";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(33, 146);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(109, 17);
            this.label30.TabIndex = 23;
            this.label30.Text = "Cihaz Durumu : ";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(945, 30);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(147, 49);
            this.button6.TabIndex = 22;
            this.button6.Text = "Log Ekranını Aç";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // commandBt4
            // 
            this.commandBt4.Location = new System.Drawing.Point(752, 467);
            this.commandBt4.Name = "commandBt4";
            this.commandBt4.Size = new System.Drawing.Size(111, 74);
            this.commandBt4.TabIndex = 16;
            this.commandBt4.Text = "C08";
            this.commandBt4.UseVisualStyleBackColor = true;
            this.commandBt4.Click += new System.EventHandler(this.commandBt4_Click);
            // 
            // clearRxBoxBtn
            // 
            this.clearRxBoxBtn.Location = new System.Drawing.Point(945, 243);
            this.clearRxBoxBtn.Name = "clearRxBoxBtn";
            this.clearRxBoxBtn.Size = new System.Drawing.Size(87, 40);
            this.clearRxBoxBtn.TabIndex = 21;
            this.clearRxBoxBtn.Text = "Clear";
            this.clearRxBoxBtn.UseVisualStyleBackColor = true;
            this.clearRxBoxBtn.Click += new System.EventHandler(this.clearRxBoxBtn_Click);
            // 
            // commandBt3
            // 
            this.commandBt3.Location = new System.Drawing.Point(629, 467);
            this.commandBt3.Name = "commandBt3";
            this.commandBt3.Size = new System.Drawing.Size(106, 74);
            this.commandBt3.TabIndex = 15;
            this.commandBt3.Text = "C07";
            this.commandBt3.UseVisualStyleBackColor = true;
            this.commandBt3.Click += new System.EventHandler(this.commandBt3_Click);
            // 
            // rxDataBox
            // 
            this.rxDataBox.Location = new System.Drawing.Point(578, 48);
            this.rxDataBox.Multiline = true;
            this.rxDataBox.Name = "rxDataBox";
            this.rxDataBox.Size = new System.Drawing.Size(322, 377);
            this.rxDataBox.TabIndex = 20;
            // 
            // connectDeviceBtn
            // 
            this.connectDeviceBtn.Location = new System.Drawing.Point(341, 48);
            this.connectDeviceBtn.Name = "connectDeviceBtn";
            this.connectDeviceBtn.Size = new System.Drawing.Size(103, 36);
            this.connectDeviceBtn.TabIndex = 18;
            this.connectDeviceBtn.Text = "Connect";
            this.connectDeviceBtn.UseVisualStyleBackColor = true;
            this.connectDeviceBtn.Click += new System.EventHandler(this.connectDeviceBtn_Click);
            // 
            // devicesList
            // 
            this.devicesList.FormattingEnabled = true;
            this.devicesList.Location = new System.Drawing.Point(27, 55);
            this.devicesList.Name = "devicesList";
            this.devicesList.Size = new System.Drawing.Size(181, 24);
            this.devicesList.TabIndex = 17;
            // 
            // refreshDevicesBtn
            // 
            this.refreshDevicesBtn.Location = new System.Drawing.Point(234, 48);
            this.refreshDevicesBtn.Name = "refreshDevicesBtn";
            this.refreshDevicesBtn.Size = new System.Drawing.Size(101, 36);
            this.refreshDevicesBtn.TabIndex = 19;
            this.refreshDevicesBtn.Text = "Refresh";
            this.refreshDevicesBtn.UseVisualStyleBackColor = true;
            this.refreshDevicesBtn.Click += new System.EventHandler(this.refreshDevicesBtn_Click);
            // 
            // commandBt2
            // 
            this.commandBt2.Location = new System.Drawing.Point(513, 467);
            this.commandBt2.Name = "commandBt2";
            this.commandBt2.Size = new System.Drawing.Size(102, 74);
            this.commandBt2.TabIndex = 14;
            this.commandBt2.Text = "C06";
            this.commandBt2.UseVisualStyleBackColor = true;
            this.commandBt2.Click += new System.EventHandler(this.commandBt2_Click);
            // 
            // commandBt1
            // 
            this.commandBt1.Location = new System.Drawing.Point(386, 467);
            this.commandBt1.Name = "commandBt1";
            this.commandBt1.Size = new System.Drawing.Size(110, 74);
            this.commandBt1.TabIndex = 13;
            this.commandBt1.Text = "C05";
            this.commandBt1.UseVisualStyleBackColor = true;
            this.commandBt1.Click += new System.EventHandler(this.commandBt1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Cihaz Saati : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Cihaz Tarihi : ";
            // 
            // getDeviceTimeBtn
            // 
            this.getDeviceTimeBtn.Location = new System.Drawing.Point(422, 237);
            this.getDeviceTimeBtn.Name = "getDeviceTimeBtn";
            this.getDeviceTimeBtn.Size = new System.Drawing.Size(75, 32);
            this.getDeviceTimeBtn.TabIndex = 30;
            this.getDeviceTimeBtn.Text = "Getir";
            this.getDeviceTimeBtn.UseVisualStyleBackColor = true;
            this.getDeviceTimeBtn.Click += new System.EventHandler(this.getDeviceTimeBtn_Click);
            // 
            // getDeviceDateBtn
            // 
            this.getDeviceDateBtn.Location = new System.Drawing.Point(422, 283);
            this.getDeviceDateBtn.Name = "getDeviceDateBtn";
            this.getDeviceDateBtn.Size = new System.Drawing.Size(75, 30);
            this.getDeviceDateBtn.TabIndex = 31;
            this.getDeviceDateBtn.Text = "Getir";
            this.getDeviceDateBtn.UseVisualStyleBackColor = true;
            this.getDeviceDateBtn.Click += new System.EventHandler(this.getDeviceDateBtn_Click);
            // 
            // setDeviceDateBtn
            // 
            this.setDeviceDateBtn.Location = new System.Drawing.Point(341, 283);
            this.setDeviceDateBtn.Name = "setDeviceDateBtn";
            this.setDeviceDateBtn.Size = new System.Drawing.Size(75, 30);
            this.setDeviceDateBtn.TabIndex = 33;
            this.setDeviceDateBtn.Text = "Kaydet";
            this.setDeviceDateBtn.UseVisualStyleBackColor = true;
            this.setDeviceDateBtn.Click += new System.EventHandler(this.setDeviceDateBtn_Click);
            // 
            // setDeviceTimeBtn
            // 
            this.setDeviceTimeBtn.Location = new System.Drawing.Point(340, 237);
            this.setDeviceTimeBtn.Name = "setDeviceTimeBtn";
            this.setDeviceTimeBtn.Size = new System.Drawing.Size(75, 32);
            this.setDeviceTimeBtn.TabIndex = 32;
            this.setDeviceTimeBtn.Text = "Kaydet";
            this.setDeviceTimeBtn.UseVisualStyleBackColor = true;
            this.setDeviceTimeBtn.Click += new System.EventHandler(this.setDeviceTimeBtn_Click);
            // 
            // devHourCb
            // 
            this.devHourCb.FormattingEnabled = true;
            this.devHourCb.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.devHourCb.Location = new System.Drawing.Point(141, 242);
            this.devHourCb.Name = "devHourCb";
            this.devHourCb.Size = new System.Drawing.Size(45, 24);
            this.devHourCb.TabIndex = 34;
            // 
            // devMinCb
            // 
            this.devMinCb.FormattingEnabled = true;
            this.devMinCb.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.devMinCb.Location = new System.Drawing.Point(192, 242);
            this.devMinCb.Name = "devMinCb";
            this.devMinCb.Size = new System.Drawing.Size(45, 24);
            this.devMinCb.TabIndex = 35;
            // 
            // devSecCb
            // 
            this.devSecCb.FormattingEnabled = true;
            this.devSecCb.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.devSecCb.Location = new System.Drawing.Point(243, 242);
            this.devSecCb.Name = "devSecCb";
            this.devSecCb.Size = new System.Drawing.Size(45, 24);
            this.devSecCb.TabIndex = 36;
            // 
            // devYearCb
            // 
            this.devYearCb.FormattingEnabled = true;
            this.devYearCb.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033"});
            this.devYearCb.Location = new System.Drawing.Point(243, 287);
            this.devYearCb.Name = "devYearCb";
            this.devYearCb.Size = new System.Drawing.Size(80, 24);
            this.devYearCb.TabIndex = 39;
            // 
            // devMonthCb
            // 
            this.devMonthCb.FormattingEnabled = true;
            this.devMonthCb.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.devMonthCb.Location = new System.Drawing.Point(192, 287);
            this.devMonthCb.Name = "devMonthCb";
            this.devMonthCb.Size = new System.Drawing.Size(45, 24);
            this.devMonthCb.TabIndex = 38;
            // 
            // devDayCb
            // 
            this.devDayCb.FormattingEnabled = true;
            this.devDayCb.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.devDayCb.Location = new System.Drawing.Point(141, 287);
            this.devDayCb.Name = "devDayCb";
            this.devDayCb.Size = new System.Drawing.Size(45, 24);
            this.devDayCb.TabIndex = 37;
            // 
            // CihazBaglantisiPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.devYearCb);
            this.Controls.Add(this.devMonthCb);
            this.Controls.Add(this.devDayCb);
            this.Controls.Add(this.devSecCb);
            this.Controls.Add(this.devMinCb);
            this.Controls.Add(this.devHourCb);
            this.Controls.Add(this.setDeviceDateBtn);
            this.Controls.Add(this.setDeviceTimeBtn);
            this.Controls.Add(this.getDeviceDateBtn);
            this.Controls.Add(this.getDeviceTimeBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.deviceStatLbl);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.commandBt4);
            this.Controls.Add(this.clearRxBoxBtn);
            this.Controls.Add(this.commandBt3);
            this.Controls.Add(this.rxDataBox);
            this.Controls.Add(this.connectDeviceBtn);
            this.Controls.Add(this.devicesList);
            this.Controls.Add(this.refreshDevicesBtn);
            this.Controls.Add(this.commandBt2);
            this.Controls.Add(this.commandBt1);
            this.Name = "CihazBaglantisiPage";
            this.Size = new System.Drawing.Size(1103, 558);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label deviceStatLbl;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button commandBt4;
        private System.Windows.Forms.Button clearRxBoxBtn;
        private System.Windows.Forms.Button commandBt3;
        private System.Windows.Forms.TextBox rxDataBox;
        private System.Windows.Forms.Button connectDeviceBtn;
        private System.Windows.Forms.ComboBox devicesList;
        private System.Windows.Forms.Button refreshDevicesBtn;
        private System.Windows.Forms.Button commandBt2;
        private System.Windows.Forms.Button commandBt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button getDeviceTimeBtn;
        private System.Windows.Forms.Button getDeviceDateBtn;
        private System.Windows.Forms.Button setDeviceDateBtn;
        private System.Windows.Forms.Button setDeviceTimeBtn;
        private System.Windows.Forms.ComboBox devHourCb;
        private System.Windows.Forms.ComboBox devMinCb;
        private System.Windows.Forms.ComboBox devSecCb;
        private System.Windows.Forms.ComboBox devYearCb;
        private System.Windows.Forms.ComboBox devMonthCb;
        private System.Windows.Forms.ComboBox devDayCb;
    }
}
