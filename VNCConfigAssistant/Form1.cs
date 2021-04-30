using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace VNCConfigAssistant
{

    // This application is not associated in any way with RealVNC Limited
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool keysExist = checkRegExists();


            if (keysExist == true)
            {

                // OK keys exist, we can continue
                // getting the current values to populate the form
                string encValue = getRegValue("Encryption");
                comboEncryption.SelectedItem = encValue;
                string authValue = getRegValue("Authentication");
                comboAuthentication.SelectedItem = authValue;
                // cloud connections?
                string cloudRfb = getRegValue("AllowCloudRfb");
                if (cloudRfb == "0")
                {
                    cbCloudRfb.Checked = false;
                }
                else
                {
                    cbCloudRfb.Checked = true;
                }
                // direct connections?
                string allowDirect = getRegValue("AllowIpListenRfb");
                if (allowDirect == "0")
                {
                    cbDirect.Checked = false;
                }
                else
                {
                    cbDirect.Checked = true;
                }
                string allowRelay = getRegValue("AllowCloudRelay");
                if (allowRelay == "0")
                {
                    cbCloudRelay.Checked = false;
                }
                else
                {
                    cbCloudRelay.Checked = true;
                }
                // query connect
                string queryConnect = getRegValue("QueryConnect");
                if (queryConnect == "0")
                {
                    cbQryConn.Checked = false;
                }
                else
                {
                    cbQryConn.Checked = true;
                }
                // permissions
                string permParam = getRegValue("Permissions");
                permissionString.Text = permParam;
            }
            else
            {
                MessageBox.Show("Cannot find the registry keys for VNC Server. Is it installed? Unable to proceed....");
                Application.Exit();
            }
        }



        private bool checkRegExists()
        {
            using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            using (var key = hklm.OpenSubKey(@"SOFTWARE\RealVNC\vncserver"))
            {
                if (key == null)
                {
                    MessageBox.Show("Cannot see VNC Server registry keys. Please check you have installed VNC Server.");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private string getRegValue(string keyName)
        {
            string keyValue = RegistryManagement.GetRegistryValue(keyName);
            return keyValue;

        }        
        

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblPermCreator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.lblPermCreator.LinkVisited = false;
            Process.Start(new ProcessStartInfo("https://www.realvnc.com/en/connect/download/vnc/") { UseShellExecute = true });
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            // get all of our values from the form components and save them using SetRegistryKey
            // TODO: we may want to confirm the settings with the user before proceeding
            bool confirmSave = true;
            // FIRST - if Permissions is blank, or ERROR, something likely went wrong so we should alert the user and NOT save
            string newPermString = permissionString.Text;
            if (newPermString == "" || newPermString == "KEYERROR")
            {
                MessageBox.Show("Issue with permission string. Not saving.");
                confirmSave = false;
            }
            else
            {
                RegistryManagement.SetRegistryValue("Permission", newPermString);
            }

            // encryption
            string wencSetting = comboEncryption.SelectedItem.ToString();
            if (confirmSave = true) { RegistryManagement.SetRegistryValue("Encryption", wencSetting); };

            // authentication            
            string wauthSetting = comboAuthentication.SelectedItem.ToString();
            // if the user has select VncAuth we need to prompt them to set the password to be used
            if (wauthSetting == "VncAuth" && confirmSave == true)
            {
                MessageBox.Show("VNCAuth requires you to set a password. Hit OK to set a password...");
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.WorkingDirectory = @"C:\Program Files\RealVNC\vnc server\";
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/C vncpasswd.exe -service";
                process.Start();
                process.WaitForExit();


            }
            if (confirmSave == true)
            {
                RegistryManagement.SetRegistryValue("Authentication", wauthSetting);
            }

            // direct connections?
            bool wdirectSetting = cbDirect.Checked;
            switch (wdirectSetting)
            {
                case true:
                    if (confirmSave == true)
                    {
                        RegistryManagement.SetRegistryValue("AllowIpListenRfb", "1");
                    }
                    break;
                case false:
                    if (confirmSave == true)
                    {
                        RegistryManagement.SetRegistryValue("AllowIpListenRfb", "0");
                    }

                    break;
            }
            // cloud connections?
            bool wcloudSetting = cbCloudRfb.Checked;
            switch (wcloudSetting)
            {
                case true:
                    if (confirmSave == true) { RegistryManagement.SetRegistryValue("AllowCloudRfb", "1"); }
                    break;
                case false:
                    if (confirmSave == true) { RegistryManagement.SetRegistryValue("AllowCloudRfb", "0"); }
                    break;
            }
            // cloud relay?
            bool wcloudRelay = cbCloudRelay.Checked;
            switch (wcloudRelay)
            {
                case true:
                    if (confirmSave == true) { RegistryManagement.SetRegistryValue("AllowCloudRelay", "1"); }
                    break;
                case false:
                    if (confirmSave == true)
                    {
                        RegistryManagement.SetRegistryValue("AllowCloudRelay", "0");
                    }
                    break;
            }
            // query connect
            bool wqueryConnect = cbQryConn.Checked;
            switch (wqueryConnect)
            {
                case true:
                    if (confirmSave == true)
                    {
                        RegistryManagement.SetRegistryValue("QueryConnect", "1");
                    }
                    // as we're keeping it simple, we'll also set QueryOnlyIfLoggedOn
                    if (confirmSave == true)
                    {
                        RegistryManagement.SetRegistryValue("QueryOnlyIfLoggedOn", "1");
                    }
                    break;
                case false:
                    if (confirmSave == true)
                    {
                        RegistryManagement.SetRegistryValue("QueryConnect", "0");
                    }
                    // as we're keeping it simple, we'll also set QueryOnlyIfLoggedOn
                    if (confirmSave == true) { RegistryManagement.SetRegistryValue("QueryOnlyIfLoggedOn", "0"); }
                    break;
            }

            if (confirmSave == true) 
            { 
                MessageBox.Show("Now you've done the basic setup of VNC Server, install VNC Viewer and connect :)"); 
            }
            // do we really need to quit the app?
            // Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process lwProc = new System.Diagnostics.Process();
            lwProc.StartInfo.UseShellExecute = false;
            lwProc.StartInfo.WorkingDirectory = @"C:\Program Files\RealVNC\vnc server\";
            lwProc.StartInfo.FileName = "cmd.exe";
            lwProc.StartInfo.Arguments = "/c vnclicensewiz.exe";
            lwProc.Start();
            // lwProc.WaitForExit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.lblSignUp.LinkVisited = false;
            Process.Start(new ProcessStartInfo("https://manage.realvnc.com/") { UseShellExecute = true });
        }

        private void cbQryConn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblCloudConn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.lblCloudConn.LinkVisited = false;
            Process.Start(new ProcessStartInfo("https://help.realvnc.com/hc/en-us/articles/360002249737-All-About-Cloud-Connections/") { UseShellExecute = true });
        }

        private void lblDirectConn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.lblDirectConn.LinkVisited = false;
            Process.Start(new ProcessStartInfo("https://help.realvnc.com/hc/en-us/articles/360002249797-All-About-Direct-Connections-") { UseShellExecute = true });
        }

        private void bReload_Click(object sender, EventArgs e)
        {
            string rencValue = getRegValue("Encryption");
            comboEncryption.SelectedItem = rencValue;
            string rauthValue = getRegValue("Authentication");
            comboAuthentication.SelectedItem = rauthValue;
            // cloud connections?
            string rcloudRfb = getRegValue("AllowCloudRfb");
            if (rcloudRfb == "0")
            {
                cbCloudRfb.Checked = false;
            }
            else
            {
                cbCloudRfb.Checked = true;
            }
            // direct connections?
            string rallowDirect = getRegValue("AllowIpListenRfb");
            if (rallowDirect == "0")
            {
                cbDirect.Checked = false;
            }
            else
            {
                cbDirect.Checked = true;
            }
            string rallowRelay = getRegValue("AllowCloudRelay");
            if (rallowRelay == "0")
            {
                cbCloudRelay.Checked = false;
            }
            else
            {
                cbCloudRelay.Checked = true;
            }
            // query connect
            string rqueryConnect = getRegValue("QueryConnect");
            if (rqueryConnect == "0")
            {
                cbQryConn.Checked = false;
            }
            else
            {
                cbQryConn.Checked = true;
            }
            // permissions
            string rpermParam = getRegValue("Permissions");
            permissionString.Text = rpermParam;
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkAboutPermissions.LinkVisited = false;
            Process.Start(new ProcessStartInfo("https://help.realvnc.com/hc/en-us/articles/360002253618-Managing-Users-and-Session-Permissions-for-VNC-Server") { UseShellExecute = true });
        }

        private void linkLabel1_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkAboutPermissions.LinkVisited = false;
            Process.Start(new ProcessStartInfo("https://www.youtube.com/watch?v=xqrOzwveRJI") { UseShellExecute = true });
        }

        
    }
}
