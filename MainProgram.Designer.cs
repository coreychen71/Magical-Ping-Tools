namespace Magical_PingTools
{
    partial class MainProgram
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainProgram));
            this.gbLocalInfo = new System.Windows.Forms.GroupBox();
            this.lblWifiMacShow = new System.Windows.Forms.Label();
            this.lblWifiMAC = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblWifiAddressShow = new System.Windows.Forms.Label();
            this.lblWifiAddress = new System.Windows.Forms.Label();
            this.lblLanMacShow = new System.Windows.Forms.Label();
            this.lblLanMac = new System.Windows.Forms.Label();
            this.lblHostNameShow = new System.Windows.Forms.Label();
            this.lblHostName = new System.Windows.Forms.Label();
            this.lblLanAddressShow = new System.Windows.Forms.Label();
            this.lblLanAddress = new System.Windows.Forms.Label();
            this.btnPing = new System.Windows.Forms.Button();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.rtxtResult = new System.Windows.Forms.RichTextBox();
            this.btnIpconfigAll = new System.Windows.Forms.Button();
            this.btnArp = new System.Windows.Forms.Button();
            this.btnNetstat = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.gbConnectionStatus = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDrSpeed = new System.Windows.Forms.Button();
            this.btnOpenIE8080 = new System.Windows.Forms.Button();
            this.btnOpenIE = new System.Windows.Forms.Button();
            this.btnNbtstatA = new System.Windows.Forms.Button();
            this.btnTracert = new System.Windows.Forms.Button();
            this.btnPathPing = new System.Windows.Forms.Button();
            this.btnNslookup = new System.Windows.Forms.Button();
            this.btnPingT = new System.Windows.Forms.Button();
            this.rdoGateway = new System.Windows.Forms.RadioButton();
            this.rdoGoogle = new System.Windows.Forms.RadioButton();
            this.rdoYahoo = new System.Windows.Forms.RadioButton();
            this.rdoGoogleDNS = new System.Windows.Forms.RadioButton();
            this.rdoHinetDNS2 = new System.Windows.Forms.RadioButton();
            this.rdoHinetDNS1 = new System.Windows.Forms.RadioButton();
            this.gbChangeInterfaceAddress = new System.Windows.Forms.GroupBox();
            this.btnManual = new System.Windows.Forms.Button();
            this.btn192 = new System.Windows.Forms.Button();
            this.cboSelectCard = new System.Windows.Forms.ComboBox();
            this.btnDHCP = new System.Windows.Forms.Button();
            this.btn200 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.gbLocalInfo.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.gbConnectionStatus.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbChangeInterfaceAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLocalInfo
            // 
            this.gbLocalInfo.Controls.Add(this.lblWifiMacShow);
            this.gbLocalInfo.Controls.Add(this.lblWifiMAC);
            this.gbLocalInfo.Controls.Add(this.btnRefresh);
            this.gbLocalInfo.Controls.Add(this.lblWifiAddressShow);
            this.gbLocalInfo.Controls.Add(this.lblWifiAddress);
            this.gbLocalInfo.Controls.Add(this.lblLanMacShow);
            this.gbLocalInfo.Controls.Add(this.lblLanMac);
            this.gbLocalInfo.Controls.Add(this.lblHostNameShow);
            this.gbLocalInfo.Controls.Add(this.lblHostName);
            this.gbLocalInfo.Controls.Add(this.lblLanAddressShow);
            this.gbLocalInfo.Controls.Add(this.lblLanAddress);
            this.gbLocalInfo.Font = new System.Drawing.Font("微軟正黑體", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbLocalInfo.Location = new System.Drawing.Point(12, 12);
            this.gbLocalInfo.Name = "gbLocalInfo";
            this.gbLocalInfo.Size = new System.Drawing.Size(600, 150);
            this.gbLocalInfo.TabIndex = 0;
            this.gbLocalInfo.TabStop = false;
            this.gbLocalInfo.Text = "Local Information";
            // 
            // lblWifiMacShow
            // 
            this.lblWifiMacShow.AutoSize = true;
            this.lblWifiMacShow.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWifiMacShow.Location = new System.Drawing.Point(395, 109);
            this.lblWifiMacShow.Name = "lblWifiMacShow";
            this.lblWifiMacShow.Size = new System.Drawing.Size(46, 19);
            this.lblWifiMacShow.TabIndex = 9;
            this.lblWifiMacShow.Text = "show";
            // 
            // lblWifiMAC
            // 
            this.lblWifiMAC.AutoSize = true;
            this.lblWifiMAC.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWifiMAC.Location = new System.Drawing.Point(283, 109);
            this.lblWifiMAC.Name = "lblWifiMAC";
            this.lblWifiMAC.Size = new System.Drawing.Size(121, 19);
            this.lblWifiMAC.TabIndex = 8;
            this.lblWifiMAC.Text = "Wireless MAC：";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(519, 32);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 30);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblWifiAddressShow
            // 
            this.lblWifiAddressShow.AutoSize = true;
            this.lblWifiAddressShow.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWifiAddressShow.Location = new System.Drawing.Point(395, 71);
            this.lblWifiAddressShow.Name = "lblWifiAddressShow";
            this.lblWifiAddressShow.Size = new System.Drawing.Size(46, 19);
            this.lblWifiAddressShow.TabIndex = 7;
            this.lblWifiAddressShow.Text = "show";
            // 
            // lblWifiAddress
            // 
            this.lblWifiAddress.AutoSize = true;
            this.lblWifiAddress.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWifiAddress.Location = new System.Drawing.Point(304, 71);
            this.lblWifiAddress.Name = "lblWifiAddress";
            this.lblWifiAddress.Size = new System.Drawing.Size(100, 19);
            this.lblWifiAddress.TabIndex = 6;
            this.lblWifiAddress.Text = "Wireless IP：";
            // 
            // lblLanMacShow
            // 
            this.lblLanMacShow.AutoSize = true;
            this.lblLanMacShow.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLanMacShow.Location = new System.Drawing.Point(97, 109);
            this.lblLanMacShow.Name = "lblLanMacShow";
            this.lblLanMacShow.Size = new System.Drawing.Size(46, 19);
            this.lblLanMacShow.TabIndex = 5;
            this.lblLanMacShow.Text = "show";
            // 
            // lblLanMac
            // 
            this.lblLanMac.AutoSize = true;
            this.lblLanMac.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLanMac.Location = new System.Drawing.Point(16, 109);
            this.lblLanMac.Name = "lblLanMac";
            this.lblLanMac.Size = new System.Drawing.Size(92, 19);
            this.lblLanMac.TabIndex = 4;
            this.lblLanMac.Text = "LAN MAC：";
            // 
            // lblHostNameShow
            // 
            this.lblHostNameShow.AutoSize = true;
            this.lblHostNameShow.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHostNameShow.Location = new System.Drawing.Point(97, 33);
            this.lblHostNameShow.Name = "lblHostNameShow";
            this.lblHostNameShow.Size = new System.Drawing.Size(46, 19);
            this.lblHostNameShow.TabIndex = 3;
            this.lblHostNameShow.Text = "show";
            // 
            // lblHostName
            // 
            this.lblHostName.AutoSize = true;
            this.lblHostName.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHostName.Location = new System.Drawing.Point(6, 33);
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Size = new System.Drawing.Size(102, 19);
            this.lblHostName.TabIndex = 2;
            this.lblHostName.Text = "Host Name：";
            // 
            // lblLanAddressShow
            // 
            this.lblLanAddressShow.AutoSize = true;
            this.lblLanAddressShow.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLanAddressShow.Location = new System.Drawing.Point(97, 71);
            this.lblLanAddressShow.Name = "lblLanAddressShow";
            this.lblLanAddressShow.Size = new System.Drawing.Size(46, 19);
            this.lblLanAddressShow.TabIndex = 1;
            this.lblLanAddressShow.Text = "show";
            // 
            // lblLanAddress
            // 
            this.lblLanAddress.AutoSize = true;
            this.lblLanAddress.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLanAddress.Location = new System.Drawing.Point(37, 71);
            this.lblLanAddress.Name = "lblLanAddress";
            this.lblLanAddress.Size = new System.Drawing.Size(71, 19);
            this.lblLanAddress.TabIndex = 0;
            this.lblLanAddress.Text = "LAN IP：";
            // 
            // btnPing
            // 
            this.btnPing.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPing.Location = new System.Drawing.Point(18, 117);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(100, 30);
            this.btnPing.TabIndex = 2;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.rtxtResult);
            this.gbResult.Font = new System.Drawing.Font("微軟正黑體", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbResult.Location = new System.Drawing.Point(12, 189);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(600, 360);
            this.gbResult.TabIndex = 3;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Result";
            // 
            // rtxtResult
            // 
            this.rtxtResult.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtxtResult.Location = new System.Drawing.Point(10, 24);
            this.rtxtResult.Name = "rtxtResult";
            this.rtxtResult.Size = new System.Drawing.Size(580, 330);
            this.rtxtResult.TabIndex = 0;
            this.rtxtResult.Text = "";
            // 
            // btnIpconfigAll
            // 
            this.btnIpconfigAll.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIpconfigAll.Location = new System.Drawing.Point(13, 32);
            this.btnIpconfigAll.Name = "btnIpconfigAll";
            this.btnIpconfigAll.Size = new System.Drawing.Size(100, 30);
            this.btnIpconfigAll.TabIndex = 4;
            this.btnIpconfigAll.Text = "ipconfig /all";
            this.btnIpconfigAll.UseVisualStyleBackColor = true;
            this.btnIpconfigAll.Click += new System.EventHandler(this.btnIpconfigAll_Click);
            // 
            // btnArp
            // 
            this.btnArp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArp.Location = new System.Drawing.Point(119, 32);
            this.btnArp.Name = "btnArp";
            this.btnArp.Size = new System.Drawing.Size(100, 30);
            this.btnArp.TabIndex = 5;
            this.btnArp.Text = "arp -a";
            this.btnArp.UseVisualStyleBackColor = true;
            this.btnArp.Click += new System.EventHandler(this.btnArp_Click);
            // 
            // btnNetstat
            // 
            this.btnNetstat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNetstat.Location = new System.Drawing.Point(225, 32);
            this.btnNetstat.Name = "btnNetstat";
            this.btnNetstat.Size = new System.Drawing.Size(100, 30);
            this.btnNetstat.TabIndex = 6;
            this.btnNetstat.Text = "netstat -no";
            this.btnNetstat.UseVisualStyleBackColor = true;
            this.btnNetstat.Click += new System.EventHandler(this.btnNetstat_Click);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(18, 86);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(310, 25);
            this.txtInput.TabIndex = 7;
            // 
            // gbConnectionStatus
            // 
            this.gbConnectionStatus.Controls.Add(this.btnNetstat);
            this.gbConnectionStatus.Controls.Add(this.btnArp);
            this.gbConnectionStatus.Controls.Add(this.btnIpconfigAll);
            this.gbConnectionStatus.Font = new System.Drawing.Font("微軟正黑體", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbConnectionStatus.Location = new System.Drawing.Point(618, 189);
            this.gbConnectionStatus.Name = "gbConnectionStatus";
            this.gbConnectionStatus.Size = new System.Drawing.Size(339, 74);
            this.gbConnectionStatus.TabIndex = 8;
            this.gbConnectionStatus.TabStop = false;
            this.gbConnectionStatus.Text = "Get Connection Status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDrSpeed);
            this.groupBox1.Controls.Add(this.btnOpenIE8080);
            this.groupBox1.Controls.Add(this.btnOpenIE);
            this.groupBox1.Controls.Add(this.btnNbtstatA);
            this.groupBox1.Controls.Add(this.btnTracert);
            this.groupBox1.Controls.Add(this.btnPathPing);
            this.groupBox1.Controls.Add(this.btnNslookup);
            this.groupBox1.Controls.Add(this.btnPingT);
            this.groupBox1.Controls.Add(this.rdoGateway);
            this.groupBox1.Controls.Add(this.rdoGoogle);
            this.groupBox1.Controls.Add(this.rdoYahoo);
            this.groupBox1.Controls.Add(this.rdoGoogleDNS);
            this.groupBox1.Controls.Add(this.rdoHinetDNS2);
            this.groupBox1.Controls.Add(this.rdoHinetDNS1);
            this.groupBox1.Controls.Add(this.btnPing);
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(618, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 262);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Command";
            // 
            // btnDrSpeed
            // 
            this.btnDrSpeed.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrSpeed.Location = new System.Drawing.Point(230, 189);
            this.btnDrSpeed.Name = "btnDrSpeed";
            this.btnDrSpeed.Size = new System.Drawing.Size(100, 30);
            this.btnDrSpeed.TabIndex = 22;
            this.btnDrSpeed.Text = "Dr.Speed";
            this.btnDrSpeed.UseVisualStyleBackColor = true;
            this.btnDrSpeed.Click += new System.EventHandler(this.btnDrSpeed_Click);
            // 
            // btnOpenIE8080
            // 
            this.btnOpenIE8080.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenIE8080.Location = new System.Drawing.Point(124, 189);
            this.btnOpenIE8080.Name = "btnOpenIE8080";
            this.btnOpenIE8080.Size = new System.Drawing.Size(100, 30);
            this.btnOpenIE8080.TabIndex = 21;
            this.btnOpenIE8080.Text = "IE：8080";
            this.btnOpenIE8080.UseVisualStyleBackColor = true;
            this.btnOpenIE8080.Click += new System.EventHandler(this.btnOpenIE8080_Click);
            // 
            // btnOpenIE
            // 
            this.btnOpenIE.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenIE.Location = new System.Drawing.Point(18, 189);
            this.btnOpenIE.Name = "btnOpenIE";
            this.btnOpenIE.Size = new System.Drawing.Size(100, 30);
            this.btnOpenIE.TabIndex = 20;
            this.btnOpenIE.Text = "IE";
            this.btnOpenIE.UseVisualStyleBackColor = true;
            this.btnOpenIE.Click += new System.EventHandler(this.btnOpenIE_Click);
            // 
            // btnNbtstatA
            // 
            this.btnNbtstatA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNbtstatA.Location = new System.Drawing.Point(230, 153);
            this.btnNbtstatA.Name = "btnNbtstatA";
            this.btnNbtstatA.Size = new System.Drawing.Size(100, 30);
            this.btnNbtstatA.TabIndex = 19;
            this.btnNbtstatA.Text = "Nbtstat -A";
            this.btnNbtstatA.UseVisualStyleBackColor = true;
            this.btnNbtstatA.Click += new System.EventHandler(this.btnNbtstatA_Click);
            // 
            // btnTracert
            // 
            this.btnTracert.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTracert.Location = new System.Drawing.Point(18, 153);
            this.btnTracert.Name = "btnTracert";
            this.btnTracert.Size = new System.Drawing.Size(100, 30);
            this.btnTracert.TabIndex = 18;
            this.btnTracert.Text = "Tracert";
            this.btnTracert.UseVisualStyleBackColor = true;
            this.btnTracert.Click += new System.EventHandler(this.btnTracert_Click);
            // 
            // btnPathPing
            // 
            this.btnPathPing.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPathPing.Location = new System.Drawing.Point(230, 117);
            this.btnPathPing.Name = "btnPathPing";
            this.btnPathPing.Size = new System.Drawing.Size(100, 30);
            this.btnPathPing.TabIndex = 17;
            this.btnPathPing.Text = "PathPing";
            this.btnPathPing.UseVisualStyleBackColor = true;
            this.btnPathPing.Click += new System.EventHandler(this.btnPathPing_Click);
            // 
            // btnNslookup
            // 
            this.btnNslookup.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNslookup.Location = new System.Drawing.Point(124, 153);
            this.btnNslookup.Name = "btnNslookup";
            this.btnNslookup.Size = new System.Drawing.Size(100, 30);
            this.btnNslookup.TabIndex = 16;
            this.btnNslookup.Text = "Nslookup";
            this.btnNslookup.UseVisualStyleBackColor = true;
            this.btnNslookup.Click += new System.EventHandler(this.btnNslookup_Click);
            // 
            // btnPingT
            // 
            this.btnPingT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPingT.Location = new System.Drawing.Point(124, 117);
            this.btnPingT.Name = "btnPingT";
            this.btnPingT.Size = new System.Drawing.Size(100, 30);
            this.btnPingT.TabIndex = 15;
            this.btnPingT.Text = "Ping -t";
            this.btnPingT.UseVisualStyleBackColor = true;
            this.btnPingT.Click += new System.EventHandler(this.btnPingT_Click);
            // 
            // rdoGateway
            // 
            this.rdoGateway.AutoSize = true;
            this.rdoGateway.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdoGateway.Location = new System.Drawing.Point(224, 59);
            this.rdoGateway.Name = "rdoGateway";
            this.rdoGateway.Size = new System.Drawing.Size(79, 21);
            this.rdoGateway.TabIndex = 14;
            this.rdoGateway.TabStop = true;
            this.rdoGateway.Text = "Gateway";
            this.rdoGateway.UseVisualStyleBackColor = true;
            this.rdoGateway.CheckedChanged += new System.EventHandler(this.rdoGateway_CheckedChanged);
            // 
            // rdoGoogle
            // 
            this.rdoGoogle.AutoSize = true;
            this.rdoGoogle.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdoGoogle.Location = new System.Drawing.Point(18, 59);
            this.rdoGoogle.Name = "rdoGoogle";
            this.rdoGoogle.Size = new System.Drawing.Size(70, 21);
            this.rdoGoogle.TabIndex = 13;
            this.rdoGoogle.TabStop = true;
            this.rdoGoogle.Text = "Google";
            this.rdoGoogle.UseVisualStyleBackColor = true;
            this.rdoGoogle.CheckedChanged += new System.EventHandler(this.rdoGoogle_CheckedChanged);
            // 
            // rdoYahoo
            // 
            this.rdoYahoo.AutoSize = true;
            this.rdoYahoo.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdoYahoo.Location = new System.Drawing.Point(121, 59);
            this.rdoYahoo.Name = "rdoYahoo";
            this.rdoYahoo.Size = new System.Drawing.Size(65, 21);
            this.rdoYahoo.TabIndex = 12;
            this.rdoYahoo.TabStop = true;
            this.rdoYahoo.Text = "Yahoo";
            this.rdoYahoo.UseVisualStyleBackColor = true;
            this.rdoYahoo.CheckedChanged += new System.EventHandler(this.rdoYahoo_CheckedChanged);
            // 
            // rdoGoogleDNS
            // 
            this.rdoGoogleDNS.AutoSize = true;
            this.rdoGoogleDNS.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdoGoogleDNS.Location = new System.Drawing.Point(224, 32);
            this.rdoGoogleDNS.Name = "rdoGoogleDNS";
            this.rdoGoogleDNS.Size = new System.Drawing.Size(97, 21);
            this.rdoGoogleDNS.TabIndex = 11;
            this.rdoGoogleDNS.TabStop = true;
            this.rdoGoogleDNS.Text = "GoogleDNS";
            this.rdoGoogleDNS.UseVisualStyleBackColor = true;
            this.rdoGoogleDNS.CheckedChanged += new System.EventHandler(this.rdoGoogleDNS_CheckedChanged);
            // 
            // rdoHinetDNS2
            // 
            this.rdoHinetDNS2.AutoSize = true;
            this.rdoHinetDNS2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdoHinetDNS2.Location = new System.Drawing.Point(121, 32);
            this.rdoHinetDNS2.Name = "rdoHinetDNS2";
            this.rdoHinetDNS2.Size = new System.Drawing.Size(97, 21);
            this.rdoHinetDNS2.TabIndex = 10;
            this.rdoHinetDNS2.TabStop = true;
            this.rdoHinetDNS2.Text = "Hinet DNS2";
            this.rdoHinetDNS2.UseVisualStyleBackColor = true;
            this.rdoHinetDNS2.CheckedChanged += new System.EventHandler(this.rdoHinetDNS2_CheckedChanged);
            // 
            // rdoHinetDNS1
            // 
            this.rdoHinetDNS1.AutoSize = true;
            this.rdoHinetDNS1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdoHinetDNS1.Location = new System.Drawing.Point(18, 32);
            this.rdoHinetDNS1.Name = "rdoHinetDNS1";
            this.rdoHinetDNS1.Size = new System.Drawing.Size(97, 21);
            this.rdoHinetDNS1.TabIndex = 9;
            this.rdoHinetDNS1.TabStop = true;
            this.rdoHinetDNS1.Text = "Hinet DNS1";
            this.rdoHinetDNS1.UseVisualStyleBackColor = true;
            this.rdoHinetDNS1.CheckedChanged += new System.EventHandler(this.rdoHinetDNS1_CheckedChanged);
            // 
            // gbChangeInterfaceAddress
            // 
            this.gbChangeInterfaceAddress.Controls.Add(this.btnManual);
            this.gbChangeInterfaceAddress.Controls.Add(this.btn192);
            this.gbChangeInterfaceAddress.Controls.Add(this.cboSelectCard);
            this.gbChangeInterfaceAddress.Controls.Add(this.btnDHCP);
            this.gbChangeInterfaceAddress.Controls.Add(this.btn200);
            this.gbChangeInterfaceAddress.Controls.Add(this.btn100);
            this.gbChangeInterfaceAddress.Controls.Add(this.btn10);
            this.gbChangeInterfaceAddress.Font = new System.Drawing.Font("微軟正黑體", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbChangeInterfaceAddress.Location = new System.Drawing.Point(618, 12);
            this.gbChangeInterfaceAddress.Name = "gbChangeInterfaceAddress";
            this.gbChangeInterfaceAddress.Size = new System.Drawing.Size(339, 150);
            this.gbChangeInterfaceAddress.TabIndex = 10;
            this.gbChangeInterfaceAddress.TabStop = false;
            this.gbChangeInterfaceAddress.Text = "Change IP Address";
            // 
            // btnManual
            // 
            this.btnManual.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManual.Location = new System.Drawing.Point(227, 104);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(100, 30);
            this.btnManual.TabIndex = 11;
            this.btnManual.Text = "Manual";
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // btn192
            // 
            this.btn192.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn192.Location = new System.Drawing.Point(15, 104);
            this.btn192.Name = "btn192";
            this.btn192.Size = new System.Drawing.Size(100, 30);
            this.btn192.TabIndex = 10;
            this.btn192.Text = "192.0.0.0/8";
            this.btn192.UseVisualStyleBackColor = true;
            this.btn192.Click += new System.EventHandler(this.btn192_Click);
            // 
            // cboSelectCard
            // 
            this.cboSelectCard.Font = new System.Drawing.Font("微軟正黑體", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboSelectCard.FormattingEnabled = true;
            this.cboSelectCard.Location = new System.Drawing.Point(13, 35);
            this.cboSelectCard.Name = "cboSelectCard";
            this.cboSelectCard.Size = new System.Drawing.Size(310, 24);
            this.cboSelectCard.TabIndex = 9;
            // 
            // btnDHCP
            // 
            this.btnDHCP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDHCP.Location = new System.Drawing.Point(121, 104);
            this.btnDHCP.Name = "btnDHCP";
            this.btnDHCP.Size = new System.Drawing.Size(100, 30);
            this.btnDHCP.TabIndex = 8;
            this.btnDHCP.Text = "DHCP";
            this.btnDHCP.UseVisualStyleBackColor = true;
            this.btnDHCP.Click += new System.EventHandler(this.btnDHCP_Click);
            // 
            // btn200
            // 
            this.btn200.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn200.Location = new System.Drawing.Point(225, 68);
            this.btn200.Name = "btn200";
            this.btn200.Size = new System.Drawing.Size(100, 30);
            this.btn200.TabIndex = 7;
            this.btn200.Text = "200.0.0.0/8";
            this.btn200.UseVisualStyleBackColor = true;
            this.btn200.Click += new System.EventHandler(this.btn200_Click);
            // 
            // btn100
            // 
            this.btn100.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn100.Location = new System.Drawing.Point(119, 68);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(100, 30);
            this.btn100.TabIndex = 6;
            this.btn100.Text = "100.0.0.0/8";
            this.btn100.UseVisualStyleBackColor = true;
            this.btn100.Click += new System.EventHandler(this.btn100_Click);
            // 
            // btn10
            // 
            this.btn10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10.Location = new System.Drawing.Point(13, 68);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(100, 30);
            this.btn10.TabIndex = 5;
            this.btn10.Text = "10.0.0.0/8";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // MainProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(964, 561);
            this.Controls.Add(this.gbChangeInterfaceAddress);
            this.Controls.Add(this.gbConnectionStatus);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gbLocalInfo);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magical PingTools v1.0";
            this.gbLocalInfo.ResumeLayout(false);
            this.gbLocalInfo.PerformLayout();
            this.gbResult.ResumeLayout(false);
            this.gbConnectionStatus.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbChangeInterfaceAddress.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLocalInfo;
        private System.Windows.Forms.Label lblLanAddressShow;
        private System.Windows.Forms.Label lblLanAddress;
        private System.Windows.Forms.Label lblHostNameShow;
        private System.Windows.Forms.Label lblHostName;
        private System.Windows.Forms.Label lblLanMacShow;
        private System.Windows.Forms.Label lblLanMac;
        private System.Windows.Forms.Label lblWifiMacShow;
        private System.Windows.Forms.Label lblWifiMAC;
        private System.Windows.Forms.Label lblWifiAddressShow;
        private System.Windows.Forms.Label lblWifiAddress;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.RichTextBox rtxtResult;
        private System.Windows.Forms.Button btnIpconfigAll;
        private System.Windows.Forms.Button btnArp;
        private System.Windows.Forms.Button btnNetstat;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.GroupBox gbConnectionStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoGateway;
        private System.Windows.Forms.RadioButton rdoGoogle;
        private System.Windows.Forms.RadioButton rdoYahoo;
        private System.Windows.Forms.RadioButton rdoGoogleDNS;
        private System.Windows.Forms.RadioButton rdoHinetDNS2;
        private System.Windows.Forms.RadioButton rdoHinetDNS1;
        private System.Windows.Forms.GroupBox gbChangeInterfaceAddress;
        private System.Windows.Forms.Button btnDHCP;
        private System.Windows.Forms.Button btn200;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btnNslookup;
        private System.Windows.Forms.Button btnPingT;
        private System.Windows.Forms.Button btnNbtstatA;
        private System.Windows.Forms.Button btnTracert;
        private System.Windows.Forms.Button btnPathPing;
        private System.Windows.Forms.Button btnOpenIE;
        private System.Windows.Forms.Button btnOpenIE8080;
        private System.Windows.Forms.Button btnDrSpeed;
        private System.Windows.Forms.ComboBox cboSelectCard;
        private System.Windows.Forms.Button btn192;
        private System.Windows.Forms.Button btnManual;
    }
}

