using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.ComponentModel;
using System.IO.Compression;
using System.Drawing;

namespace Cheat_Loader_By_LeonimusT
{
    public partial class Frame : Form
    {
        //dll
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        //variables
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

            );

        //more variables
        private string rootPath;
        private string versionFile;
        private string gameZip;

        //all json data is in this dynamic variable (idk what is this but it work)
        public dynamic stuff;

        //all string for the injector
        private string localVersion;
        private string vLink;
        private string dllLink;
        private string gameProcess;
        private string dllPath;
        private string gameName;
        private string dllName;

        // frame :)
        public Frame()
        {
            InitializeComponent();
            infoPanel.Visible = false;
            injectText.Visible = false;

            //check app info
            using (WebClient wc = new WebClient())
            {
                //read json
                string json = wc.DownloadString("https://disapproved-method.000webhostapp.com/app_version.json");
                //deserialize json
                stuff = JsonConvert.DeserializeObject(json);

                var item = stuff;
                string currentPath = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);

                //check if app_local_version.txt exist
                if (File.Exists(@currentPath + "\\" + item.localVersionName))
                {
                    localVersion = File.ReadAllText(@currentPath + "\\" + item.localVersionName);
                }
                else
                {
                    //download it if not
                    wc.DownloadFile((string)item.downloadLink, (string)item.localVersionName);

                    localVersion = File.ReadAllText(@currentPath + "\\" + item.localVersionName);
                }

                if (item.onlineVersion != localVersion)
                {
                    if ((bool)item.important_update)
                    {
                        MessageBox.Show("A new version of the app has been released! You must install it if you want to continue using it.", "New update 🥳 !", MessageBoxButtons.OK);
                        //close app, other method for close app didn't work idk why
                        System.Environment.Exit(0);
                    }
                    else
                    {
                        MessageBox.Show("A new version of the app has been released! You don't have to install it if you want to continue using it.", "New update 🥳 !", MessageBoxButtons.OK);
                    }
                }
            }

