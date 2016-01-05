using System;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.IO;

namespace Magical_PingTools
{
    public partial class MainProgram : Form
    {
        string CmdComm = null;
        string gateway = null;

        public MainProgram()
        {
            InitializeComponent();
            rtxtResult.ReadOnly = true;
            gbLocalInfoRefresh();
            GetNicName();
        }

        /// <summary>
        /// 取得啟用中的網路名稱，並將名稱傳給cboSelectCard
        /// </summary>
        private void GetNicName()
        {
            cboSelectCard.Items.Clear();
            NetworkInterface[] nicInfo = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in nicInfo)
            {
                if (adapter.NetworkInterfaceType == NetworkInterfaceType.Ethernet & 
                    adapter.OperationalStatus==OperationalStatus.Up)
                {
                    cboSelectCard.Items.Add(adapter.Name);
                }
                if (adapter.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 &
                    adapter.OperationalStatus==OperationalStatus.Up)
                {
                    cboSelectCard.Items.Add(adapter.Name);
                }
            }
        }

        /// <summary>
        /// gbLocalInformation Refresh
        /// </summary>
        private void gbLocalInfoRefresh()
        {
            //Get Local Host Name
            string strHostName = Dns.GetHostName();
            //宣告一個IP陣列，位址4個，1個放LAN，1個放Wireless，另外2個備用，避免超過2張以上的網卡後，程式開啟錯誤
            string[] strIP = { "Null", "Null", "Null", "Null" };
            lblHostNameShow.Text = strHostName;
            //Get Local Host IP Address List
            IPHostEntry iphostentry = Dns.GetHostEntry(strHostName);
            int num = 0;
            foreach (IPAddress ipaddress in iphostentry.AddressList)
            {
                if (ipaddress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    strIP[num] = ipaddress.ToString();
                    num++;
                }
            }
            lblLanAddressShow.Text = strIP[0];
            lblWifiAddressShow.Text = strIP[1];
            //Get Network Interface Card Array
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (var nic in nics)
            {
                //Get LAN MAC
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    string[] mac = new string[6];
                    mac[0] = nic.GetPhysicalAddress().ToString().Substring(0, 2);
                    mac[1] = nic.GetPhysicalAddress().ToString().Substring(2, 2);
                    mac[2] = nic.GetPhysicalAddress().ToString().Substring(4, 2);
                    mac[3] = nic.GetPhysicalAddress().ToString().Substring(6, 2);
                    mac[4] = nic.GetPhysicalAddress().ToString().Substring(8, 2);
                    mac[5] = nic.GetPhysicalAddress().ToString().Substring(10, 2);
                    lblLanMacShow.Text = string.Join("-", mac);
                }
                //Get Wireless MAC
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                {
                    string[] mac = new string[6];
                    mac[0] = nic.GetPhysicalAddress().ToString().Substring(0, 2);
                    mac[1] = nic.GetPhysicalAddress().ToString().Substring(2, 2);
                    mac[2] = nic.GetPhysicalAddress().ToString().Substring(4, 2);
                    mac[3] = nic.GetPhysicalAddress().ToString().Substring(6, 2);
                    mac[4] = nic.GetPhysicalAddress().ToString().Substring(8, 2);
                    mac[5] = nic.GetPhysicalAddress().ToString().Substring(10, 2);
                    lblWifiMacShow.Text = string.Join("-", mac);
                }
                //Get Gateway IP Address
                foreach (NetworkInterface adapter in nics)
                {
                    IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
                    GatewayIPAddressInformationCollection address = adapterProperties.GatewayAddresses;
                    if (address.Count > 0)
                    {
                        foreach (GatewayIPAddressInformation addresses in address)
                        {
                            gateway = addresses.Address.ToString();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Set Network Address is DHCP or Static
        /// </summary>
        /// <param name="command">setting command</param>
        /// <returns></returns>
        private bool setNetwork(string command)
        {
            bool result = false;
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c" + command;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            try
            {
                p.Start();
                result = true;
            }
            catch(Exception)
            {
                throw;
            }
            return result;
        }

        /// <summary>
        /// 呼叫CMD在背景執行，傳回執行結果
        /// </summary>
        /// <param name="command">要執行的指令</param>
        /// <returns></returns>
        private string RunCmd(string command)
        {
            rtxtResult.Text = null;
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c" + command;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            return p.StandardOutput.ReadToEnd();
        }

        /// <summary>
        /// 呼叫CMD並可看見執行過程
        /// </summary>
        /// <param name="command">要執行的指令</param>
        private void RunCmdSee(string command)
        {
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c" + command;
            p.StartInfo.UseShellExecute = true;
            p.Start();
        }

        /// <summary>
        /// Open Iexplore.exe
        /// </summary>
        /// <param name="WWW">要開啟的網址</param>
        private void RunIE(string WWW)
        {
            Process.Start("iexplore.exe", WWW);
        }

        /// <summary>
        /// Check ComboBox.Items
        /// </summary>
        /// <returns></returns>
        private bool CheckComboBoxNull()
        {
            bool result = true;
            if (cboSelectCard.Text == "")
            {
                MessageBox.Show("You not select setting network name! Please check...", "Infomation", MessageBoxButtons
                    .OK, MessageBoxIcon.Information);
            }
            else
            {
                result = false;
            }
            return result;
        }

        /// <summary>
        /// 檢查TextBox.Text是否為null，若為null傳回true
        /// </summary>
        /// <param name="txt">要檢查的TextBox.Text</param>
        /// <returns></returns>
        private bool CheckTxtBoxNull(string txt)
        {
            bool result;
            if (txt == "")
            {
                MessageBox.Show("You not input IP or WWW！Please Check...", "Error Message", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        /// <summary>
        /// 先檢查是否有Hinet.Dr.Speed測速程式，若沒有就下載
        /// </summary>
        /// <returns></returns>
        private bool CheckDrSpeed()
        {
            bool chkResult = false;
            //檢查路徑為程式起始執行的路徑
            string filePath = Application.StartupPath + "\\HiNet.Dr.Speed.0.96a.beta.exe";
            string fileName = "HiNet.Dr.Speed.0.96a.beta.exe", fileResource = null;
            string url = "http://spearmint-drspeed.cdn.hinet.net/";
            if ( File.Exists(filePath)==true)
            {
                chkResult = true;
            }
            else
            {
                if( MessageBox.Show("Hinet測速檔案尚未下載！"+Environment.NewLine+"是否要下載？","詢問",MessageBoxButtons
                    .YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
                {
                    try
                    {
                        using (WebClient download = new WebClient())
                        {
                            fileResource = url + fileName;
                            download.DownloadFile(fileResource, fileName);
                        }
                        chkResult = true;
                    }
                    catch(Exception)
                    {
                        throw;
                    }
                }
            }
            return chkResult;
        }

        /// <summary>
        /// 設定成功後，要呼叫顯示的MessageBox
        /// </summary>
        private void setSuccess()
        {
            MessageBox.Show("Success！", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// IP地址檢查錯誤，要秀的MsgBox
        /// </summary>
        private void MsgIPError()
        {
            MessageBox.Show("IP、Mask、Gateway is Error！Please Check...", "Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        /// <summary>
        /// 限制TextBox只能輸入數字和倒退鍵和.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void TextOnlyNum(object sender, KeyPressEventArgs e)
        {
            int keychar = (int)e.KeyChar;
            int dot = (int)'.';
            int bk = (int)Keys.Back;
            int zero = (int)'0';
            int night = (int)'9';
            if ((keychar >= zero && keychar <= night) || (keychar == bk) || (keychar == dot))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            gbLocalInfoRefresh();
            GetNicName();
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            if (CheckTxtBoxNull(txtInput.Text) == true)
            {
                return;
            }
            CmdComm = "ping " + txtInput.Text;
            rtxtResult.Text = RunCmd(CmdComm);
        }

        private void btnIpconfigAll_Click(object sender, EventArgs e)
        {
            CmdComm = "ipconfig /all";
            rtxtResult.Text = RunCmd(CmdComm);
        }

        private void btnArp_Click(object sender, EventArgs e)
        {
            CmdComm = "arp -a";
            rtxtResult.Text = RunCmd(CmdComm);
        }

        private void btnNetstat_Click(object sender, EventArgs e)
        {
            CmdComm = "netstat -no";
            rtxtResult.Text = RunCmd(CmdComm);
        }

        private void rdoHinetDNS1_CheckedChanged(object sender, EventArgs e)
        {
            txtInput.Text = "168.95.1.1";
        }

        private void rdoHinetDNS2_CheckedChanged(object sender, EventArgs e)
        {
            txtInput.Text = "168.95.192.1";
        }

        private void rdoGoogleDNS_CheckedChanged(object sender, EventArgs e)
        {
            txtInput.Text = "8.8.8.8";
        }

        private void rdoGoogle_CheckedChanged(object sender, EventArgs e)
        {
            txtInput.Text = "www.google.com";
        }

        private void rdoYahoo_CheckedChanged(object sender, EventArgs e)
        {
            txtInput.Text = "tw.yahoo.com";
        }

        private void rdoGateway_CheckedChanged(object sender, EventArgs e)
        {
            txtInput.Text = gateway;
        }

        private void btnPingT_Click(object sender, EventArgs e)
        {
            if (CheckTxtBoxNull(txtInput.Text) == true)
            {
                return;
            }
            CmdComm = "ping " + txtInput.Text + " -t";
            RunCmdSee(CmdComm);
        }

        private void btnNslookup_Click(object sender, EventArgs e)
        {
            if (CheckTxtBoxNull(txtInput.Text) == true)
            {
                return;
            }
            CmdComm = "nslookup " + txtInput.Text;
            rtxtResult.Text = RunCmd(CmdComm);
        }

        private void btnPathPing_Click(object sender, EventArgs e)
        {
            if (CheckTxtBoxNull(txtInput.Text) == true)
            {
                return;
            }
            CmdComm = "pathping " + txtInput.Text;
            rtxtResult.Text = RunCmd(CmdComm);
        }

        private void btnTracert_Click(object sender, EventArgs e)
        {
            if (CheckTxtBoxNull(txtInput.Text) == true)
            {
                return;
            }
            CmdComm = "tracert " + txtInput.Text;
            rtxtResult.Text = RunCmd(CmdComm);
        }

        private void btnNbtstatA_Click(object sender, EventArgs e)
        {
            if (CheckTxtBoxNull(txtInput.Text) == true)
            {
                return;
            }
            CmdComm = "nbtstat -A " + txtInput.Text;
            rtxtResult.Text = RunCmd(CmdComm);
        }

        private void btnOpenIE_Click(object sender, EventArgs e)
        {
            if (CheckTxtBoxNull(txtInput.Text) == true)
            {
                return;
            }
            RunIE("http://" + txtInput.Text);
        }

        private void btnOpenIE8080_Click(object sender, EventArgs e)
        {
            if (CheckTxtBoxNull(txtInput.Text) == true)
            {
                return;
            }
            RunIE("http://" + txtInput.Text + ":8080");
        }

        private void btnDrSpeed_Click(object sender, EventArgs e)
        {
            if (CheckDrSpeed() == true)
            {
                Process.Start("HiNet.Dr.Speed.0.96a.beta.exe");
            }
        }

        private void btnDHCP_Click(object sender, EventArgs e)
        {
            if (CheckComboBoxNull() == false)
            {
                int i = 0;
                CmdComm = "netsh interface ip set address " + cboSelectCard.Text + " DHCP";
                if(setNetwork(CmdComm)==true)
                {
                    i++;
                }
                CmdComm = "netsh interface ip set dns " + cboSelectCard.Text + " DHCP";
                if (setNetwork(CmdComm) == true)
                {
                    i++;
                }
                if(i==2)
                {
                    setSuccess();
                }
                gbLocalInfoRefresh();
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (CheckComboBoxNull() == false)
            {
                int i = 0;
                CmdComm = "netsh interface ip set address " + cboSelectCard.Text + " static 10.0.0.15 255.0.0.0 " +
                    "10.10.1.1 1";
                if (setNetwork(CmdComm) == true)
                {
                    i++;
                }
                CmdComm = "netsh interface ip set dns " + cboSelectCard.Text + " static 168.95.1.1 primary";
                if (setNetwork(CmdComm) == true)
                {
                    i++;
                }
                CmdComm = "netsh interface ip add dns " + cboSelectCard.Text + " 8.8.8.8";
                if (setNetwork(CmdComm) == true)
                {
                    i++;
                }
                if (i == 3)
                {
                    setSuccess();
                }
                gbLocalInfoRefresh();
            }
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            if (CheckComboBoxNull() == false)
            {
                int i = 0;
                CmdComm = "netsh interface ip set address " + cboSelectCard.Text + " static 100.0.0.15 255.0.0.0 " +
                    "100.100.1.1 1";
                if (setNetwork(CmdComm) == true)
                {
                    i++;
                }
                CmdComm = "netsh interface ip set dns " + cboSelectCard.Text + " static 168.95.1.1 primary";
                if (setNetwork(CmdComm) == true)
                {
                    i++;
                }
                CmdComm = "netsh interface ip add dns " + cboSelectCard.Text + " 8.8.8.8";
                if (setNetwork(CmdComm) == true)
                {
                    i++;
                }
                if (i == 3)
                {
                    setSuccess();
                }
                gbLocalInfoRefresh();
            }
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            if (CheckComboBoxNull() == false)
            {
                int i = 0;
                CmdComm = "netsh interface ip set address " + cboSelectCard.Text + " static 200.0.0.15 255.0.0.0 " +
                    "200.200.1.1 1";
                if (setNetwork(CmdComm) == true)
                {
                    i++;
                }
                CmdComm = "netsh interface ip set dns " + cboSelectCard.Text + " static 168.95.1.1 primary";
                if (setNetwork(CmdComm) == true)
                {
                    i++;
                }
                CmdComm = "netsh interface ip add dns " + cboSelectCard.Text + " 8.8.8.8";
                if (setNetwork(CmdComm) == true)
                {
                    i++;
                }
                if (i == 3)
                {
                    setSuccess();
                }
                gbLocalInfoRefresh();
            }
        }

        private void btn192_Click(object sender, EventArgs e)
        {
            if (CheckComboBoxNull() == false)
            {
                int i = 0;
                CmdComm = "netsh interface ip set address " + cboSelectCard.Text + " static 192.0.0.15 255.0.0.0 " +
                    "192.168.1.1 1";
                if (setNetwork(CmdComm) == true)
                {
                    i++;
                }
                CmdComm = "netsh interface ip set dns " + cboSelectCard.Text + " static 168.95.1.1 primary";
                if (setNetwork(CmdComm) == true)
                {
                    i++;
                }
                CmdComm = "netsh interface ip add dns " + cboSelectCard.Text + " 8.8.8.8";
                if (setNetwork(CmdComm) == true)
                {
                    i++;
                }
                if (i == 3)
                {
                    setSuccess();
                }
                gbLocalInfoRefresh();
            }
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            if (CheckComboBoxNull() == false)
            {
                Manual m = new Manual();
                if (m.ShowDialog() == DialogResult.OK)
                {
                    int i = 0;
                    CmdComm = "netsh interface ip set address " + cboSelectCard.Text + " static " + m.txtAddress.Text +
                        " " + m.txtMask.Text + " " + m.txtGateway.Text + " 1";
                    if (setNetwork(CmdComm) == true)
                    {
                        i++;
                    }
                    CmdComm = "netsh interface ip set dns " + cboSelectCard.Text + " static 168.95.1.1 primary";
                    if (setNetwork(CmdComm) == true)
                    {
                        i++;
                    }
                    CmdComm = "netsh interface ip add dns " + cboSelectCard.Text + " 8.8.8.8";
                    if (setNetwork(CmdComm) == true)
                    {
                        i++;
                    }
                    if (i == 3)
                    {
                        setSuccess();
                    }
                    gbLocalInfoRefresh();
                }
            }
        }
    }
}
