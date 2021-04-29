
namespace VNCConfigAssistant
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbCloudRfb = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDirect = new System.Windows.Forms.CheckBox();
            this.comboEncryption = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCloudConn = new System.Windows.Forms.LinkLabel();
            this.lblDirectConn = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboAuthentication = new System.Windows.Forms.ComboBox();
            this.cbCloudRelay = new System.Windows.Forms.CheckBox();
            this.lblPermCreator = new System.Windows.Forms.LinkLabel();
            this.bSave = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSignUp = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linkAboutPermissions = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.permissionString = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbQryConn = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bReload = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.label9 = new System.Windows.Forms.Label();
            this.linkGetStarted = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCloudRfb
            // 
            this.cbCloudRfb.AutoSize = true;
            this.helpProvider1.SetHelpKeyword(this.cbCloudRfb, "enablecloud");
            this.helpProvider1.SetHelpString(this.cbCloudRfb, "Enable connections brokered by RealVNC cloud. Recommended.");
            this.cbCloudRfb.Location = new System.Drawing.Point(24, 163);
            this.cbCloudRfb.Name = "cbCloudRfb";
            this.helpProvider1.SetShowHelp(this.cbCloudRfb, true);
            this.cbCloudRfb.Size = new System.Drawing.Size(166, 19);
            this.cbCloudRfb.TabIndex = 1;
            this.cbCloudRfb.Text = "Allow Cloud Connections?";
            this.cbCloudRfb.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Encryption";
            // 
            // cbDirect
            // 
            this.cbDirect.AutoSize = true;
            this.helpProvider1.SetHelpKeyword(this.cbDirect, "enabledirect");
            this.helpProvider1.SetHelpString(this.cbDirect, "Only available with Enterprise subscriptions");
            this.cbDirect.Location = new System.Drawing.Point(560, 163);
            this.cbDirect.Name = "cbDirect";
            this.helpProvider1.SetShowHelp(this.cbDirect, true);
            this.cbDirect.Size = new System.Drawing.Size(322, 19);
            this.cbDirect.TabIndex = 3;
            this.cbDirect.Text = "Allow Direct Connections (Enterprise subscriptions only)";
            this.cbDirect.UseVisualStyleBackColor = true;
            // 
            // comboEncryption
            // 
            this.comboEncryption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEncryption.FormattingEnabled = true;
            this.helpProvider1.SetHelpKeyword(this.comboEncryption, "encryption");
            this.helpProvider1.SetHelpString(this.comboEncryption, "Specify the encryption required");
            this.comboEncryption.Items.AddRange(new object[] {
            "AlwaysMaximum",
            "AlwaysOn",
            "PreferOn",
            "PreferOff",
            "AlwaysOff"});
            this.comboEncryption.Location = new System.Drawing.Point(144, 46);
            this.comboEncryption.Name = "comboEncryption";
            this.helpProvider1.SetShowHelp(this.comboEncryption, true);
            this.comboEncryption.Size = new System.Drawing.Size(329, 23);
            this.comboEncryption.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCloudConn);
            this.groupBox1.Controls.Add(this.lblDirectConn);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboAuthentication);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboEncryption);
            this.groupBox1.Controls.Add(this.cbCloudRelay);
            this.groupBox1.Controls.Add(this.cbCloudRfb);
            this.groupBox1.Controls.Add(this.cbDirect);
            this.groupBox1.Location = new System.Drawing.Point(20, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1145, 336);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 2 - Connection Security Settings";
            // 
            // lblCloudConn
            // 
            this.lblCloudConn.AutoSize = true;
            this.lblCloudConn.Location = new System.Drawing.Point(46, 217);
            this.lblCloudConn.Name = "lblCloudConn";
            this.lblCloudConn.Size = new System.Drawing.Size(145, 15);
            this.lblCloudConn.TabIndex = 16;
            this.lblCloudConn.TabStop = true;
            this.lblCloudConn.Text = "About Cloud Connections";
            this.lblCloudConn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCloudConn_LinkClicked);
            // 
            // lblDirectConn
            // 
            this.lblDirectConn.AutoSize = true;
            this.lblDirectConn.Location = new System.Drawing.Point(579, 217);
            this.lblDirectConn.Name = "lblDirectConn";
            this.lblDirectConn.Size = new System.Drawing.Size(144, 15);
            this.lblDirectConn.TabIndex = 16;
            this.lblDirectConn.TabStop = true;
            this.lblDirectConn.Text = "About Direct Connections";
            this.lblDirectConn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDirectConn_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(489, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(307, 45);
            this.label8.TabIndex = 13;
            this.label8.Text = "Choose the authentication scheme. \r\nSystem authentication is recommended for most" +
    " people.\r\nPlease ensure the permissions are set in step 3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(489, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(333, 30);
            this.label7.TabIndex = 12;
            this.label7.Text = "Choose the encryption required. \r\nAlwaysOn is the default and is recommended for " +
    "most people";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(395, 45);
            this.label5.TabIndex = 11;
            this.label5.Text = "Allow traffic to be relayed via RealVNC services if a peer-to-peer \r\nconnection c" +
    "annot be established.\r\nThis may cause some connections to fail, based on network" +
    " configuration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(579, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enable direct connections (hostname/IP address)\r\nRecommended for LAN use only\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enable connections brokered by RealVNC cloud services\r\nRecommended for most peopl" +
    "e";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Authentication";
            // 
            // comboAuthentication
            // 
            this.comboAuthentication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAuthentication.FormattingEnabled = true;
            this.helpProvider1.SetHelpKeyword(this.comboAuthentication, "authentication");
            this.helpProvider1.SetHelpString(this.comboAuthentication, "Specify the authentication method to be used when connecting");
            this.comboAuthentication.Items.AddRange(new object[] {
            "VncAuth",
            "SystemAuth",
            "InteractiveSystemAuth",
            "SingleSignOn,SystemAuth",
            "Certificate",
            "SystemAuth+Radius",
            "None"});
            this.comboAuthentication.Location = new System.Drawing.Point(144, 100);
            this.comboAuthentication.Name = "comboAuthentication";
            this.helpProvider1.SetShowHelp(this.comboAuthentication, true);
            this.comboAuthentication.Size = new System.Drawing.Size(328, 23);
            this.comboAuthentication.TabIndex = 6;
            // 
            // cbCloudRelay
            // 
            this.cbCloudRelay.AutoSize = true;
            this.helpProvider1.SetHelpKeyword(this.cbCloudRelay, "enablerelay");
            this.helpProvider1.SetHelpString(this.cbCloudRelay, "Allow connections to be relayed by RealVNC services if a peer-to-peer connection " +
        "cannot be brokered");
            this.cbCloudRelay.Location = new System.Drawing.Point(25, 255);
            this.cbCloudRelay.Name = "cbCloudRelay";
            this.helpProvider1.SetShowHelp(this.cbCloudRelay, true);
            this.cbCloudRelay.Size = new System.Drawing.Size(122, 19);
            this.cbCloudRelay.TabIndex = 8;
            this.cbCloudRelay.Text = "Allow Cloud Relay";
            this.cbCloudRelay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbCloudRelay.UseVisualStyleBackColor = true;
            // 
            // lblPermCreator
            // 
            this.lblPermCreator.AutoSize = true;
            this.lblPermCreator.Location = new System.Drawing.Point(650, 36);
            this.lblPermCreator.Name = "lblPermCreator";
            this.lblPermCreator.Size = new System.Drawing.Size(160, 15);
            this.lblPermCreator.TabIndex = 9;
            this.lblPermCreator.TabStop = true;
            this.lblPermCreator.Text = "Get VNC Permissions Creator";
            this.lblPermCreator.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblPermCreator_LinkClicked);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(32, 22);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(90, 32);
            this.bSave.TabIndex = 6;
            this.bSave.Text = "Save Settings";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(1038, 22);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(90, 32);
            this.bExit.TabIndex = 7;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Run License Wizard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.linkGetStarted);
            this.groupBox2.Controls.Add(this.lblSignUp);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(20, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1145, 100);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 1 - Licensing";
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Location = new System.Drawing.Point(504, 49);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(158, 15);
            this.lblSignUp.TabIndex = 12;
            this.lblSignUp.TabStop = true;
            this.lblSignUp.Text = "https://manage.realvnc.com";
            this.lblSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(518, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "Run license wizard and sign in using your RealVNC account to license your server " +
    "and cloud join. \r\nIf you don\'t yet have an account or a  subscription, sign up a" +
    "t ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.linkAboutPermissions);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.permissionString);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cbQryConn);
            this.groupBox3.Controls.Add(this.lblPermCreator);
            this.groupBox3.Location = new System.Drawing.Point(20, 477);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1145, 170);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step 3 - Access Control";
            // 
            // linkAboutPermissions
            // 
            this.linkAboutPermissions.AutoSize = true;
            this.linkAboutPermissions.Location = new System.Drawing.Point(650, 114);
            this.linkAboutPermissions.Name = "linkAboutPermissions";
            this.linkAboutPermissions.Size = new System.Drawing.Size(195, 15);
            this.linkAboutPermissions.TabIndex = 17;
            this.linkAboutPermissions.TabStop = true;
            this.linkAboutPermissions.Text = "Read about VNC Server permissions";
            this.linkAboutPermissions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(650, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(285, 15);
            this.label12.TabIndex = 16;
            this.label12.Text = "Only edit this value if you know what you\'re doing";
            // 
            // permissionString
            // 
            this.helpProvider1.SetHelpKeyword(this.permissionString, "permissions");
            this.helpProvider1.SetHelpString(this.permissionString, "User/group ID and permission");
            this.permissionString.Location = new System.Drawing.Point(650, 69);
            this.permissionString.Name = "permissionString";
            this.permissionString.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.helpProvider1.SetShowHelp(this.permissionString, true);
            this.permissionString.Size = new System.Drawing.Size(454, 23);
            this.permissionString.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(650, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(242, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "Permissions (from VNC Permissions Creator)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(566, 90);
            this.label10.TabIndex = 1;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // cbQryConn
            // 
            this.cbQryConn.AutoSize = true;
            this.helpProvider1.SetHelpKeyword(this.cbQryConn, "connect");
            this.helpProvider1.SetHelpString(this.cbQryConn, "For privacy, a logged on user must accept an incoming VNC connection if this is e" +
        "nabled");
            this.cbQryConn.Location = new System.Drawing.Point(25, 141);
            this.cbQryConn.Name = "cbQryConn";
            this.helpProvider1.SetShowHelp(this.cbQryConn, true);
            this.cbQryConn.Size = new System.Drawing.Size(281, 19);
            this.cbQryConn.TabIndex = 0;
            this.cbQryConn.Text = "Require a logged on user to accept a connection";
            this.cbQryConn.UseVisualStyleBackColor = true;
            this.cbQryConn.CheckedChanged += new System.EventHandler(this.cbQryConn_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bReload);
            this.groupBox4.Controls.Add(this.bSave);
            this.groupBox4.Controls.Add(this.bExit);
            this.groupBox4.Location = new System.Drawing.Point(20, 653);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1145, 66);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Step 4 - Finishing up";
            // 
            // bReload
            // 
            this.bReload.Location = new System.Drawing.Point(930, 22);
            this.bReload.Name = "bReload";
            this.bReload.Size = new System.Drawing.Size(90, 32);
            this.bReload.TabIndex = 8;
            this.bReload.Text = "Revert";
            this.bReload.UseVisualStyleBackColor = true;
            this.bReload.Click += new System.EventHandler(this.bReload_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 725);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(356, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "This application is NOT provided or supported by RealVNC Limited";
            // 
            // linkGetStarted
            // 
            this.linkGetStarted.AutoSize = true;
            this.linkGetStarted.Location = new System.Drawing.Point(973, 66);
            this.linkGetStarted.Name = "linkGetStarted";
            this.linkGetStarted.Size = new System.Drawing.Size(155, 15);
            this.linkGetStarted.TabIndex = 13;
            this.linkGetStarted.TabStop = true;
            this.linkGetStarted.Text = "Watch Getting Started video";
            this.linkGetStarted.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 747);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "VNC Server Config Assistant";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbCloudRfb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbDirect;
        private System.Windows.Forms.ComboBox comboEncryption;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboAuthentication;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.CheckBox cbCloudRelay;
        private System.Windows.Forms.LinkLabel lblPermCreator;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel lblSignUp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbQryConn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox permissionString;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.LinkLabel lblCloudConn;
        private System.Windows.Forms.LinkLabel lblDirectConn;
        private System.Windows.Forms.Label label12;        
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button bReload;
        private System.Windows.Forms.LinkLabel linkAboutPermissions;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel linkGetStarted;
    }
}