            //load json
            using (WebClient wc = new WebClient())
            {
                //read json
                string json = wc.DownloadString("https://disapproved-method.000webhostapp.com/cheat_info.json");
                //deserialize json
                stuff = JsonConvert.DeserializeObject(json);
                foreach(var item in stuff)
                {
                    try
                    {
                        //add cheat name to list box
                        listBox1.Items.Add(item.First.name + ", " + item.First.game);
                    }
                    catch (Exception ex)
                    {
                        //show error message
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        //when user click an item in the list box
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxUpdate();
        }

        void listBoxUpdate()
        {
            foreach (var item in stuff)
            {
                //check if list box item name = to item currently the name in item to use it
                if (listBox1.Text == (string)item.First.name + ", " + item.First.game)
                {
                    //set visibility to true
                    infoPanel.Visible = true;
                    //set dll name
                    dllName = item.First.dllName;
                    //set game name
                    gameName = item.First.game;
                    //change cheat name to json name data
                    cheatNamelb1.Text = item.First.name;
                    //get current patch
                    string currentPath = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
                    //set current path for download
                    rootPath = currentPath;
                    //set game process from json data
                    gameProcess = item.First.processName;
                    //set dll path from json data
                    dllPath = @currentPath + "\\" + item.First.dllName;
                    //status label
                    statuslb.Text = item.First.status;
                    if (item.First.status == "Undetectable")
                        statuslb.ForeColor = System.Drawing.Color.LimeGreen;
                    else
                        statuslb.ForeColor = System.Drawing.Color.Red;
                    //online version label
                    onlinevlb.Text = item.First.onlineVersion;
                    //check if cheat work
                    if ((bool)item.First.working)
                    {
                        // working label
                        workinglb.Text = "Yes";
                        workinglb.ForeColor = System.Drawing.Color.LimeGreen;

                        //set some variables
                        dllLink = item.First.zipLink;
                        vLink = item.First.downloadLink;
                        gameZip = @currentPath + "\\" + item.First.zipName;

                        //check if local version file exists and set variables
                        if (File.Exists(@currentPath + "\\" + item.First.localVersionName))
                        {
                            localVersion = File.ReadAllText(@currentPath + "\\" + item.First.localVersionName);
                            versionFile = @currentPath + "\\" + item.First.localVersionName;
                            //local version label
                            localvlb.Text = localVersion;
                        }
                        else
                        {
                            versionFile = @currentPath + "\\" + item.First.localVersionName;
                            //local version label
                            localvlb.Text = "Cheat not installed";
                        }

                        //check if local version = to online version
                        if (item.First.onlineVersion == localVersion)
                        {
                            if (File.Exists(@currentPath + "\\" + item.First.dllName))
                                injectButton.Text = "Inject";
                            else
                                injectButton.Text = "Install";
                        }
                        else
                        {
                            if (File.Exists(@currentPath + "\\" + item.First.dllName))
                                injectButton.Text = "Update";
                            else
                                injectButton.Text = "Install";
                        }
                    }
                    else
                    {
                        //cheat not working
                        injectButton.Text = "Cheat not working";
                        workinglb.Text = "No";
                        workinglb.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
        }

        //install file
        private void InstallCheatFiles(Version _onlineVersion)
        {
            try
            {
                if (File.Exists(dllPath))
                {
                    File.Delete(dllPath);
                }
                WebClient webClient = new WebClient();
                _onlineVersion = new Version(webClient.DownloadString(vLink));
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadCheatCompletedCallback);
                webClient.DownloadFileAsync(new Uri(dllLink), gameZip, _onlineVersion);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error installing game files: {ex}");
            }
        }

        //downloaded cheat completed call back, and set injectText text
        private void DownloadCheatCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                string onlineVersion = ((Version)e.UserState).ToString();
                ZipFile.ExtractToDirectory(gameZip, rootPath);
                File.Delete(gameZip);

                File.WriteAllText(versionFile, onlineVersion);
                injectText.Visible = true;
                injectText.Text = "Update/Installation was successful !";
                injectText.ForeColor = System.Drawing.Color.LimeGreen;
                injectText.Refresh();
                System.Threading.Thread.Sleep(5000);
                injectText.Visible = false;
                listBoxUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error finishing download: {ex}");
            }
        }

        //get some dll
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        //idk what is this but its ok :)
        private const int SW_HIDE = 0x0;
        private const int SW_SHOW = 0x5;

        
        //inject button click
        private void injectButton_Click(object sender, EventArgs e)
        {
            //check button text
            if (injectButton.Text == "Install")
                InstallCheatFiles(Version.zero);
            else if (injectButton.Text == "Update")
                InstallCheatFiles(Version.zero);
            else if (injectButton.Text == "Inject")
            {
                if(statuslb.Text == "Detectable")
                {
                    //ask the user if he still wants to inject it even if it is detected 
                    DialogResult dialogResult = MessageBox.Show("This cheat is detectable, did you want to inject it?", "WAIT !", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
                IntPtr hwGame = (IntPtr)FindWindow(null, gameProcess);
                if (hwGame != IntPtr.Zero)
                {
                    try
                    {
                        //try to inject
                        injectText.Visible = true;
                        //if the cheat is for csgo then
                        if(gameName == "CSGO")
                        {
                            if (IntPtr.Size == 4)
                            {
                                if (CSGOInjector.VACBypass.RunCSGO(dllPath))
                                {
                                    injectText.Text = "Injected !";
                                    injectText.ForeColor = System.Drawing.Color.LimeGreen;
                                    injectText.Refresh();
                                    System.Threading.Thread.Sleep(5000);
                                }
                                else
                                {
                                    //failed to inject
                                    injectText.Text = "Injecting Failed !";
                                    injectText.ForeColor = System.Drawing.Color.Red;
                                    injectText.Refresh();
                                    System.Threading.Thread.Sleep(5000);
                                }
                            }
                            else if (IntPtr.Size == 8)
                            {
                                injectText.Text = "Launch the x86 cheat loader !";
                                injectText.ForeColor = System.Drawing.Color.Red;
                                injectText.Refresh();
                                System.Threading.Thread.Sleep(5000);
                            }
                        }
                        // if the cheat is for gmod then
                        else if(gameName == "Garry's Mod")
                        {
                            if (IntPtr.Size == 4)
                            {
                                injectText.Text = "Launch the x64 cheat loader !";
                                injectText.ForeColor = System.Drawing.Color.Red;
                                injectText.Refresh();
                                System.Threading.Thread.Sleep(5000);
                            }
                            else if (IntPtr.Size == 8)
                            {
                                string args = dllName;
                                System.Diagnostics.Process.Start("ginjector.exe", args);
                                injectText.Text = "Injected !";
                                injectText.ForeColor = System.Drawing.Color.LimeGreen;
                                injectText.Refresh();
                                System.Threading.Thread.Sleep(5000);
                            }
                        }

                    }
                    catch (Exception e2)
                    {
                        //error
                        MessageBox.Show(e2.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //game not launch
                    injectText.Visible = true;
                    injectText.Text = "Game not launch !";
                    injectText.ForeColor = System.Drawing.Color.Red;
                    injectText.Refresh();
                    System.Threading.Thread.Sleep(5000);
                }
                injectText.Visible = false;
            }
        }

        //more dll
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        //dead button
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //dead button
        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //idk
        private void Frame_Load(object sender, EventArgs e)
        {

        }

        //things for update and download
        struct Version
        {
            internal static Version zero = new Version(0, 0, 0);

            private short major;
            private short minor;
            private short subMinor;

            internal Version(short _major, short _minor, short _subMinor)
            {
                major = _major;
                minor = _minor;
                subMinor = _subMinor;
            }
            internal Version(string _version)
            {
                string[] versionStrings = _version.Split('.');
                if (versionStrings.Length != 3)
                {
                    major = 0;
                    minor = 0;
                    subMinor = 0;
                    return;
                }

                major = short.Parse(versionStrings[0]);
                minor = short.Parse(versionStrings[1]);
                subMinor = short.Parse(versionStrings[2]);
            }

            internal bool IsDifferentThan(Version _otherVersion)
            {
                if (major != _otherVersion.major)
                {
                    return true;
                }
                else
                {
                    if (minor != _otherVersion.minor)
                    {
                        return true;
                    }
                    else
                    {
                        if (subMinor != _otherVersion.subMinor)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }

            public override string ToString()
            {
                return $"{major}.{minor}.{subMinor}";
            }
        }

        //close button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //drag the window
        bool mouseDown = false;
        private Point offset;
        private void topName_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void topName_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void topName_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
