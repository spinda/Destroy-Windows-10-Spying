using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using DWS_Lite.lib;

namespace DWS_Lite
{


    public partial class DestroyWindowsSpyingMainForm : Form
    {

        private ResourceManager rm;
        private string path = Path.GetPathRoot(Environment.SystemDirectory);
        private string ShellCmdLocation = null;
        private string system32location = null;
        private string logfilename = "DWS.log";

        public DestroyWindowsSpyingMainForm(string[] args)
        {
            InitializeComponent();

            // Re create log file
            FileUtil.RecreateLogFile(logfilename);
            // Check windows version
            CheckWindowsVersion();
            //Check SYSNATIVE (x64)
            setShellSys32Paths();

            CheckEnableOrDisableUAC();

            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            this.Text += Properties.Resources.build_number;
            labelBuildDataTime.Text = "Build number:" + Properties.Resources.build_number + "  |  Build Time:" +
                                      Properties.Resources.build_datatime;

            SetLanguage(getLang(args));
            ChangeLanguage();

        }

        private string getLang(string[] args)
        {
            string langname = null;
            // check args lang
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].IndexOf("/lang=") > -1)
                {
                    langname = args[i].Replace("/lang=", null);
                }
            }
            return langname;
        }

        private void setShellSys32Paths()
        {
            if (File.Exists(path + @"Windows\Sysnative\cmd.exe"))
            {
                ShellCmdLocation = path + @"Windows\Sysnative\cmd.exe";
                system32location = path + @"Windows\System32\";
            }
            else
            {
                ShellCmdLocation = path + @"Windows\System32\cmd.exe";
                system32location = path + @"Windows\System32\";
            }
        }
        private void CheckWindowsVersion()
        {
            int WindowsBuildNumber = WindowsUtil.getWindowsBuildNumber();


            if (WindowsBuildNumber < 7600)
            {
                MessageBox.Show("Minimum windows version - 7", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Process.GetCurrentProcess().Kill();
            }

            // check Win 7 or 8.1
            if (WindowsBuildNumber < 10000)
            {
                tabPageUtilites.Enabled = false;
                tabPageSettings.Enabled = false;
                btnDestroyWindowsSpying.Visible = false;
                btnDestroyWindows78Spy.Visible = true;
            }
            //------------------------------------------

        }
        void SetLanguage(string currentlang = null)
        {
            if (currentlang == null)
            {
                currentlang = CultureInfo.CurrentUICulture.Name.ToLower();
            }
            if (currentlang.IndexOf("ru") > -1)
            {
                rm = lang.ru_RU.ResourceManager;
                comboBoxLanguageSelect.Text = "ru-RU | Русский";
            }
            else if (currentlang.IndexOf("fr") > -1)
            {
                rm = lang.fr_FR.ResourceManager;
                comboBoxLanguageSelect.Text = "fr-FR | French";
            }
            else if (currentlang.IndexOf("es") > -1)
            {
                rm = lang.es_ES.ResourceManager;
                comboBoxLanguageSelect.Text = "es-ES | Spanish";
            }
            else
            {
                rm = lang.en_US.ResourceManager;
                comboBoxLanguageSelect.Text = "en-US | English";
            }
        }

        void ChangeLanguage()
        {
            tabPageMain.Text = GetTranslateText("tabPageMain");
            tabPageAbout.Text = GetTranslateText("tabPageAbout");
            tabPageReadMe.Text = GetTranslateText("tabPageReadMe");
            tabPageSettings.Text = GetTranslateText("tabPageSettings");
            tabPageUtilites.Text = GetTranslateText("tabPageUtilites");
            btnDeleteAllWindows10Apps.Text = GetTranslateText("btnDeleteAllWindows10Apps");
            btnDeleteOneDrive.Text = GetTranslateText("btnDeleteOneDrive");
            btnOpenAndEditHosts.Text = GetTranslateText("btnOpenAndEditHosts");
            btnProfessionalMode.Text = GetTranslateText("btnProfessionalMode");
            btnRestoreSystem.Text = GetTranslateText("btnRestoreSystem");
            checkBoxAddToHosts.Text = GetTranslateText("checkBoxAddToHosts");
            checkBoxCreateSystemRestorePoint.Text = GetTranslateText("checkBoxCreateSystemRestorePoint");
            checkBoxDeleteWindows10Apps.Text = GetTranslateText("checkBoxDeleteWindows10Apps");
            checkBoxDisablePrivateSettings.Text = GetTranslateText("checkBoxDisablePrivateSettings");
            checkBoxDisableWindowsDefender.Text = GetTranslateText("checkBoxDisableWindowsDefender");
            checkBoxKeyLoggerAndTelemetry.Text = GetTranslateText("checkBoxKeyLoggerAndTelemetry");
            checkBoxSetDefaultPhoto.Text = GetTranslateText("checkBoxSetDefaultPhoto");
            checkBoxSPYTasks.Text = GetTranslateText("checkBoxSPYTasks");
            labelInfoDeleteMetroApps.Text = GetTranslateText("labelInfoDeleteMetroApps");
            btnEnableUac.Text = GetTranslateText("Enable") + " UAC";
            btnDisableUac.Text = GetTranslateText("Disable") + " UAC";
            btnDisableWindowsUpdate.Text = GetTranslateText("Disable") + " Windows Update";
            btnEnableWindowsUpdate.Text = GetTranslateText("Enable") + " Windows Update";
            checkBoxDeleteApp3d.Text = GetTranslateText("Delete") + " Builder 3D";
            checkBoxDeleteAppCamera.Text = GetTranslateText("Delete") + " Camera";
            checkBoxDeleteMailCalendarMaps.Text = GetTranslateText("Delete") + " Mail, Calendar, Maps";
            checkBoxDeleteAppBing.Text = GetTranslateText("Delete") + " Money, Sports, News, Weather";
            checkBoxDeleteAppZune.Text = GetTranslateText("Delete") + " Groove Music, Film TV";
            checkBoxDeleteAppPeopleOneNote.Text = GetTranslateText("Delete") + " People, OneNote";
            checkBoxDeleteAppPhone.Text = GetTranslateText("Delete") + " Phone Companion";
            checkBoxDeleteAppPhotos.Text = GetTranslateText("Delete") + " Photos";
            checkBoxDeleteAppSolit.Text = GetTranslateText("Delete") + " Solitaire Collection";
            checkBoxDeleteAppVoice.Text = GetTranslateText("Delete") + " Voice Recorder";
            checkBoxDeleteAppXBOX.Text = GetTranslateText("Delete") + " XBOX";
            btnRemoveOldFirewallRules.Text = GetTranslateText("RemoveAllOldFirewallRules");
            btnReportABug.Text = GetTranslateText("ReportABug");
            groupBoxLinks.Text = GetTranslateText("Links");
        }

        string GetTranslateText(string name)
        {
            try
            {
                return rm.GetString(name);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private void CheckEnableOrDisableUAC()
        {
            //SetRegValueHKLM(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", "EnableLUA", "1", RegistryValueKind.DWord);

            if (WindowsUtil.isLUAEnabled())
            {
                btnEnableUac.Enabled = true;
                btnDisableUac.Enabled = false;
            }
            else
            {
                btnEnableUac.Enabled = false;
                btnDisableUac.Enabled = true;
            }

            if (WindowsUtil.isSystemRestoreEnabled() == 0)
            {
                checkBoxCreateSystemRestorePoint.Checked = false;
                checkBoxCreateSystemRestorePoint.Enabled = false;
            }

        }

        private void btnDestroyWindowsSpying_Click(object sender, EventArgs e)
        {
            StartDestroyWindowsSpying();
        }

        private void output(string str, bool split = false)
        {
            try
            {
                Invoke(new MethodInvoker(delegate
                {
                    outputnoinvoke(str, split);
                }));
            }
            catch (Exception)
            {
                try
                {
                    outputnoinvoke(str, split);
                }
                catch (Exception)
                {
                    fatalerrors++;
                }
            }
        }

        private void progressbaradd(int numberadd)
        {
            try
            {
                Invoke(new MethodInvoker(delegate
                {
                    try
                    {
                        ProgressBarStatus.Value += numberadd;
                    }
                    catch (Exception)
                    {

                    }
                }));
            }
            catch (Exception)
            {
                try
                {
                    ProgressBarStatus.Value += numberadd;
                }
                catch (Exception)
                {

                }
            }
        }

        private void outputnoinvoke(string str, bool split = false)
        {
            DateTime temp = DateTime.Now;
            str = "[" + temp.Hour.ToString() + ":" + temp.Minute.ToString() + ":" + temp.Second.ToString() + "] " + str;
            File.WriteAllText(logfilename, File.ReadAllText(logfilename) + str + "\n");
            Console.WriteLine(str);
            LogOutputTextBox.Text += str + "\n";
            if (split)
            {

                File.WriteAllText(logfilename, File.ReadAllText(logfilename) + "==========================\n");
                Console.WriteLine("==========================");
                LogOutputTextBox.Text += "==========================\n";
            }
        }

        private void EnableOrDisableTab(bool enableordisable)
        {
            try
            {
                Invoke(new MethodInvoker(delegate
                {
                    btnDestroyWindowsSpying.Enabled = enableordisable;
                    tabPageSettings.Enabled = enableordisable;
                    tabPageUtilites.Enabled = enableordisable;
                }));
            }
            catch (Exception)
            {
                tabPageMain.Enabled = enableordisable;
                tabPageSettings.Enabled = enableordisable;
                tabPageUtilites.Enabled = enableordisable;
            }
        }

        private string ProcStartargs(string name, string args)
        {
            try
            {
                var proc = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = name,
                        Arguments = args,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true,
                        StandardOutputEncoding = Encoding.GetEncoding(866)
                    }
                };
                proc.Start();
                string line = null;
                while (!proc.StandardOutput.EndOfStream)
                {
                    line += "\n" + proc.StandardOutput.ReadLine();
                }
                return line;
            }
            catch (Exception ex)
            {
                fatalerrors++;
                return ex.ToString();
            }
        }

        private void CreateRestorePoint(string description)
        {
            ManagementScope oScope = new ManagementScope("\\\\localhost\\root\\default");
            ManagementPath oPath = new ManagementPath("SystemRestore");
            ObjectGetOptions oGetOp = new ObjectGetOptions();
            ManagementClass oProcess = new ManagementClass(oScope, oPath, oGetOp);

            ManagementBaseObject oInParams =
                oProcess.GetMethodParameters("CreateRestorePoint");
            oInParams["Description"] = description;
            oInParams["RestorePointType"] = 12; // MODIFY_SETTINGS
            oInParams["EventType"] = 100;

            ManagementBaseObject oOutParams =
                oProcess.InvokeMethod("CreateRestorePoint", oInParams, null);
        }


        private string getwindowsbuildorversion()
        {

            // в value массив из байт
            string value = "Product Name: " + WindowsUtil.getSystemProductName() + "\n";
            value += "  Build: " + WindowsUtil.getSystemBuild();
            return value;

        }




        private void SetRegValueHKCU(string regkeyfolder, string paramname, string paramvalue,
            Microsoft.Win32.RegistryValueKind keytype)
        {
            try
            {
                RegistryKey myKey = Registry.CurrentUser.OpenSubKey(regkeyfolder, true);
                if (myKey != null)
                {
                    myKey.SetValue(paramname, paramvalue, keytype);
                    myKey.Close();
                }
            }
            catch (Exception ex)
            {
                fatalerrors++;
                output(GetTranslateText("Error") + ": " + ex.Message);
            }
        }

        private void DeleteWindows10MetroApp(string appname)
        {
            ProcStartargs("powershell", "-command \"Get-AppxPackage *" + appname + "* | Remove-AppxPackage\"");
        }

        private void SetRegValueHKLM(string regkeyfolder, string paramname, string paramvalue,
            Microsoft.Win32.RegistryValueKind keytype)
        {
            try
            {
                RegistryKey myKey = Registry.LocalMachine.OpenSubKey(regkeyfolder, true);
                if (myKey != null)
                {
                    myKey.SetValue(paramname, paramvalue, keytype);
                    myKey.Close();
                }
            }
            catch (Exception ex)
            {
                fatalerrors++;
                output(GetTranslateText("Error") + ": " + ex.Message);
            }
        }

        private void LogOutputTextBox_TextChanged(object sender, EventArgs e)
        {
            LogOutputTextBox.SelectionStart = LogOutputTextBox.Text.Length;
            LogOutputTextBox.ScrollToCaret();
        }

        // ----- fatalerrors -----
        private int fatalerrors = 0;
        // ------ end ------

        private void StartDestroyWindowsSpying()
        {
            EnableOrDisableTab(false);
            setcompletetext(true);
            output("Starting: " + DateTime.Now.ToString() + ".");
            output(getwindowsbuildorversion());
            output("=====================================");
            fatalerrors = 0;
            ProgressBarStatus.Value = 0;
            new Thread(() =>
            {
                DWSThread();
            }).Start();
        }

        private void DWSThread()
        {
            if (checkBoxCreateSystemRestorePoint.Checked)
            {
                try
                {
                    string restorepoint_name = "DestroyWindowsSpying " + DateTime.Now.ToString();
                    output("Creating restore point " + restorepoint_name + "...");
                    CreateRestorePoint(restorepoint_name);
                    output("Restore point " + restorepoint_name + " created.");
                }
                catch (Exception ex)
                {
                    output("Error creating restore point.");
                }
            }
            progressbaradd(10);
            if (checkBoxKeyLoggerAndTelemetry.Checked)
            {
                // DISABLE TELEMETRY
                output("Disable telemetry...");
                ProcessUtil.RunCmd("/c net stop DiagTrack ");
                ProcessUtil.RunCmd("/c net stop diagnosticshub.standardcollector.service ");
                ProcessUtil.RunCmd("/c net stop dmwappushservice ");
                ProcessUtil.RunCmd("/c net stop WMPNetworkSvc ");
                ProcessUtil.RunCmd("/c sc config DiagTrack start=disabled ");
                ProcessUtil.RunCmd("/c sc config diagnosticshub.standardcollector.service start=disabled ");
                ProcessUtil.RunCmd("/c sc config dmwappushservice start=disabled ");
                ProcessUtil.RunCmd("/c sc config WMPNetworkSvc start=disabled ");
                ProcessUtil.RunCmd("/c REG ADD HKLM\\SYSTEM\\ControlSet001\\Control\\WMI\\AutoLogger\\AutoLogger-Diagtrack-Listener /v Start /t REG_DWORD /d 0 /f");
                ProcessUtil.RunCmd("/c net stop dmwappushservice");
                ProcessUtil.RunCmd("/c net stop diagtrack");
                ProcessUtil.RunCmd("/c sc delete dmwappushsvc");
                ProcessUtil.RunCmd("/c sc delete \"Diagnostics Tracking Service\"");
                ProcessUtil.RunCmd("/c sc delete diagtrack");
                ProcessUtil.RunCmd("/c reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Device Metadata\" /v \"PreventDeviceMetadataFromNetwork\" /t REG_DWORD /d 1 /f ");
                ProcessUtil.RunCmd("/c reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\DataCollection\" /v \"AllowTelemetry\" /t REG_DWORD /d 0 /f ");
                ProcessUtil.RunCmd("/c reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\MRT\" /v \"DontOfferThroughWUAU\" /t REG_DWORD /d 1 /f ");
                ProcessUtil.RunCmd("/c reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\SQMClient\\Windows\" /v \"CEIPEnable\" /t REG_DWORD /d 0 /f ");
                ProcessUtil.RunCmd("/c reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat\" /v \"AITEnable\" /t REG_DWORD /d 0 /f ");
                ProcessUtil.RunCmd("/c reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat\" /v \"DisableUAR\" /t REG_DWORD /d 1 /f ");
                ProcessUtil.RunCmd("/c reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection\" /v \"AllowTelemetry\" /t REG_DWORD /d 0 /f ");
                ProcessUtil.RunCmd("/c reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\WMI\\AutoLogger\\AutoLogger-Diagtrack-Listener\" /v \"Start\" /t REG_DWORD /d 0 /f ");
                ProcessUtil.RunCmd("/c reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\WMI\\AutoLogger\\SQMLogger\" /v \"Start\" /t REG_DWORD /d 0 /f ");
                ProcessUtil.RunCmd("/c reg add \"HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Siuf\\Rules\" /v \"NumberOfSIUFInPeriod\" /t REG_DWORD /d 0 /f ");
                ProcessUtil.RunCmd("/c reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat\" /v \"DisableUAR\" /t REG_DWORD /d 1 /f ");
                ProcessUtil.RunCmd("/c reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\SQMClient\\Windows\" /v \"CEIPEnable\" /t REG_DWORD /d 0 /f ");
                ProcessUtil.RunCmd("/c reg delete \"HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Siuf\\Rules\" /v \"PeriodInNanoSeconds\" /f ");
                // DELETE KEYLOGGER
                output("Delete keylogger...");
            }
            progressbaradd(15); //25
            if (checkBoxAddToHosts.Checked)
            {
                disablehostsandaddfirewall();
            }
            progressbaradd(20); //45
            if (checkBoxDisablePrivateSettings.Checked)
            {

                SetRegValueHKCU(
                    @"SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{21157C1F-2651-4CC1-90CA-1F28B02263F6}",
                    "Value", "Deny", RegistryValueKind.String);
                SetRegValueHKCU(
                    @"SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{2EEF81BE-33FA-4800-9670-1CD474972C3F}",
                    "Value", "Deny", RegistryValueKind.String);
                SetRegValueHKCU(
                    @"SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{7D7E8402-7C54-4821-A34E-AEEFD62DED93}",
                    "Value", "Deny", RegistryValueKind.String);
                SetRegValueHKCU(
                    @"SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{992AFA70-6F47-4148-B3E9-3003349C1548}",
                    "Value", "Deny", RegistryValueKind.String);
                SetRegValueHKCU(
                    @"SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{9D9E0118-1807-4F2E-96E4-2CE57142E196}",
                    "Value", "Deny", RegistryValueKind.String);
                SetRegValueHKCU(
                    @"SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{A8804298-2D5F-42E3-9531-9C8C39EB29CE}",
                    "Value", "Deny", RegistryValueKind.String);
                SetRegValueHKCU(
                    @"SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{B19F89AF-E3EB-444B-8DEA-202575A71599}",
                    "Value", "Deny", RegistryValueKind.String);
                SetRegValueHKCU(
                    @"SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{BFA794E4-F964-4FDB-90F6-51056BFE4B44}",
                    "Value", "Deny", RegistryValueKind.String);
                SetRegValueHKCU(
                    @"SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{C1D23ACC-752B-43E5-8448-8D0E519CD6D6}",
                    "Value", "Deny", RegistryValueKind.String);
                SetRegValueHKCU(
                    @"SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{D89823BA-7180-4B81-B50C-7E471E6121A3}",
                    "Value", "Deny", RegistryValueKind.String);
                SetRegValueHKCU(
                    @"SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{E5323777-F976-4f5b-9B55-B94699C46E44}",
                    "Value", "Deny", RegistryValueKind.String);
                SetRegValueHKCU(
                    @"SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{E6AD100E-5F4E-44CD-BE0F-2265D88D14F5}",
                    "Value", "Deny", RegistryValueKind.String);
                SetRegValueHKCU(
                    @"SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{E83AF229-8640-4D18-A213-E22675EBB2C3}",
                    "Value", "Deny", RegistryValueKind.String);
                SetRegValueHKCU(@"SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\LooselyCoupled",
                    "Value", "Deny", RegistryValueKind.String);
                output("Disable private settings");
                SetRegValueHKCU(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Search", "CortanaEnabled", "0",
                    RegistryValueKind.DWord);
                SetRegValueHKCU(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Search", "BingSearchEnabled", "0",
                    RegistryValueKind.DWord);
            }
            progressbaradd(10); //55
            if (checkBoxDisableWindowsDefender.Checked)
            {
                SetRegValueHKLM(@"SOFTWARE\Policies\Microsoft\Windows Defender", "DisableAntiSpyware", "1",
                    RegistryValueKind.DWord);
                output("Disable Windows Defender.");
            }
            progressbaradd(5); //60
            if (checkBoxSetDefaultPhoto.Checked)
            {
                SetRegValueHKCU(@"Software\Classes\.ico", null, "PhotoViewer.FileAssoc.Tiff", RegistryValueKind.String);
                SetRegValueHKCU(@"Software\Classes\.tiff", null, "PhotoViewer.FileAssoc.Tiff", RegistryValueKind.String);
                SetRegValueHKCU(@"Software\Classes\.bmp", null, "PhotoViewer.FileAssoc.Tiff", RegistryValueKind.String);
                SetRegValueHKCU(@"Software\Classes\.png", null, "PhotoViewer.FileAssoc.Tiff", RegistryValueKind.String);
                SetRegValueHKCU(@"Software\Classes\.gif", null, "PhotoViewer.FileAssoc.Tiff", RegistryValueKind.String);
                SetRegValueHKCU(@"Software\Classes\.jpeg", null, "PhotoViewer.FileAssoc.Tiff", RegistryValueKind.String);
                SetRegValueHKCU(@"Software\Classes\.jpg", null, "PhotoViewer.FileAssoc.Tiff", RegistryValueKind.String);
                output("Set Default PhotoViewer");
            }
            progressbaradd(10); //70
            if (checkBoxSPYTasks.Checked)
            {
                disablespytasks();
            }
            progressbaradd(10); //80
            if (checkBoxDeleteWindows10Apps.Checked)
            {
                RemoveWindows10Apps();
            }
            progressbaradd(20); //100
            EnableOrDisableTab(true);
            try
            {
                Invoke(new MethodInvoker(delegate
                {
                    setcompletetext();
                }));
            }
            catch (Exception)
            {
                try
                {
                    setcompletetext();
                }
                catch (Exception)
                {

                }
            }
        }

        private void setcompletetext(bool start = false)
        {
            if (start)
            {
                StatusCommandsLable.Text = "Destroy Windows 10 Spying";
                StatusCommandsLable.ForeColor = Color.Black;
            }
            else
            {
                if (fatalerrors == 0)
                {
                    StatusCommandsLable.Text = "Destroy Windows 10 Spying - " + GetTranslateText("Complete") + "!";
                    StatusCommandsLable.ForeColor = Color.DarkGreen;
                    if (
                        MessageBox.Show(GetTranslateText("CompleteMSG"), GetTranslateText("Info"),
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                        DialogResult.Yes)
                    {
                        Process.Start("shutdown.exe", "-r -t 0");
                    }
                }
                else
                {
                    StatusCommandsLable.Text = "Destroy Windows 10 Spying - errors: " + fatalerrors.ToString();
                    StatusCommandsLable.ForeColor = Color.Red;
                    if (
                        MessageBox.Show(string.Format(GetTranslateText("ErrorMSG"), fatalerrors), GetTranslateText("Info"),
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                        DialogResult.Yes)
                    {
                        Process.Start("shutdown.exe", "-r -t 0");
                    }
                }
            }
        }


        void disablespytasks()
        {


            string[] disabletaskslist =
                {
                    @"Microsoft\Office\Office ClickToRun Service Monitor",
                    @"Microsoft\Office\OfficeTelemetryAgentFallBack2016",
                    @"Microsoft\Office\OfficeTelemetryAgentLogOn2016",
                    @"Microsoft\Windows\Customer Experience Improvement Program\KernelCeipTask",
                    @"Microsoft\Windows\Customer Experience Improvement Program\UsbCeip",
                    @"Microsoft\Windows\Power Efficiency Diagnostics\AnalyzeSystem",
                    @"Microsoft\Windows\Shell\FamilySafetyMonitor",
                    @"Microsoft\Windows\Shell\FamilySafetyRefresh",
                    @"Microsoft\Windows\Application Experience\AitAgent",
                    @"Microsoft\Windows\Application Experience\ProgramDataUpdater",
                    @"Microsoft\Windows\Application Experience\StartupAppTask",
                    @"Microsoft\Windows\Autochk\Proxy",
                    @"Microsoft\Windows\Customer Experience Improvement Program\BthSQM",
                    @"Microsoft\Windows\Customer Experience Improvement Program\Consolidator",
                    @"Microsoft\Office\OfficeTelemetry\AgentFallBack2016",
                    @"Microsoft\Office\OfficeTelemetry\OfficeTelemetryAgentLogOn2016",
                    @"Microsoft\Windows\Application Experience\Microsoft Compatibility Appraiser",
                    @"Microsoft\Windows\DiskDiagnostic\Microsoft-Windows-DiskDiagnosticDataCollector",
                    @"Microsoft\Windows\Maintenance\WinSAT",
                    @"Microsoft\Windows\Media Center\ActivateWindowsSearch",
                    @"Microsoft\Windows\Media Center\ConfigureInternetTimeService",
                    @"Microsoft\Windows\Media Center\DispatchRecoveryTasks",
                    @"Microsoft\Windows\Media Center\ehDRMInit",
                    @"Microsoft\Windows\Media Center\InstallPlayReady",
                    @"Microsoft\Windows\Media Center\mcupdate",
                    @"Microsoft\Windows\Media Center\MediaCenterRecoveryTask",
                    @"Microsoft\Windows\Media Center\ObjectStoreRecoveryTask",
                    @"Microsoft\Windows\Media Center\OCURActivate",
                    @"Microsoft\Windows\Media Center\OCURDiscovery",
                    @"Microsoft\Windows\Media Center\PBDADiscovery",
                    @"Microsoft\Windows\Media Center\PBDADiscoveryW1",
                    @"Microsoft\Windows\Media Center\PBDADiscoveryW2",
                    @"Microsoft\Windows\Media Center\PvrRecoveryTask",
                    @"Microsoft\Windows\Media Center\PvrScheduleTask",
                    @"Microsoft\Windows\Media Center\RegisterSearch",
                    @"Microsoft\Windows\Media Center\ReindexSearchRoot",
                    @"Microsoft\Windows\Media Center\SqlLiteRecoveryTask",
                    @"Microsoft\Windows\Media Center\UpdateRecordPath"
                };
            for (int i = 0; i < disabletaskslist.Length; i++)
            {
                ProcStartargs("SCHTASKS", "/Change /TN \"" + disabletaskslist[i] + "\" /disable");
                output("Disabled task: " + disabletaskslist[i]);
            }
        }

        // Win 7/8.1 
        void disablehostsandaddfirewall()
        {
            try
            {
                string hostslocation = system32location + @"drivers\etc\hosts";
                string hosts = null;
                if (File.Exists(hostslocation))
                {
                    hosts = File.ReadAllText(hostslocation);
                    File.SetAttributes(hostslocation, FileAttributes.Normal);
                    FileUtil.DeleteFile(hostslocation);
                }
                File.Create(hostslocation).Close();
                File.WriteAllText(hostslocation, hosts + "\r\n");
                for (int i = 0; i < HostsDomains.hostsdomains.Length; i++)
                {
                    if (hosts.IndexOf(HostsDomains.hostsdomains[i]) == -1)
                    {
                        ProcStartargs(ShellCmdLocation,
                            "/c echo " + "0.0.0.0 " + HostsDomains.hostsdomains[i] + " >> \"" + hostslocation +
                            "\"");
                        output("Add to hosts - " + HostsDomains.hostsdomains[i]);
                    }
                }
            }
            catch (Exception)
            {
                fatalerrors++;
                output("Error add HOSTS");
            }
            ProcessUtil.RunCmd("/c ipconfig /flushdns");

            output("Add hosts MS complete.");
            ProcessUtil.RunCmd("/c netsh advfirewall firewall delete rule name=\"MS Spynet block\"");
            ProcessUtil.RunCmd("/c netsh advfirewall firewall add rule name=\"MS Spynet block\" dir=out interface=any action=block remoteip=23.96.0.0/13");
            output("Add Windows Firewall rule: \"MS Spynet block\"");
            ProcessUtil.RunCmd("/c route -p add 23.218.212.69 MASK 255.255.255.255 0.0.0.0");
            ProcessUtil.RunCmd("/c route -p add 65.55.108.23 MASK 255.255.255.255 0.0.0.0");
            ProcessUtil.RunCmd("/c route -p add 65.39.117.230 MASK 255.255.255.255 0.0.0.0");
            ProcessUtil.RunCmd("/c route -p add 134.170.30.202 MASK 255.255.255.255 0.0.0.0");
            ProcessUtil.RunCmd("/c route -p add 137.116.81.24 MASK 255.255.255.255 0.0.0.0");
            ProcessUtil.RunCmd("/c route -p add 204.79.197.200 MASK 255.255.255.255 0.0.0.0");
            ProcessUtil.RunCmd("/c route -p add 23.218.212.69 MASK 255.255.255.255 0.0.0.0");

        }

        private void RemoveWindows10Apps()
        {
            if (checkBoxDeleteApp3d.Checked)
            {
                DeleteWindows10MetroApp("3d");
                output("Delete builder 3D");
            }
            if (checkBoxDeleteAppCamera.Checked)
            {
                DeleteWindows10MetroApp("camera");
                output("Delete Camera");
            }
            if (checkBoxDeleteMailCalendarMaps.Checked)
            {
                DeleteWindows10MetroApp("communi");
                DeleteWindows10MetroApp("maps");
                output("Delete Mail, Calendar, Maps");
            }
            if (checkBoxDeleteAppBing.Checked)
            {
                DeleteWindows10MetroApp("bing");
                output("Delete Money, Sports, News and Weather");
            }
            if (checkBoxDeleteAppZune.Checked)
            {
                DeleteWindows10MetroApp("zune");
                output("Delete Groove Music and Film TV");
            }
            if (checkBoxDeleteAppPeopleOneNote.Checked)
            {
                DeleteWindows10MetroApp("people");
                DeleteWindows10MetroApp("note");
                output("Delete People and OneNote");
            }
            if (checkBoxDeleteAppPhone.Checked)
            {
                DeleteWindows10MetroApp("phone");
                output("Delete Phone Companion");
            }
            if (checkBoxDeleteAppPhotos.Checked)
            {
                DeleteWindows10MetroApp("photo");
                output("Delete Photos");
            }
            if (checkBoxDeleteAppSolit.Checked)
            {
                DeleteWindows10MetroApp("solit");
                output("Delete Solitaire Collection");
            }
            if (checkBoxDeleteAppVoice.Checked)
            {
                DeleteWindows10MetroApp("soundrec");
                output("Delete Voice Recorder");
            }
            if (checkBoxDeleteAppXBOX.Checked)
            {
                DeleteWindows10MetroApp("xbox");
                output("Delete XBOX");
            }

        }


        private void checkBoxDeleteWindows10Apps_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxDeleteApp3d.Enabled = checkBoxDeleteWindows10Apps.Checked;
            checkBoxDeleteAppBing.Enabled = checkBoxDeleteWindows10Apps.Checked;
            checkBoxDeleteAppCamera.Enabled = checkBoxDeleteWindows10Apps.Checked;
            checkBoxDeleteAppPeopleOneNote.Enabled = checkBoxDeleteWindows10Apps.Checked;
            checkBoxDeleteAppPhone.Enabled = checkBoxDeleteWindows10Apps.Checked;
            checkBoxDeleteAppPhotos.Enabled = checkBoxDeleteWindows10Apps.Checked;
            checkBoxDeleteAppSolit.Enabled = checkBoxDeleteWindows10Apps.Checked;
            checkBoxDeleteAppVoice.Enabled = checkBoxDeleteWindows10Apps.Checked;
            checkBoxDeleteAppXBOX.Enabled = checkBoxDeleteWindows10Apps.Checked;
            checkBoxDeleteAppZune.Enabled = checkBoxDeleteWindows10Apps.Checked;
            checkBoxDeleteMailCalendarMaps.Enabled = checkBoxDeleteWindows10Apps.Checked;
        }

        private void btnDeleteAllWindows10Apps_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(GetTranslateText("Really"), GetTranslateText("Question"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                EnableOrDisableTab(false);
                MessageBox.Show(GetTranslateText("PressOkAndWait15"));
                new Thread(() =>
                {
                    DeleteWindows10MetroApp(null);
                    Invoke(new MethodInvoker(delegate
                    {
                        EnableOrDisableTab(true);
                        MessageBox.Show(GetTranslateText("Complete"), GetTranslateText("Info"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }));
                }).Start();
            }
            else
            {
                MessageBox.Show("=(", "%(");
            }
        }

        private void btnRestoreSystem_Click(object sender, EventArgs e)
        {
            Process.Start(system32location + "rstrui.exe");
        }

        private void btnEnableUac_Click(object sender, EventArgs e)
        {
            SetRegValueHKLM(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System\", "EnableLUA", "1",
                RegistryValueKind.DWord);
            output("Enable UAC");
            CheckEnableOrDisableUAC();
            if (
                MessageBox.Show(GetTranslateText("CompleteMSG"), GetTranslateText("Info"), MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process.Start("shutdown.exe", "-r -t 0");
            }
        }

        private void btnDisableUac_Click(object sender, EventArgs e)
        {
            SetRegValueHKLM(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System\", "EnableLUA", "0",
                RegistryValueKind.DWord);
            output("Disable UAC");
            CheckEnableOrDisableUAC();
            if (
                MessageBox.Show(GetTranslateText("CompleteMSG"), GetTranslateText("Info"), MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process.Start("shutdown.exe", "-r -t 0");
            }
        }

        private void btnEnableWindowsUpdate_Click(object sender, EventArgs e)
        {
            ProcStartargs("powershell", "-command \"Set-Service -Name wuauserv -StartupType Automatic\"");
            ProcessUtil.RunCmd("/c net start wuauserv");
            output("Windows Update enabled");
        }

        private void btnDisableWindowsUpdate_Click(object sender, EventArgs e)
        {
            ProcessUtil.RunCmd("/c net stop wuauserv");
            ProcStartargs("powershell", "-command \"Set-Service -Name wuauserv -StartupType Disabled\"");
            output("Windows Update disabled");
        }

        private void btnOpenAndEditHosts_Click(object sender, EventArgs e)
        {
            output(ProcStartargs("notepad", system32location + @"drivers\etc\hosts"));
        }

        private void DestroyWindowsSpyingMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void DestroyWindowsSpyingMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://goo.gl/EpFSzj");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://goo.gl/fxEkcl");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://goo.gl/CDaZye");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://goo.gl/uzXaHM");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://goo.gl/sZIfQD");
        }

        private bool professionalmode = false;

        private void btnProfessionalMode_Click(object sender, EventArgs e)
        {
            professionalmode = !professionalmode;
            ProfessionalModeSet(professionalmode);
        }

        private void ProfessionalModeSet(bool enableordisable)
        {
            checkBoxCreateSystemRestorePoint.Visible = enableordisable;
            checkBoxKeyLoggerAndTelemetry.Visible = enableordisable;
            checkBoxAddToHosts.Visible = enableordisable;
            checkBoxDisablePrivateSettings.Visible = enableordisable;
            checkBoxDisableWindowsDefender.Visible = enableordisable;
            checkBoxSetDefaultPhoto.Visible = enableordisable;
            checkBoxSPYTasks.Visible = enableordisable;
            btnDeleteAllWindows10Apps.Visible = enableordisable;
            groupBoxUACEdit.Visible = enableordisable;
            btnDeleteMetroAppsInfo.Visible = enableordisable;
            btnDeleteOneDrive.Visible = enableordisable;
            if (enableordisable)
            {
                this.Text += "  !Professional mode!";
                btnProfessionalMode.Text = btnProfessionalMode.Text.Replace("Enable", "Disable");
            }
            else
            {
                this.Text = this.Text.Replace("  !Professional mode!", null);
                btnProfessionalMode.Text = btnProfessionalMode.Text.Replace("Disable", "Enable");
            }
        }

        private void linkLabelOtherThanks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Чёрная поганка, Архангел", "Thanks");
        }

        private void btnDeleteMetroAppsInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete apps: Calculator, Windows Store, Windows Feedback, and other METRO apps.", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeleteOneDrive_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                EnableOrDisableTab(false);
                try
                {
                    output(
                        ProcessUtil.RunCmd("/c taskkill /f /im OneDrive.exe > NUL 2>&1"));
                    output(
                        ProcessUtil.RunCmd("/c ping 127.0.0.1 -n 5 > NUL 2>&1"));
                    if (File.Exists(path + @"Windows\System32\OneDriveSetup.exe"))
                    {

                        output(
                            ProcStartargs(path + @"Windows\System32\OneDriveSetup.exe", "/uninstall"));
                    }
                    if (File.Exists(path + @"Windows\SysWOW64\OneDriveSetup.exe"))
                    {
                        output(
                            ProcStartargs(path + @"Windows\SysWOW64\OneDriveSetup.exe", "/uninstall"));
                    }
                    output(
                        ProcessUtil.RunCmd("/c ping 127.0.0.1 -n 5 > NUL 2>&1"));
                    output(
                        ProcessUtil.RunCmd("/c rd \"%USERPROFILE%\\OneDrive\" /Q /S > NUL 2>&1"));
                    output(
                        ProcessUtil.RunCmd("/c rd \"C:\\OneDriveTemp\" /Q /S > NUL 2>&1"));
                    output(
                        ProcessUtil.RunCmd("/c rd \"%LOCALAPPDATA%\\Microsoft\\OneDrive\" /Q /S > NUL 2>&1"));
                    output(
                        ProcessUtil.RunCmd("/c rd \"%PROGRAMDATA%\\Microsoft OneDrive\" /Q /S > NUL 2>&1"));
                    output(
                        ProcStartargs(ShellCmdLocation,
                            "/c REG DELETE \"HKEY_CLASSES_ROOT\\CLSID\\{018D5C66-4533-4307-9B53-224DE2ED1FE6}\" /f > NUL 2>&1"));
                    output(
                        ProcStartargs(ShellCmdLocation,
                            "/c REG DELETE \"HKEY_CLASSES_ROOT\\Wow6432Node\\CLSID\\{018D5C66-4533-4307-9B53-224DE2ED1FE6}\" /f > NUL 2>&1"));


                }
                catch (Exception ex)
                {
                    Invoke(new MethodInvoker(delegate
                    {
                        MessageBox.Show(ex.Message, GetTranslateText("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }));
                }
                Invoke(new MethodInvoker(delegate
                {
                    MessageBox.Show(GetTranslateText("Complete"), GetTranslateText("Info"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));
                EnableOrDisableTab(true);
            }).Start();
        }

        private void linkLabelSourceCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Nummer/Destroy-Windows-10-Spying");
        }

        private void btnRemoveOldFirewallRules_Click(object sender, EventArgs e)
        {
            ProcessUtil.RunCmd("/c netsh advfirewall firewall delete rule name=\"MS Spynet block 1\"");
            ProcessUtil.RunCmd("/c netsh advfirewall firewall delete rule name=\"MS Spynet block 2\"");
            ProcessUtil.RunCmd("/c netsh advfirewall firewall delete rule name=\"MS telemetry block 1\"");
            ProcessUtil.RunCmd("/c netsh advfirewall firewall delete rule name=\"MS telemetry block 2\"");
            MessageBox.Show(GetTranslateText("Complete"), GetTranslateText("Info"));
        }

        private void btnReportABug_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Nummer/Destroy-Windows-10-Spying/issues/new");
        }

        private void comboBoxLanguageSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLanguageSelect.Text.Split('|')[0].Replace(" ", "") == "ru-RU")
            {
                rm = lang.ru_RU.ResourceManager;
                ChangeLanguage();
            }
            else if (comboBoxLanguageSelect.Text.Split('|')[0].Replace(" ", "") == "fr-FR")
            {
                rm = lang.fr_FR.ResourceManager;
                ChangeLanguage();
            }
            else if (comboBoxLanguageSelect.Text.Split('|')[0].Replace(" ", "") == "es-ES")
            {
                rm = lang.es_ES.ResourceManager;
                ChangeLanguage();
            }
            else
            {
                rm = lang.en_US.ResourceManager;
                ChangeLanguage();
            }
        }

        private void btnDestroyWindows78Spy_Click(object sender, EventArgs e)
        {
            btnDestroyWindows78Spy.Enabled = false;
            fatalerrors = 0;
            new Thread(() =>
            {
                disablehostsandaddfirewall();
                disablespytasks();
                Invoke(new MethodInvoker(delegate
                {
                    btnDestroyWindows78Spy.Enabled = true;
                    MessageBox.Show(GetTranslateText("Complete"), GetTranslateText("Info"), MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }));
            }).Start();
        }
    }
}
