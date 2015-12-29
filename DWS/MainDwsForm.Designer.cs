using System.ComponentModel;
using System.Windows.Forms;

namespace DWS_Lite
{
    sealed partial class MainDwsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FormTabsControl = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.btnDestroyWindows78Spy = new System.Windows.Forms.Button();
            this.LogOutputTextBox = new System.Windows.Forms.RichTextBox();
            this.StatusCommandsLable = new System.Windows.Forms.Label();
            this.ProgressBarStatus = new System.Windows.Forms.ProgressBar();
            this.btnDestroyWindowsSpying = new System.Windows.Forms.Button();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.Windows78Panel = new System.Windows.Forms.Panel();
            this.checkBoxDelKeyloggerTW78 = new System.Windows.Forms.CheckBox();
            this.labelUninstallUpdates = new System.Windows.Forms.Label();
            this.checkedListBoxUpdatesW78 = new System.Windows.Forms.CheckedListBox();
            this.checkBoxDeleteGWX = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteWindows78Updates = new System.Windows.Forms.CheckBox();
            this.checkBoxSPYTasks78 = new System.Windows.Forms.CheckBox();
            this.checkBoxAddToHosts78 = new System.Windows.Forms.CheckBox();
            this.Win10SettingsPanel = new System.Windows.Forms.Panel();
            this.checkBoxCreateSystemRestorePoint = new System.Windows.Forms.CheckBox();
            this.checkBoxKeyLoggerAndTelemetry = new System.Windows.Forms.CheckBox();
            this.checkBoxAddToHosts = new System.Windows.Forms.CheckBox();
            this.labelInfoDeleteMetroApps = new System.Windows.Forms.Label();
            this.checkBoxDeleteAppXBOX = new System.Windows.Forms.CheckBox();
            this.checkBoxDisablePrivateSettings = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteAppVoice = new System.Windows.Forms.CheckBox();
            this.checkBoxDisableWindowsDefender = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteAppSolit = new System.Windows.Forms.CheckBox();
            this.checkBoxSetDefaultPhoto = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteAppPhotos = new System.Windows.Forms.CheckBox();
            this.checkBoxSPYTasks = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteAppPhone = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteWindows10Apps = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteAppPeopleOneNote = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteApp3d = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteAppZune = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteAppCamera = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteAppBing = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteMailCalendarMaps = new System.Windows.Forms.CheckBox();
            this.btnProfessionalMode = new System.Windows.Forms.CheckBox();
            this.tabPageUtilites = new System.Windows.Forms.TabPage();
            this.btnFixRotateScreen = new System.Windows.Forms.Button();
            this.btnDisableOfficeUpdate = new System.Windows.Forms.Button();
            this.btnRemoveOldFirewallRules = new System.Windows.Forms.Button();
            this.btnDeleteOneDrive = new System.Windows.Forms.Button();
            this.btnDeleteMetroAppsInfo = new System.Windows.Forms.Button();
            this.groupBoxWindowsUpdate = new System.Windows.Forms.GroupBox();
            this.btnEnableWindowsUpdate = new System.Windows.Forms.Button();
            this.btnDisableWindowsUpdate = new System.Windows.Forms.Button();
            this.groupBoxUACEdit = new System.Windows.Forms.GroupBox();
            this.btnEnableUac = new System.Windows.Forms.Button();
            this.btnDisableUac = new System.Windows.Forms.Button();
            this.btnOpenAndEditHosts = new System.Windows.Forms.Button();
            this.btnRestoreSystem = new System.Windows.Forms.Button();
            this.btnDeleteAllWindows10Apps = new System.Windows.Forms.Button();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.linkLabelSourceCode = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBoxLanguage = new System.Windows.Forms.GroupBox();
            this.comboBoxLanguageSelect = new System.Windows.Forms.ComboBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.labelMoonInfo = new System.Windows.Forms.Label();
            this.tabPageReadMe = new System.Windows.Forms.TabPage();
            this.ReadmeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.CaptionWindow = new System.Windows.Forms.Label();
            this._CloseButton = new System.Windows.Forms.PictureBox();
            this.MinimizeButton = new System.Windows.Forms.PictureBox();
            this.BorderUP = new System.Windows.Forms.PictureBox();
            this.BorderDown = new System.Windows.Forms.PictureBox();
            this.BorderLeft = new System.Windows.Forms.PictureBox();
            this.BorderR = new System.Windows.Forms.PictureBox();
            this.FormTabsControl.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.Windows78Panel.SuspendLayout();
            this.Win10SettingsPanel.SuspendLayout();
            this.tabPageUtilites.SuspendLayout();
            this.groupBoxWindowsUpdate.SuspendLayout();
            this.groupBoxUACEdit.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            this.groupBoxLanguage.SuspendLayout();
            this.tabPageReadMe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderR)).BeginInit();
            this.SuspendLayout();
            // 
            // FormTabsControl
            // 
            this.FormTabsControl.Controls.Add(this.tabPageMain);
            this.FormTabsControl.Controls.Add(this.tabPageSettings);
            this.FormTabsControl.Controls.Add(this.tabPageUtilites);
            this.FormTabsControl.Controls.Add(this.tabPageAbout);
            this.FormTabsControl.Controls.Add(this.tabPageReadMe);
            this.FormTabsControl.Location = new System.Drawing.Point(0, 31);
            this.FormTabsControl.Name = "FormTabsControl";
            this.FormTabsControl.SelectedIndex = 0;
            this.FormTabsControl.Size = new System.Drawing.Size(453, 426);
            this.FormTabsControl.TabIndex = 0;
            // 
            // tabPageMain
            // 
            this.tabPageMain.BackColor = System.Drawing.Color.White;
            this.tabPageMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageMain.Controls.Add(this.btnDestroyWindows78Spy);
            this.tabPageMain.Controls.Add(this.LogOutputTextBox);
            this.tabPageMain.Controls.Add(this.StatusCommandsLable);
            this.tabPageMain.Controls.Add(this.ProgressBarStatus);
            this.tabPageMain.Controls.Add(this.btnDestroyWindowsSpying);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(445, 400);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Main";
            // 
            // btnDestroyWindows78Spy
            // 
            this.btnDestroyWindows78Spy.BackColor = System.Drawing.Color.White;
            this.btnDestroyWindows78Spy.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnDestroyWindows78Spy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDestroyWindows78Spy.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDestroyWindows78Spy.Location = new System.Drawing.Point(8, 6);
            this.btnDestroyWindows78Spy.Name = "btnDestroyWindows78Spy";
            this.btnDestroyWindows78Spy.Size = new System.Drawing.Size(429, 50);
            this.btnDestroyWindows78Spy.TabIndex = 4;
            this.btnDestroyWindows78Spy.Text = "Destroy Windows 7/8.1 Spying\r\nRemove updates, tasks, and other )";
            this.btnDestroyWindows78Spy.UseVisualStyleBackColor = false;
            this.btnDestroyWindows78Spy.Visible = false;
            this.btnDestroyWindows78Spy.Click += new System.EventHandler(this.btnDestroyWindows78Spy_Click);
            // 
            // LogOutputTextBox
            // 
            this.LogOutputTextBox.BackColor = System.Drawing.Color.White;
            this.LogOutputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogOutputTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogOutputTextBox.ForeColor = System.Drawing.Color.Navy;
            this.LogOutputTextBox.Location = new System.Drawing.Point(8, 113);
            this.LogOutputTextBox.Name = "LogOutputTextBox";
            this.LogOutputTextBox.ReadOnly = true;
            this.LogOutputTextBox.Size = new System.Drawing.Size(429, 279);
            this.LogOutputTextBox.TabIndex = 3;
            this.LogOutputTextBox.Text = "Final DWS version.\nhttps://twitter.com/nummerok\n==========================\n";
            this.LogOutputTextBox.TextChanged += new System.EventHandler(this.LogOutputTextBox_TextChanged);
            // 
            // StatusCommandsLable
            // 
            this.StatusCommandsLable.BackColor = System.Drawing.Color.Transparent;
            this.StatusCommandsLable.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusCommandsLable.Location = new System.Drawing.Point(8, 88);
            this.StatusCommandsLable.Name = "StatusCommandsLable";
            this.StatusCommandsLable.Size = new System.Drawing.Size(429, 22);
            this.StatusCommandsLable.TabIndex = 2;
            this.StatusCommandsLable.Text = "Destroy Windows 10 Spying";
            this.StatusCommandsLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgressBarStatus
            // 
            this.ProgressBarStatus.BackColor = System.Drawing.SystemColors.Control;
            this.ProgressBarStatus.Location = new System.Drawing.Point(8, 62);
            this.ProgressBarStatus.Name = "ProgressBarStatus";
            this.ProgressBarStatus.Size = new System.Drawing.Size(429, 23);
            this.ProgressBarStatus.TabIndex = 1;
            // 
            // btnDestroyWindowsSpying
            // 
            this.btnDestroyWindowsSpying.BackColor = System.Drawing.Color.White;
            this.btnDestroyWindowsSpying.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnDestroyWindowsSpying.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDestroyWindowsSpying.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDestroyWindowsSpying.Location = new System.Drawing.Point(8, 6);
            this.btnDestroyWindowsSpying.Name = "btnDestroyWindowsSpying";
            this.btnDestroyWindowsSpying.Size = new System.Drawing.Size(429, 50);
            this.btnDestroyWindowsSpying.TabIndex = 0;
            this.btnDestroyWindowsSpying.Text = "Destroy Windows 10 Spying";
            this.btnDestroyWindowsSpying.UseVisualStyleBackColor = false;
            this.btnDestroyWindowsSpying.Click += new System.EventHandler(this.btnDestroyWindowsSpying_Click);
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.BackColor = System.Drawing.Color.White;
            this.tabPageSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageSettings.Controls.Add(this.Windows78Panel);
            this.tabPageSettings.Controls.Add(this.Win10SettingsPanel);
            this.tabPageSettings.Controls.Add(this.btnProfessionalMode);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(445, 400);
            this.tabPageSettings.TabIndex = 1;
            this.tabPageSettings.Text = "Settings";
            // 
            // Windows78Panel
            // 
            this.Windows78Panel.BackColor = System.Drawing.Color.Transparent;
            this.Windows78Panel.Controls.Add(this.checkBoxDelKeyloggerTW78);
            this.Windows78Panel.Controls.Add(this.labelUninstallUpdates);
            this.Windows78Panel.Controls.Add(this.checkedListBoxUpdatesW78);
            this.Windows78Panel.Controls.Add(this.checkBoxDeleteGWX);
            this.Windows78Panel.Controls.Add(this.checkBoxDeleteWindows78Updates);
            this.Windows78Panel.Controls.Add(this.checkBoxSPYTasks78);
            this.Windows78Panel.Controls.Add(this.checkBoxAddToHosts78);
            this.Windows78Panel.Enabled = false;
            this.Windows78Panel.Location = new System.Drawing.Point(6, 3);
            this.Windows78Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Windows78Panel.Name = "Windows78Panel";
            this.Windows78Panel.Size = new System.Drawing.Size(434, 365);
            this.Windows78Panel.TabIndex = 23;
            this.Windows78Panel.Visible = false;
            // 
            // checkBoxDelKeyloggerTW78
            // 
            this.checkBoxDelKeyloggerTW78.AutoSize = true;
            this.checkBoxDelKeyloggerTW78.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDelKeyloggerTW78.Checked = true;
            this.checkBoxDelKeyloggerTW78.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDelKeyloggerTW78.Location = new System.Drawing.Point(3, 71);
            this.checkBoxDelKeyloggerTW78.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDelKeyloggerTW78.Name = "checkBoxDelKeyloggerTW78";
            this.checkBoxDelKeyloggerTW78.Size = new System.Drawing.Size(177, 17);
            this.checkBoxDelKeyloggerTW78.TabIndex = 6;
            this.checkBoxDelKeyloggerTW78.Text = "Delete keylogger and telemetry";
            this.checkBoxDelKeyloggerTW78.UseVisualStyleBackColor = false;
            // 
            // labelUninstallUpdates
            // 
            this.labelUninstallUpdates.AutoSize = true;
            this.labelUninstallUpdates.Location = new System.Drawing.Point(7, 105);
            this.labelUninstallUpdates.Name = "labelUninstallUpdates";
            this.labelUninstallUpdates.Size = new System.Drawing.Size(93, 13);
            this.labelUninstallUpdates.TabIndex = 5;
            this.labelUninstallUpdates.Text = "Uninstall updates:";
            // 
            // checkedListBoxUpdatesW78
            // 
            this.checkedListBoxUpdatesW78.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBoxUpdatesW78.Enabled = false;
            this.checkedListBoxUpdatesW78.FormattingEnabled = true;
            this.checkedListBoxUpdatesW78.Location = new System.Drawing.Point(6, 121);
            this.checkedListBoxUpdatesW78.Name = "checkedListBoxUpdatesW78";
            this.checkedListBoxUpdatesW78.Size = new System.Drawing.Size(210, 162);
            this.checkedListBoxUpdatesW78.TabIndex = 4;
            // 
            // checkBoxDeleteGWX
            // 
            this.checkBoxDeleteGWX.AutoSize = true;
            this.checkBoxDeleteGWX.Checked = true;
            this.checkBoxDeleteGWX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDeleteGWX.Enabled = false;
            this.checkBoxDeleteGWX.Location = new System.Drawing.Point(3, 54);
            this.checkBoxDeleteGWX.Name = "checkBoxDeleteGWX";
            this.checkBoxDeleteGWX.Size = new System.Drawing.Size(83, 17);
            this.checkBoxDeleteGWX.TabIndex = 3;
            this.checkBoxDeleteGWX.Text = "Delete GWX";
            this.checkBoxDeleteGWX.UseVisualStyleBackColor = true;
            // 
            // checkBoxDeleteWindows78Updates
            // 
            this.checkBoxDeleteWindows78Updates.AutoSize = true;
            this.checkBoxDeleteWindows78Updates.Checked = true;
            this.checkBoxDeleteWindows78Updates.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDeleteWindows78Updates.Enabled = false;
            this.checkBoxDeleteWindows78Updates.Location = new System.Drawing.Point(3, 37);
            this.checkBoxDeleteWindows78Updates.Name = "checkBoxDeleteWindows78Updates";
            this.checkBoxDeleteWindows78Updates.Size = new System.Drawing.Size(137, 17);
            this.checkBoxDeleteWindows78Updates.TabIndex = 2;
            this.checkBoxDeleteWindows78Updates.Text = "Delete spying updates.";
            this.checkBoxDeleteWindows78Updates.UseVisualStyleBackColor = true;
            this.checkBoxDeleteWindows78Updates.CheckedChanged += new System.EventHandler(this.checkBoxDeleteWindows78Updates_CheckedChanged);
            // 
            // checkBoxSPYTasks78
            // 
            this.checkBoxSPYTasks78.AutoSize = true;
            this.checkBoxSPYTasks78.Checked = true;
            this.checkBoxSPYTasks78.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSPYTasks78.Enabled = false;
            this.checkBoxSPYTasks78.Location = new System.Drawing.Point(3, 20);
            this.checkBoxSPYTasks78.Name = "checkBoxSPYTasks78";
            this.checkBoxSPYTasks78.Size = new System.Drawing.Size(109, 17);
            this.checkBoxSPYTasks78.TabIndex = 1;
            this.checkBoxSPYTasks78.Text = "Disable SPY tasks";
            this.checkBoxSPYTasks78.UseVisualStyleBackColor = true;
            // 
            // checkBoxAddToHosts78
            // 
            this.checkBoxAddToHosts78.AutoSize = true;
            this.checkBoxAddToHosts78.Checked = true;
            this.checkBoxAddToHosts78.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAddToHosts78.Enabled = false;
            this.checkBoxAddToHosts78.Location = new System.Drawing.Point(3, 3);
            this.checkBoxAddToHosts78.Name = "checkBoxAddToHosts78";
            this.checkBoxAddToHosts78.Size = new System.Drawing.Size(314, 17);
            this.checkBoxAddToHosts78.TabIndex = 0;
            this.checkBoxAddToHosts78.Text = "Add spy domains to hosts file, and block in Windows Firewall";
            this.checkBoxAddToHosts78.UseVisualStyleBackColor = true;
            // 
            // Win10SettingsPanel
            // 
            this.Win10SettingsPanel.BackColor = System.Drawing.Color.Transparent;
            this.Win10SettingsPanel.Controls.Add(this.checkBoxCreateSystemRestorePoint);
            this.Win10SettingsPanel.Controls.Add(this.checkBoxKeyLoggerAndTelemetry);
            this.Win10SettingsPanel.Controls.Add(this.checkBoxAddToHosts);
            this.Win10SettingsPanel.Controls.Add(this.labelInfoDeleteMetroApps);
            this.Win10SettingsPanel.Controls.Add(this.checkBoxDeleteAppXBOX);
            this.Win10SettingsPanel.Controls.Add(this.checkBoxDisablePrivateSettings);
            this.Win10SettingsPanel.Controls.Add(this.checkBoxDeleteAppVoice);
            this.Win10SettingsPanel.Controls.Add(this.checkBoxDisableWindowsDefender);
            this.Win10SettingsPanel.Controls.Add(this.checkBoxDeleteAppSolit);
            this.Win10SettingsPanel.Controls.Add(this.checkBoxSetDefaultPhoto);
            this.Win10SettingsPanel.Controls.Add(this.checkBoxDeleteAppPhotos);
            this.Win10SettingsPanel.Controls.Add(this.checkBoxSPYTasks);
            this.Win10SettingsPanel.Controls.Add(this.checkBoxDeleteAppPhone);
            this.Win10SettingsPanel.Controls.Add(this.checkBoxDeleteWindows10Apps);
            this.Win10SettingsPanel.Controls.Add(this.checkBoxDeleteAppPeopleOneNote);
            this.Win10SettingsPanel.Controls.Add(this.checkBoxDeleteApp3d);
            this.Win10SettingsPanel.Controls.Add(this.checkBoxDeleteAppZune);
            this.Win10SettingsPanel.Controls.Add(this.checkBoxDeleteAppCamera);
            this.Win10SettingsPanel.Controls.Add(this.checkBoxDeleteAppBing);
            this.Win10SettingsPanel.Controls.Add(this.checkBoxDeleteMailCalendarMaps);
            this.Win10SettingsPanel.Location = new System.Drawing.Point(6, 3);
            this.Win10SettingsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.Win10SettingsPanel.Name = "Win10SettingsPanel";
            this.Win10SettingsPanel.Size = new System.Drawing.Size(434, 365);
            this.Win10SettingsPanel.TabIndex = 22;
            // 
            // checkBoxCreateSystemRestorePoint
            // 
            this.checkBoxCreateSystemRestorePoint.AutoSize = true;
            this.checkBoxCreateSystemRestorePoint.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxCreateSystemRestorePoint.Checked = true;
            this.checkBoxCreateSystemRestorePoint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCreateSystemRestorePoint.Location = new System.Drawing.Point(3, 3);
            this.checkBoxCreateSystemRestorePoint.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxCreateSystemRestorePoint.Name = "checkBoxCreateSystemRestorePoint";
            this.checkBoxCreateSystemRestorePoint.Size = new System.Drawing.Size(161, 17);
            this.checkBoxCreateSystemRestorePoint.TabIndex = 0;
            this.checkBoxCreateSystemRestorePoint.Text = "Create system restore point";
            this.checkBoxCreateSystemRestorePoint.UseVisualStyleBackColor = false;
            // 
            // checkBoxKeyLoggerAndTelemetry
            // 
            this.checkBoxKeyLoggerAndTelemetry.AutoSize = true;
            this.checkBoxKeyLoggerAndTelemetry.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxKeyLoggerAndTelemetry.Checked = true;
            this.checkBoxKeyLoggerAndTelemetry.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxKeyLoggerAndTelemetry.Location = new System.Drawing.Point(3, 20);
            this.checkBoxKeyLoggerAndTelemetry.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxKeyLoggerAndTelemetry.Name = "checkBoxKeyLoggerAndTelemetry";
            this.checkBoxKeyLoggerAndTelemetry.Size = new System.Drawing.Size(177, 17);
            this.checkBoxKeyLoggerAndTelemetry.TabIndex = 1;
            this.checkBoxKeyLoggerAndTelemetry.Text = "Delete keylogger and telemetry";
            this.checkBoxKeyLoggerAndTelemetry.UseVisualStyleBackColor = false;
            // 
            // checkBoxAddToHosts
            // 
            this.checkBoxAddToHosts.AutoSize = true;
            this.checkBoxAddToHosts.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAddToHosts.Checked = true;
            this.checkBoxAddToHosts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAddToHosts.Location = new System.Drawing.Point(3, 37);
            this.checkBoxAddToHosts.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxAddToHosts.Name = "checkBoxAddToHosts";
            this.checkBoxAddToHosts.Size = new System.Drawing.Size(314, 17);
            this.checkBoxAddToHosts.TabIndex = 2;
            this.checkBoxAddToHosts.Text = "Add spy domains to hosts file, and block in Windows Firewall\r\n";
            this.checkBoxAddToHosts.UseVisualStyleBackColor = false;
            // 
            // labelInfoDeleteMetroApps
            // 
            this.labelInfoDeleteMetroApps.AutoSize = true;
            this.labelInfoDeleteMetroApps.BackColor = System.Drawing.Color.Transparent;
            this.labelInfoDeleteMetroApps.ForeColor = System.Drawing.Color.Red;
            this.labelInfoDeleteMetroApps.Location = new System.Drawing.Point(3, 343);
            this.labelInfoDeleteMetroApps.Name = "labelInfoDeleteMetroApps";
            this.labelInfoDeleteMetroApps.Size = new System.Drawing.Size(396, 13);
            this.labelInfoDeleteMetroApps.TabIndex = 20;
            this.labelInfoDeleteMetroApps.Text = "METRO applications are deleted permanently, without the possibility of recovery.";
            // 
            // checkBoxDeleteAppXBOX
            // 
            this.checkBoxDeleteAppXBOX.AutoSize = true;
            this.checkBoxDeleteAppXBOX.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDeleteAppXBOX.Checked = true;
            this.checkBoxDeleteAppXBOX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDeleteAppXBOX.Enabled = false;
            this.checkBoxDeleteAppXBOX.Location = new System.Drawing.Point(3, 309);
            this.checkBoxDeleteAppXBOX.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDeleteAppXBOX.Name = "checkBoxDeleteAppXBOX";
            this.checkBoxDeleteAppXBOX.Size = new System.Drawing.Size(84, 17);
            this.checkBoxDeleteAppXBOX.TabIndex = 18;
            this.checkBoxDeleteAppXBOX.Text = "Delete XBoX";
            this.checkBoxDeleteAppXBOX.UseVisualStyleBackColor = false;
            // 
            // checkBoxDisablePrivateSettings
            // 
            this.checkBoxDisablePrivateSettings.AutoSize = true;
            this.checkBoxDisablePrivateSettings.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDisablePrivateSettings.Checked = true;
            this.checkBoxDisablePrivateSettings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDisablePrivateSettings.Location = new System.Drawing.Point(3, 54);
            this.checkBoxDisablePrivateSettings.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDisablePrivateSettings.Name = "checkBoxDisablePrivateSettings";
            this.checkBoxDisablePrivateSettings.Size = new System.Drawing.Size(138, 17);
            this.checkBoxDisablePrivateSettings.TabIndex = 3;
            this.checkBoxDisablePrivateSettings.Text = "Disable private settings";
            this.checkBoxDisablePrivateSettings.UseVisualStyleBackColor = false;
            // 
            // checkBoxDeleteAppVoice
            // 
            this.checkBoxDeleteAppVoice.AutoSize = true;
            this.checkBoxDeleteAppVoice.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDeleteAppVoice.Checked = true;
            this.checkBoxDeleteAppVoice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDeleteAppVoice.Enabled = false;
            this.checkBoxDeleteAppVoice.Location = new System.Drawing.Point(3, 292);
            this.checkBoxDeleteAppVoice.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDeleteAppVoice.Name = "checkBoxDeleteAppVoice";
            this.checkBoxDeleteAppVoice.Size = new System.Drawing.Size(132, 17);
            this.checkBoxDeleteAppVoice.TabIndex = 17;
            this.checkBoxDeleteAppVoice.Text = "Delete Voice Recorder";
            this.checkBoxDeleteAppVoice.UseVisualStyleBackColor = false;
            // 
            // checkBoxDisableWindowsDefender
            // 
            this.checkBoxDisableWindowsDefender.AutoSize = true;
            this.checkBoxDisableWindowsDefender.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDisableWindowsDefender.Checked = true;
            this.checkBoxDisableWindowsDefender.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDisableWindowsDefender.Location = new System.Drawing.Point(3, 71);
            this.checkBoxDisableWindowsDefender.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDisableWindowsDefender.Name = "checkBoxDisableWindowsDefender";
            this.checkBoxDisableWindowsDefender.Size = new System.Drawing.Size(151, 17);
            this.checkBoxDisableWindowsDefender.TabIndex = 4;
            this.checkBoxDisableWindowsDefender.Text = "Disable windows defender";
            this.checkBoxDisableWindowsDefender.UseVisualStyleBackColor = false;
            // 
            // checkBoxDeleteAppSolit
            // 
            this.checkBoxDeleteAppSolit.AutoSize = true;
            this.checkBoxDeleteAppSolit.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDeleteAppSolit.Checked = true;
            this.checkBoxDeleteAppSolit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDeleteAppSolit.Enabled = false;
            this.checkBoxDeleteAppSolit.Location = new System.Drawing.Point(3, 275);
            this.checkBoxDeleteAppSolit.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDeleteAppSolit.Name = "checkBoxDeleteAppSolit";
            this.checkBoxDeleteAppSolit.Size = new System.Drawing.Size(147, 17);
            this.checkBoxDeleteAppSolit.TabIndex = 16;
            this.checkBoxDeleteAppSolit.Text = "Delete Solitaire Collection";
            this.checkBoxDeleteAppSolit.UseVisualStyleBackColor = false;
            // 
            // checkBoxSetDefaultPhoto
            // 
            this.checkBoxSetDefaultPhoto.AutoSize = true;
            this.checkBoxSetDefaultPhoto.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxSetDefaultPhoto.Checked = true;
            this.checkBoxSetDefaultPhoto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSetDefaultPhoto.Location = new System.Drawing.Point(3, 88);
            this.checkBoxSetDefaultPhoto.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxSetDefaultPhoto.Name = "checkBoxSetDefaultPhoto";
            this.checkBoxSetDefaultPhoto.Size = new System.Drawing.Size(189, 17);
            this.checkBoxSetDefaultPhoto.TabIndex = 5;
            this.checkBoxSetDefaultPhoto.Text = "Set default windows photo viewer";
            this.checkBoxSetDefaultPhoto.UseVisualStyleBackColor = false;
            // 
            // checkBoxDeleteAppPhotos
            // 
            this.checkBoxDeleteAppPhotos.AutoSize = true;
            this.checkBoxDeleteAppPhotos.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDeleteAppPhotos.Checked = true;
            this.checkBoxDeleteAppPhotos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDeleteAppPhotos.Enabled = false;
            this.checkBoxDeleteAppPhotos.Location = new System.Drawing.Point(3, 258);
            this.checkBoxDeleteAppPhotos.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDeleteAppPhotos.Name = "checkBoxDeleteAppPhotos";
            this.checkBoxDeleteAppPhotos.Size = new System.Drawing.Size(93, 17);
            this.checkBoxDeleteAppPhotos.TabIndex = 15;
            this.checkBoxDeleteAppPhotos.Text = "Delete Photos";
            this.checkBoxDeleteAppPhotos.UseVisualStyleBackColor = false;
            // 
            // checkBoxSPYTasks
            // 
            this.checkBoxSPYTasks.AutoSize = true;
            this.checkBoxSPYTasks.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxSPYTasks.Checked = true;
            this.checkBoxSPYTasks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSPYTasks.Location = new System.Drawing.Point(3, 105);
            this.checkBoxSPYTasks.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxSPYTasks.Name = "checkBoxSPYTasks";
            this.checkBoxSPYTasks.Size = new System.Drawing.Size(109, 17);
            this.checkBoxSPYTasks.TabIndex = 6;
            this.checkBoxSPYTasks.Text = "Disable SPY tasks";
            this.checkBoxSPYTasks.UseVisualStyleBackColor = false;
            // 
            // checkBoxDeleteAppPhone
            // 
            this.checkBoxDeleteAppPhone.AutoSize = true;
            this.checkBoxDeleteAppPhone.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDeleteAppPhone.Checked = true;
            this.checkBoxDeleteAppPhone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDeleteAppPhone.Enabled = false;
            this.checkBoxDeleteAppPhone.Location = new System.Drawing.Point(3, 241);
            this.checkBoxDeleteAppPhone.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDeleteAppPhone.Name = "checkBoxDeleteAppPhone";
            this.checkBoxDeleteAppPhone.Size = new System.Drawing.Size(146, 17);
            this.checkBoxDeleteAppPhone.TabIndex = 14;
            this.checkBoxDeleteAppPhone.Text = "Delete Phone Companion";
            this.checkBoxDeleteAppPhone.UseVisualStyleBackColor = false;
            // 
            // checkBoxDeleteWindows10Apps
            // 
            this.checkBoxDeleteWindows10Apps.AutoSize = true;
            this.checkBoxDeleteWindows10Apps.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDeleteWindows10Apps.Location = new System.Drawing.Point(3, 122);
            this.checkBoxDeleteWindows10Apps.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDeleteWindows10Apps.Name = "checkBoxDeleteWindows10Apps";
            this.checkBoxDeleteWindows10Apps.Size = new System.Drawing.Size(173, 17);
            this.checkBoxDeleteWindows10Apps.TabIndex = 7;
            this.checkBoxDeleteWindows10Apps.Text = "Delete windows 10 metro apps";
            this.checkBoxDeleteWindows10Apps.UseVisualStyleBackColor = false;
            this.checkBoxDeleteWindows10Apps.CheckedChanged += new System.EventHandler(this.checkBoxDeleteWindows10Apps_CheckedChanged);
            // 
            // checkBoxDeleteAppPeopleOneNote
            // 
            this.checkBoxDeleteAppPeopleOneNote.AutoSize = true;
            this.checkBoxDeleteAppPeopleOneNote.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDeleteAppPeopleOneNote.Checked = true;
            this.checkBoxDeleteAppPeopleOneNote.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDeleteAppPeopleOneNote.Enabled = false;
            this.checkBoxDeleteAppPeopleOneNote.Location = new System.Drawing.Point(3, 224);
            this.checkBoxDeleteAppPeopleOneNote.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDeleteAppPeopleOneNote.Name = "checkBoxDeleteAppPeopleOneNote";
            this.checkBoxDeleteAppPeopleOneNote.Size = new System.Drawing.Size(159, 17);
            this.checkBoxDeleteAppPeopleOneNote.TabIndex = 13;
            this.checkBoxDeleteAppPeopleOneNote.Text = "Delete People and OneNote";
            this.checkBoxDeleteAppPeopleOneNote.UseVisualStyleBackColor = false;
            // 
            // checkBoxDeleteApp3d
            // 
            this.checkBoxDeleteApp3d.AutoSize = true;
            this.checkBoxDeleteApp3d.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDeleteApp3d.Checked = true;
            this.checkBoxDeleteApp3d.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDeleteApp3d.Enabled = false;
            this.checkBoxDeleteApp3d.Location = new System.Drawing.Point(3, 139);
            this.checkBoxDeleteApp3d.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDeleteApp3d.Name = "checkBoxDeleteApp3d";
            this.checkBoxDeleteApp3d.Size = new System.Drawing.Size(108, 17);
            this.checkBoxDeleteApp3d.TabIndex = 8;
            this.checkBoxDeleteApp3d.Text = "Delete Builder 3D";
            this.checkBoxDeleteApp3d.UseVisualStyleBackColor = false;
            // 
            // checkBoxDeleteAppZune
            // 
            this.checkBoxDeleteAppZune.AutoSize = true;
            this.checkBoxDeleteAppZune.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDeleteAppZune.Checked = true;
            this.checkBoxDeleteAppZune.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDeleteAppZune.Enabled = false;
            this.checkBoxDeleteAppZune.Location = new System.Drawing.Point(3, 207);
            this.checkBoxDeleteAppZune.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDeleteAppZune.Name = "checkBoxDeleteAppZune";
            this.checkBoxDeleteAppZune.Size = new System.Drawing.Size(184, 17);
            this.checkBoxDeleteAppZune.TabIndex = 12;
            this.checkBoxDeleteAppZune.Text = "Delete Groove Music and Film TV ";
            this.checkBoxDeleteAppZune.UseVisualStyleBackColor = false;
            // 
            // checkBoxDeleteAppCamera
            // 
            this.checkBoxDeleteAppCamera.AutoSize = true;
            this.checkBoxDeleteAppCamera.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDeleteAppCamera.Checked = true;
            this.checkBoxDeleteAppCamera.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDeleteAppCamera.Enabled = false;
            this.checkBoxDeleteAppCamera.Location = new System.Drawing.Point(3, 156);
            this.checkBoxDeleteAppCamera.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDeleteAppCamera.Name = "checkBoxDeleteAppCamera";
            this.checkBoxDeleteAppCamera.Size = new System.Drawing.Size(97, 17);
            this.checkBoxDeleteAppCamera.TabIndex = 9;
            this.checkBoxDeleteAppCamera.Text = "Delete Camera";
            this.checkBoxDeleteAppCamera.UseVisualStyleBackColor = false;
            // 
            // checkBoxDeleteAppBing
            // 
            this.checkBoxDeleteAppBing.AutoSize = true;
            this.checkBoxDeleteAppBing.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDeleteAppBing.Checked = true;
            this.checkBoxDeleteAppBing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDeleteAppBing.Enabled = false;
            this.checkBoxDeleteAppBing.Location = new System.Drawing.Point(3, 190);
            this.checkBoxDeleteAppBing.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDeleteAppBing.Name = "checkBoxDeleteAppBing";
            this.checkBoxDeleteAppBing.Size = new System.Drawing.Size(229, 17);
            this.checkBoxDeleteAppBing.TabIndex = 11;
            this.checkBoxDeleteAppBing.Text = "Delete Money, Sports, News and Weather";
            this.checkBoxDeleteAppBing.UseVisualStyleBackColor = false;
            // 
            // checkBoxDeleteMailCalendarMaps
            // 
            this.checkBoxDeleteMailCalendarMaps.AutoSize = true;
            this.checkBoxDeleteMailCalendarMaps.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDeleteMailCalendarMaps.Checked = true;
            this.checkBoxDeleteMailCalendarMaps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDeleteMailCalendarMaps.Enabled = false;
            this.checkBoxDeleteMailCalendarMaps.Location = new System.Drawing.Point(3, 173);
            this.checkBoxDeleteMailCalendarMaps.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDeleteMailCalendarMaps.Name = "checkBoxDeleteMailCalendarMaps";
            this.checkBoxDeleteMailCalendarMaps.Size = new System.Drawing.Size(174, 17);
            this.checkBoxDeleteMailCalendarMaps.TabIndex = 10;
            this.checkBoxDeleteMailCalendarMaps.Text = "Delete Mail,Calendar and Maps";
            this.checkBoxDeleteMailCalendarMaps.UseVisualStyleBackColor = false;
            // 
            // btnProfessionalMode
            // 
            this.btnProfessionalMode.AutoSize = true;
            this.btnProfessionalMode.ForeColor = System.Drawing.Color.Red;
            this.btnProfessionalMode.Location = new System.Drawing.Point(6, 371);
            this.btnProfessionalMode.Name = "btnProfessionalMode";
            this.btnProfessionalMode.Size = new System.Drawing.Size(113, 17);
            this.btnProfessionalMode.TabIndex = 21;
            this.btnProfessionalMode.Text = "Professional mode";
            this.btnProfessionalMode.UseVisualStyleBackColor = true;
            this.btnProfessionalMode.CheckedChanged += new System.EventHandler(this.btnProfessionalMode_Click);
            // 
            // tabPageUtilites
            // 
            this.tabPageUtilites.BackColor = System.Drawing.Color.White;
            this.tabPageUtilites.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageUtilites.Controls.Add(this.btnFixRotateScreen);
            this.tabPageUtilites.Controls.Add(this.btnDisableOfficeUpdate);
            this.tabPageUtilites.Controls.Add(this.btnRemoveOldFirewallRules);
            this.tabPageUtilites.Controls.Add(this.btnDeleteOneDrive);
            this.tabPageUtilites.Controls.Add(this.btnDeleteMetroAppsInfo);
            this.tabPageUtilites.Controls.Add(this.groupBoxWindowsUpdate);
            this.tabPageUtilites.Controls.Add(this.groupBoxUACEdit);
            this.tabPageUtilites.Controls.Add(this.btnOpenAndEditHosts);
            this.tabPageUtilites.Controls.Add(this.btnRestoreSystem);
            this.tabPageUtilites.Controls.Add(this.btnDeleteAllWindows10Apps);
            this.tabPageUtilites.Location = new System.Drawing.Point(4, 22);
            this.tabPageUtilites.Name = "tabPageUtilites";
            this.tabPageUtilites.Size = new System.Drawing.Size(445, 400);
            this.tabPageUtilites.TabIndex = 2;
            this.tabPageUtilites.Text = "Utilites";
            // 
            // btnFixRotateScreen
            // 
            this.btnFixRotateScreen.BackColor = System.Drawing.Color.Transparent;
            this.btnFixRotateScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFixRotateScreen.Location = new System.Drawing.Point(14, 176);
            this.btnFixRotateScreen.Name = "btnFixRotateScreen";
            this.btnFixRotateScreen.Size = new System.Drawing.Size(202, 23);
            this.btnFixRotateScreen.TabIndex = 11;
            this.btnFixRotateScreen.Text = "Fix screen rotate";
            this.btnFixRotateScreen.UseVisualStyleBackColor = false;
            this.btnFixRotateScreen.Click += new System.EventHandler(this.btnFixRotateScreen_Click);
            // 
            // btnDisableOfficeUpdate
            // 
            this.btnDisableOfficeUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnDisableOfficeUpdate.BackgroundImage = global::DWS_Lite.Properties.Resources.warning;
            this.btnDisableOfficeUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDisableOfficeUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisableOfficeUpdate.Location = new System.Drawing.Point(14, 147);
            this.btnDisableOfficeUpdate.Name = "btnDisableOfficeUpdate";
            this.btnDisableOfficeUpdate.Size = new System.Drawing.Size(202, 23);
            this.btnDisableOfficeUpdate.TabIndex = 6;
            this.btnDisableOfficeUpdate.Text = "Disable Office 2016 Telemetry";
            this.btnDisableOfficeUpdate.UseVisualStyleBackColor = false;
            this.btnDisableOfficeUpdate.Click += new System.EventHandler(this.btnDisableOfficeUpdate_Click);
            // 
            // btnRemoveOldFirewallRules
            // 
            this.btnRemoveOldFirewallRules.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveOldFirewallRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveOldFirewallRules.ForeColor = System.Drawing.Color.Green;
            this.btnRemoveOldFirewallRules.Location = new System.Drawing.Point(223, 147);
            this.btnRemoveOldFirewallRules.Name = "btnRemoveOldFirewallRules";
            this.btnRemoveOldFirewallRules.Size = new System.Drawing.Size(214, 23);
            this.btnRemoveOldFirewallRules.TabIndex = 6;
            this.btnRemoveOldFirewallRules.Text = "Remove all old DWS firewall rules";
            this.btnRemoveOldFirewallRules.UseVisualStyleBackColor = false;
            this.btnRemoveOldFirewallRules.Click += new System.EventHandler(this.btnRemoveOldFirewallRules_Click);
            // 
            // btnDeleteOneDrive
            // 
            this.btnDeleteOneDrive.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteOneDrive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOneDrive.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteOneDrive.Location = new System.Drawing.Point(223, 32);
            this.btnDeleteOneDrive.Name = "btnDeleteOneDrive";
            this.btnDeleteOneDrive.Size = new System.Drawing.Size(214, 23);
            this.btnDeleteOneDrive.TabIndex = 10;
            this.btnDeleteOneDrive.Text = "Delete One Drive";
            this.btnDeleteOneDrive.UseVisualStyleBackColor = false;
            this.btnDeleteOneDrive.Click += new System.EventHandler(this.btnDeleteOneDrive_Click);
            // 
            // btnDeleteMetroAppsInfo
            // 
            this.btnDeleteMetroAppsInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteMetroAppsInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMetroAppsInfo.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteMetroAppsInfo.Location = new System.Drawing.Point(199, 32);
            this.btnDeleteMetroAppsInfo.Name = "btnDeleteMetroAppsInfo";
            this.btnDeleteMetroAppsInfo.Size = new System.Drawing.Size(23, 23);
            this.btnDeleteMetroAppsInfo.TabIndex = 9;
            this.btnDeleteMetroAppsInfo.Text = "?";
            this.btnDeleteMetroAppsInfo.UseVisualStyleBackColor = false;
            this.btnDeleteMetroAppsInfo.Click += new System.EventHandler(this.btnDeleteMetroAppsInfo_Click);
            // 
            // groupBoxWindowsUpdate
            // 
            this.groupBoxWindowsUpdate.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxWindowsUpdate.Controls.Add(this.btnEnableWindowsUpdate);
            this.groupBoxWindowsUpdate.Controls.Add(this.btnDisableWindowsUpdate);
            this.groupBoxWindowsUpdate.Location = new System.Drawing.Point(223, 61);
            this.groupBoxWindowsUpdate.Name = "groupBoxWindowsUpdate";
            this.groupBoxWindowsUpdate.Size = new System.Drawing.Size(214, 80);
            this.groupBoxWindowsUpdate.TabIndex = 8;
            this.groupBoxWindowsUpdate.TabStop = false;
            this.groupBoxWindowsUpdate.Text = "Windows Update";
            // 
            // btnEnableWindowsUpdate
            // 
            this.btnEnableWindowsUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnEnableWindowsUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnableWindowsUpdate.Location = new System.Drawing.Point(6, 20);
            this.btnEnableWindowsUpdate.Name = "btnEnableWindowsUpdate";
            this.btnEnableWindowsUpdate.Size = new System.Drawing.Size(202, 23);
            this.btnEnableWindowsUpdate.TabIndex = 4;
            this.btnEnableWindowsUpdate.Text = "Enable Windows Update";
            this.btnEnableWindowsUpdate.UseVisualStyleBackColor = false;
            this.btnEnableWindowsUpdate.Click += new System.EventHandler(this.btnEnableWindowsUpdate_Click);
            // 
            // btnDisableWindowsUpdate
            // 
            this.btnDisableWindowsUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnDisableWindowsUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisableWindowsUpdate.Location = new System.Drawing.Point(6, 49);
            this.btnDisableWindowsUpdate.Name = "btnDisableWindowsUpdate";
            this.btnDisableWindowsUpdate.Size = new System.Drawing.Size(202, 23);
            this.btnDisableWindowsUpdate.TabIndex = 5;
            this.btnDisableWindowsUpdate.Text = "Disable Windows Update";
            this.btnDisableWindowsUpdate.UseVisualStyleBackColor = false;
            this.btnDisableWindowsUpdate.Click += new System.EventHandler(this.btnDisableWindowsUpdate_Click);
            // 
            // groupBoxUACEdit
            // 
            this.groupBoxUACEdit.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxUACEdit.Controls.Add(this.btnEnableUac);
            this.groupBoxUACEdit.Controls.Add(this.btnDisableUac);
            this.groupBoxUACEdit.Location = new System.Drawing.Point(8, 61);
            this.groupBoxUACEdit.Name = "groupBoxUACEdit";
            this.groupBoxUACEdit.Size = new System.Drawing.Size(214, 80);
            this.groupBoxUACEdit.TabIndex = 7;
            this.groupBoxUACEdit.TabStop = false;
            this.groupBoxUACEdit.Text = "UAC";
            // 
            // btnEnableUac
            // 
            this.btnEnableUac.BackColor = System.Drawing.Color.Transparent;
            this.btnEnableUac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnableUac.Location = new System.Drawing.Point(6, 20);
            this.btnEnableUac.Name = "btnEnableUac";
            this.btnEnableUac.Size = new System.Drawing.Size(202, 23);
            this.btnEnableUac.TabIndex = 2;
            this.btnEnableUac.Text = "Enable UAC";
            this.btnEnableUac.UseVisualStyleBackColor = false;
            this.btnEnableUac.Click += new System.EventHandler(this.btnEnableUac_Click);
            // 
            // btnDisableUac
            // 
            this.btnDisableUac.BackColor = System.Drawing.Color.Transparent;
            this.btnDisableUac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisableUac.Location = new System.Drawing.Point(6, 49);
            this.btnDisableUac.Name = "btnDisableUac";
            this.btnDisableUac.Size = new System.Drawing.Size(202, 23);
            this.btnDisableUac.TabIndex = 3;
            this.btnDisableUac.Text = "Disable UAC";
            this.btnDisableUac.UseVisualStyleBackColor = false;
            this.btnDisableUac.Click += new System.EventHandler(this.btnDisableUac_Click);
            // 
            // btnOpenAndEditHosts
            // 
            this.btnOpenAndEditHosts.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenAndEditHosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenAndEditHosts.Location = new System.Drawing.Point(8, 3);
            this.btnOpenAndEditHosts.Name = "btnOpenAndEditHosts";
            this.btnOpenAndEditHosts.Size = new System.Drawing.Size(214, 23);
            this.btnOpenAndEditHosts.TabIndex = 6;
            this.btnOpenAndEditHosts.Text = "Open and edit HOSTS file";
            this.btnOpenAndEditHosts.UseVisualStyleBackColor = false;
            this.btnOpenAndEditHosts.Click += new System.EventHandler(this.btnOpenAndEditHosts_Click);
            // 
            // btnRestoreSystem
            // 
            this.btnRestoreSystem.BackColor = System.Drawing.Color.Transparent;
            this.btnRestoreSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreSystem.Location = new System.Drawing.Point(223, 3);
            this.btnRestoreSystem.Name = "btnRestoreSystem";
            this.btnRestoreSystem.Size = new System.Drawing.Size(214, 23);
            this.btnRestoreSystem.TabIndex = 1;
            this.btnRestoreSystem.Text = "Restore System";
            this.btnRestoreSystem.UseVisualStyleBackColor = false;
            this.btnRestoreSystem.Click += new System.EventHandler(this.btnRestoreSystem_Click);
            // 
            // btnDeleteAllWindows10Apps
            // 
            this.btnDeleteAllWindows10Apps.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteAllWindows10Apps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAllWindows10Apps.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteAllWindows10Apps.Location = new System.Drawing.Point(8, 32);
            this.btnDeleteAllWindows10Apps.Name = "btnDeleteAllWindows10Apps";
            this.btnDeleteAllWindows10Apps.Size = new System.Drawing.Size(191, 23);
            this.btnDeleteAllWindows10Apps.TabIndex = 0;
            this.btnDeleteAllWindows10Apps.Text = "Delete all windows 10 metro apps";
            this.btnDeleteAllWindows10Apps.UseVisualStyleBackColor = false;
            this.btnDeleteAllWindows10Apps.Click += new System.EventHandler(this.btnDeleteAllWindows10Apps_Click);
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.BackColor = System.Drawing.Color.White;
            this.tabPageAbout.BackgroundImage = global::DWS_Lite.Properties.Resources.BGProgImg;
            this.tabPageAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageAbout.Controls.Add(this.linkLabelSourceCode);
            this.tabPageAbout.Controls.Add(this.linkLabel6);
            this.tabPageAbout.Controls.Add(this.linkLabel1);
            this.tabPageAbout.Controls.Add(this.groupBoxLanguage);
            this.tabPageAbout.Controls.Add(this.linkLabel3);
            this.tabPageAbout.Controls.Add(this.labelMoonInfo);
            this.tabPageAbout.Location = new System.Drawing.Point(4, 22);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Size = new System.Drawing.Size(445, 400);
            this.tabPageAbout.TabIndex = 3;
            this.tabPageAbout.Text = "About";
            // 
            // linkLabelSourceCode
            // 
            this.linkLabelSourceCode.AutoSize = true;
            this.linkLabelSourceCode.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelSourceCode.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLabelSourceCode.Location = new System.Drawing.Point(321, 36);
            this.linkLabelSourceCode.Name = "linkLabelSourceCode";
            this.linkLabelSourceCode.Size = new System.Drawing.Size(116, 13);
            this.linkLabelSourceCode.TabIndex = 8;
            this.linkLabelSourceCode.TabStop = true;
            this.linkLabelSourceCode.Text = "Source code on GitHub";
            this.linkLabelSourceCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSourceCode_LinkClicked);
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel6.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLabel6.Location = new System.Drawing.Point(364, 77);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(73, 13);
            this.linkLabel6.TabIndex = 9;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "dws.wzor.net";
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(371, 56);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(66, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "@nummerok";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBoxLanguage
            // 
            this.groupBoxLanguage.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxLanguage.Controls.Add(this.comboBoxLanguageSelect);
            this.groupBoxLanguage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBoxLanguage.Location = new System.Drawing.Point(8, 3);
            this.groupBoxLanguage.Name = "groupBoxLanguage";
            this.groupBoxLanguage.Size = new System.Drawing.Size(214, 54);
            this.groupBoxLanguage.TabIndex = 12;
            this.groupBoxLanguage.TabStop = false;
            this.groupBoxLanguage.Text = "Language\\Язык";
            // 
            // comboBoxLanguageSelect
            // 
            this.comboBoxLanguageSelect.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxLanguageSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguageSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxLanguageSelect.FormattingEnabled = true;
            this.comboBoxLanguageSelect.Items.AddRange(new object[] {
            "ar-LY | Arabic",
            "cs-CZ | Czech",
            "de-DE | German",
            "en-US | English",
            "es-ES | Spanish",
            "fr-FR | French",
            "it-CH | Italian",
            "ja-JP | 日本語",
            "lt-LT | Lithuanian",
            "nl-NL | Dutch",
            "pl-PL | Polish",
            "pt-BR | Portuguese",
            "ru-RU | Русский",
            "tr-TR | Turkish",
            "uk-UA | Українська",
            "zh-CN | 中文(简体)"});
            this.comboBoxLanguageSelect.Location = new System.Drawing.Point(6, 20);
            this.comboBoxLanguageSelect.Name = "comboBoxLanguageSelect";
            this.comboBoxLanguageSelect.Size = new System.Drawing.Size(202, 21);
            this.comboBoxLanguageSelect.TabIndex = 0;
            this.comboBoxLanguageSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguageSelect_SelectedIndexChanged);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLabel3.Location = new System.Drawing.Point(267, 20);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(175, 13);
            this.linkLabel3.TabIndex = 4;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Best windows activator (KMS Auto)";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // labelMoonInfo
            // 
            this.labelMoonInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelMoonInfo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMoonInfo.ForeColor = System.Drawing.Color.White;
            this.labelMoonInfo.Location = new System.Drawing.Point(173, 0);
            this.labelMoonInfo.Name = "labelMoonInfo";
            this.labelMoonInfo.Size = new System.Drawing.Size(272, 33);
            this.labelMoonInfo.TabIndex = 6;
            this.labelMoonInfo.Text = "Сделано на другой стороне луны ®";
            this.labelMoonInfo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabPageReadMe
            // 
            this.tabPageReadMe.Controls.Add(this.ReadmeRichTextBox);
            this.tabPageReadMe.Location = new System.Drawing.Point(4, 22);
            this.tabPageReadMe.Name = "tabPageReadMe";
            this.tabPageReadMe.Size = new System.Drawing.Size(445, 400);
            this.tabPageReadMe.TabIndex = 4;
            this.tabPageReadMe.Text = "ReadME";
            this.tabPageReadMe.UseVisualStyleBackColor = true;
            // 
            // ReadmeRichTextBox
            // 
            this.ReadmeRichTextBox.BackColor = System.Drawing.Color.White;
            this.ReadmeRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReadmeRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReadmeRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.ReadmeRichTextBox.Name = "ReadmeRichTextBox";
            this.ReadmeRichTextBox.ReadOnly = true;
            this.ReadmeRichTextBox.Size = new System.Drawing.Size(445, 400);
            this.ReadmeRichTextBox.TabIndex = 0;
            this.ReadmeRichTextBox.Text = "";
            // 
            // CaptionWindow
            // 
            this.CaptionWindow.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CaptionWindow.Dock = System.Windows.Forms.DockStyle.Top;
            this.CaptionWindow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CaptionWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CaptionWindow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CaptionWindow.Location = new System.Drawing.Point(0, 0);
            this.CaptionWindow.Name = "CaptionWindow";
            this.CaptionWindow.Size = new System.Drawing.Size(453, 28);
            this.CaptionWindow.TabIndex = 1;
            this.CaptionWindow.Text = "       DWS Lite";
            this.CaptionWindow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CaptionWindow.Click += new System.EventHandler(this.CaptionWindow_Click);
            this.CaptionWindow.Paint += new System.Windows.Forms.PaintEventHandler(this.CaptionWindow_Paint);
            this.CaptionWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CaptionWindow_MouseDown);
            // 
            // _CloseButton
            // 
            this._CloseButton.BackColor = System.Drawing.Color.White;
            this._CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._CloseButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._CloseButton.Location = new System.Drawing.Point(423, 1);
            this._CloseButton.Name = "_CloseButton";
            this._CloseButton.Size = new System.Drawing.Size(29, 29);
            this._CloseButton.TabIndex = 2;
            this._CloseButton.TabStop = false;
            this._CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this._CloseButton.Paint += new System.Windows.Forms.PaintEventHandler(this.CloseButton_Paint);
            this._CloseButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseDown);
            this._CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this._CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MinimizeButton.Location = new System.Drawing.Point(395, 1);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(29, 29);
            this.MinimizeButton.TabIndex = 3;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            this.MinimizeButton.Paint += new System.Windows.Forms.PaintEventHandler(this.MinimizeButton_Paint);
            this.MinimizeButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MinimizeButton_MouseDown);
            this.MinimizeButton.MouseEnter += new System.EventHandler(this.MinimizeButton_MouseEnter);
            this.MinimizeButton.MouseLeave += new System.EventHandler(this.MinimizeButton_MouseLeave);
            // 
            // BorderUP
            // 
            this.BorderUP.BackColor = System.Drawing.Color.Cyan;
            this.BorderUP.Location = new System.Drawing.Point(-7, 0);
            this.BorderUP.Name = "BorderUP";
            this.BorderUP.Size = new System.Drawing.Size(480, 1);
            this.BorderUP.TabIndex = 4;
            this.BorderUP.TabStop = false;
            // 
            // BorderDown
            // 
            this.BorderDown.BackColor = System.Drawing.Color.Cyan;
            this.BorderDown.Location = new System.Drawing.Point(-14, 456);
            this.BorderDown.Name = "BorderDown";
            this.BorderDown.Size = new System.Drawing.Size(480, 1);
            this.BorderDown.TabIndex = 5;
            this.BorderDown.TabStop = false;
            // 
            // BorderLeft
            // 
            this.BorderLeft.BackColor = System.Drawing.Color.Cyan;
            this.BorderLeft.Location = new System.Drawing.Point(0, -8);
            this.BorderLeft.Name = "BorderLeft";
            this.BorderLeft.Size = new System.Drawing.Size(1, 500);
            this.BorderLeft.TabIndex = 6;
            this.BorderLeft.TabStop = false;
            // 
            // BorderR
            // 
            this.BorderR.BackColor = System.Drawing.Color.Cyan;
            this.BorderR.Location = new System.Drawing.Point(452, -22);
            this.BorderR.Name = "BorderR";
            this.BorderR.Size = new System.Drawing.Size(1, 500);
            this.BorderR.TabIndex = 7;
            this.BorderR.TabStop = false;
            // 
            // MainDwsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(453, 457);
            this.Controls.Add(this.BorderLeft);
            this.Controls.Add(this.BorderDown);
            this.Controls.Add(this.BorderR);
            this.Controls.Add(this.BorderUP);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this._CloseButton);
            this.Controls.Add(this.CaptionWindow);
            this.Controls.Add(this.FormTabsControl);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainDwsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "       DWS (final version)";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.Activated += new System.EventHandler(this.DestroyWindowsSpyingMainForm_Activated);
            this.Deactivate += new System.EventHandler(this.DestroyWindowsSpyingMainForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DestroyWindowsSpyingMainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DestroyWindowsSpyingMainForm_FormClosed);
            this.FormTabsControl.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            this.Windows78Panel.ResumeLayout(false);
            this.Windows78Panel.PerformLayout();
            this.Win10SettingsPanel.ResumeLayout(false);
            this.Win10SettingsPanel.PerformLayout();
            this.tabPageUtilites.ResumeLayout(false);
            this.groupBoxWindowsUpdate.ResumeLayout(false);
            this.groupBoxUACEdit.ResumeLayout(false);
            this.tabPageAbout.ResumeLayout(false);
            this.tabPageAbout.PerformLayout();
            this.groupBoxLanguage.ResumeLayout(false);
            this.tabPageReadMe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl FormTabsControl;
        private TabPage tabPageMain;
        private TabPage tabPageSettings;
        private TabPage tabPageUtilites;
        private TabPage tabPageAbout;
        private ProgressBar ProgressBarStatus;
        private Button btnDestroyWindowsSpying;
        private Label StatusCommandsLable;
        private RichTextBox LogOutputTextBox;
        private CheckBox checkBoxCreateSystemRestorePoint;
        private CheckBox checkBoxKeyLoggerAndTelemetry;
        private CheckBox checkBoxAddToHosts;
        private CheckBox checkBoxDisablePrivateSettings;
        private CheckBox checkBoxDisableWindowsDefender;
        private CheckBox checkBoxSetDefaultPhoto;
        private CheckBox checkBoxSPYTasks;
        private CheckBox checkBoxDeleteWindows10Apps;
        private Button btnDeleteAllWindows10Apps;
        private CheckBox checkBoxDeleteApp3d;
        private CheckBox checkBoxDeleteAppXBOX;
        private CheckBox checkBoxDeleteAppVoice;
        private CheckBox checkBoxDeleteAppSolit;
        private CheckBox checkBoxDeleteAppPhotos;
        private CheckBox checkBoxDeleteAppPhone;
        private CheckBox checkBoxDeleteAppPeopleOneNote;
        private CheckBox checkBoxDeleteAppZune;
        private CheckBox checkBoxDeleteAppBing;
        private CheckBox checkBoxDeleteMailCalendarMaps;
        private CheckBox checkBoxDeleteAppCamera;
        private Button btnDisableUac;
        private Button btnEnableUac;
        private Button btnRestoreSystem;
        private Button btnDisableWindowsUpdate;
        private Button btnEnableWindowsUpdate;
        private Button btnOpenAndEditHosts;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel1;
        private Label labelMoonInfo;
        private GroupBox groupBoxWindowsUpdate;
        private GroupBox groupBoxUACEdit;
        private Button btnDeleteMetroAppsInfo;
        private Button btnDeleteOneDrive;
        private Label labelInfoDeleteMetroApps;
        private TabPage tabPageReadMe;
        private LinkLabel linkLabelSourceCode;
        private Button btnRemoveOldFirewallRules;
        private GroupBox groupBoxLanguage;
        private ComboBox comboBoxLanguageSelect;
        private Button btnDestroyWindows78Spy;
        private RichTextBox ReadmeRichTextBox;
        private LinkLabel linkLabel6;
        private CheckBox btnProfessionalMode;
        private Button btnDisableOfficeUpdate;
        private Label CaptionWindow;
        private PictureBox _CloseButton;
        private PictureBox MinimizeButton;
        private PictureBox BorderUP;
        private PictureBox BorderDown;
        private PictureBox BorderLeft;
        private PictureBox BorderR;
        private Panel Win10SettingsPanel;
        private Panel Windows78Panel;
        private CheckBox checkBoxAddToHosts78;
        private CheckBox checkBoxSPYTasks78;
        private CheckBox checkBoxDeleteWindows78Updates;
        private CheckBox checkBoxDeleteGWX;
        private CheckedListBox checkedListBoxUpdatesW78;
        private Label labelUninstallUpdates;
        private CheckBox checkBoxDelKeyloggerTW78;
        private Button btnFixRotateScreen;
    }
}

