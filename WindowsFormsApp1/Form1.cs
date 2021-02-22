using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Views;
using WindowsFormsApp1.Views.Monitoring;
using WindowsFormsApp1.Views.Setting;
using WindowsFormsApp1.Views.VirtuaData;
using WMPLib;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        enum Control
        {
            Play,
            Stop,
            Pause
        }
        bool scanRunning = false;

        WindowsMediaPlayer wplayer1;// = new WMPLib.WindowsMediaPlayer();
        WindowsMediaPlayer wplayer2;// = new WMPLib.WindowsMediaPlayer();
        WindowsMediaPlayer wplayer3;// = new WMPLib.WindowsMediaPlayer();
        int soundIndex1_Old = 0;
        int soundIndex2_Old = 0;
        int soundIndex3_Old = 0;

        private static bool _plcconnected = false;
        public static bool plcConnected { get { return _plcconnected; } set { _plcconnected = value; } }
        private static bool _loadConfigFinsh = false;
        public static bool loadConfigFinsh { get { return _loadConfigFinsh; } set { _loadConfigFinsh = value; } }

        private static Form1 _instance;
        public static Form1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Form1();
                return _instance;
            }
        }
        private static List<AmThanhModel> _amThanhConfigs;
        public static List<AmThanhModel> AmThanhConfigs
        {
            get
            {
                if (_amThanhConfigs == null)
                    _amThanhConfigs = new List<AmThanhModel>();
                return _amThanhConfigs;
            }
            set
            {
                _amThanhConfigs = value;
            }
        }
        private static List<DongCoConfigModel> _dongcoAddress;
        public static List<DongCoConfigModel> DongCoAdress
        {
            get
            {
                if (_dongcoAddress == null)
                    _dongcoAddress = new List<DongCoConfigModel>();
                return _dongcoAddress;
            }
            set
            {
                _dongcoAddress = value;
            }
        }

        public static List<ControlAddressModel> ControlAddressList
        {
            get
            {
                if (_controlAddressList == null)
                    _controlAddressList = new List<ControlAddressModel>();
                return _controlAddressList;
            }
            set 
            { 
                _controlAddressList = value; 
            }
        }

        private static List<ControlAddressModel> _controlAddressList;//= new List<ControlAddressModel>();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMiniApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bannerMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void SoundControl(WindowsMediaPlayer player, string url,Control ctr)
        {
            if (ctr == Control.Play)
            {
                player.settings.setMode("loop", true);
                player.URL = url;
                player.controls.play();
            }
            else if (ctr == Control.Stop)
                player.controls.stop();
            else
                player.controls.pause();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            wplayer1 = new WindowsMediaPlayer();
            wplayer2 = new WindowsMediaPlayer();
            wplayer3 = new WindowsMediaPlayer();

            StaticConfig.LoadView(mMainContent.Instance,pnl_mainContent);
            StaticConfig.LoadView(sConfigMain.Instance, pnl_mainContent);
            StaticConfig.LoadView(vMain.Instance, pnl_mainContent);

            //Chon trang home
            btnClick_Menu(null, null);
            var a = StaticConfig.GetAllControl(mMainContent.Instance);

            //Load file config
            await Task.Factory.StartNew(() =>
            {

                var motor1Config = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControlAddressDC1.xlsx");
                var motor2Config = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControlAddressDC2.xlsx");
                var motor3Config = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControlAddressDC3.xlsx");
                var amthanhPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AmthanhConfig.xlsx");

                string[,] motor1ConfigData;
                string[,] motor2ConfigData;
                string[,] motor3ConfigData;
                string[,] amthanhConfigData;

                NFILEHELPER.ExcelHelper.Read(motor1Config, out motor1ConfigData);
                NFILEHELPER.ExcelHelper.Read(motor2Config, out motor2ConfigData);
                NFILEHELPER.ExcelHelper.Read(motor3Config, out motor3ConfigData);
                NFILEHELPER.ExcelHelper.Read(amthanhPath, out amthanhConfigData);
                var pathSound = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sound");
                if (!Directory.Exists(pathSound))
                    Directory.CreateDirectory(pathSound);
                for (int i = 1; i < amthanhConfigData.GetLength(0); i++)
                {
                    AmThanhModel amThanhModel = new AmThanhModel();
                    amThanhModel.Index = Convert.ToInt16(amthanhConfigData[i, 0]);
                    amThanhModel.Tocdo = amthanhConfigData[i, 1] == null ? "" : amthanhConfigData[i, 1].ToString();
                    amThanhModel.TenFile = amthanhConfigData[i, 2] == null ? "" : Path.Combine(pathSound, amthanhConfigData[i, 2].ToString());
                    AmThanhConfigs.Add(amThanhModel);
                }
                for (int i = 1; i < motor1ConfigData.GetLength(0); i++)
                {
                    ControlAddressModel dongco = new ControlAddressModel();
                    dongco.motorIndex = DONGCO.DONG_CO_1;
                    dongco.plcAddress = motor1ConfigData[i, 0] == null ? "" : motor1ConfigData[i, 0];
                    dongco.plcAddressType = motor1ConfigData[i, 1] == null ? "" : motor1ConfigData[i, 1].ToString();
                    dongco.addressName = motor1ConfigData[i, 2] == null ? "" : motor1ConfigData[i, 2].ToString();
                    dongco.controlName = motor1ConfigData[i, 3] == null ? "" : motor1ConfigData[i, 3].ToString();
                    ControlAddressList.Add(dongco);

                }
                
                for (int i = 1; i < motor2ConfigData.GetLength(0); i++)
                {
                    ControlAddressModel dongco = new ControlAddressModel();
                    dongco.motorIndex = DONGCO.DONG_CO_2;
                    dongco.plcAddress = motor2ConfigData[i, 0] == null ? "" : motor2ConfigData[i, 0];
                    dongco.plcAddressType = motor2ConfigData[i, 1] == null ? "" : motor2ConfigData[i, 1].ToString();
                    dongco.addressName = motor2ConfigData[i, 2] == null ? "" : motor2ConfigData[i, 2].ToString();
                    dongco.controlName = motor2ConfigData[i, 3] == null ? "" : motor2ConfigData[i, 3].ToString();
                    ControlAddressList.Add(dongco);

                }
                for (int i = 1; i < motor3ConfigData.GetLength(0); i++)
                {
                    ControlAddressModel dongco = new ControlAddressModel();
                    dongco.motorIndex = DONGCO.DONG_CO_3;
                    dongco.plcAddress = motor3ConfigData[i, 0] == null ? "" : motor3ConfigData[i, 0];
                    dongco.plcAddressType = motor3ConfigData[i, 1] == null ? "" : motor3ConfigData[i, 1].ToString();
                    dongco.addressName = motor3ConfigData[i, 2] == null ? "" : motor3ConfigData[i, 2].ToString();
                    dongco.controlName = motor3ConfigData[i, 3] == null ? "" : motor3ConfigData[i, 3].ToString();
                    ControlAddressList.Add(dongco);

                }
            });
            loadConfigFinsh = true;


            timer1.Start();
        }

        private void btnClick_Menu(object sender, EventArgs e)
        {
            var btn = sender as EnhancedGlassButton.GlassButton;
            string btnName = btn==null? "":btn.Name;
            btnGiamSat.BackColor = Color.White;
            btnCaiDat.BackColor = Color.White;
            btnGiaLap.BackColor = Color.White;
            btnTaiLieu.BackColor = Color.White;
            switch (btnName)
            {
                case "btnGiamSat":
                    btnGiamSat.BackColor = Color.Yellow;
                    StaticConfig.ShowView(mMainContent.Instance, pnl_mainContent);
                    mMainContent.Instance.StartGetData();
                    break;
                case "btnCaiDat":
                    btnCaiDat.BackColor = Color.Yellow;
                    StaticConfig.ShowView(sConfigMain.Instance, pnl_mainContent);
                    break;
                case "btnGiaLap":
                    btnGiaLap.BackColor = Color.Yellow;
                    StaticConfig.ShowView(vMain.Instance, pnl_mainContent);
                    break;
                case "btnTaiLieu":
                    btnTaiLieu.BackColor = Color.Yellow;
                    break;
                default:
                    btnGiamSat.BackColor = Color.Yellow;
                    StaticConfig.ShowView(mMainContent.Instance, pnl_mainContent);
                    break;
            }
        }

        // Timer update data
        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (scanRunning == true)
                return;
            scanRunning = true;
            await Task.Factory.StartNew(() =>
            {
                if (loadConfigFinsh)
                {
                    if (plcConnected)
                    {
                        int soundIndex1 = PLCCom.getDevice("D358"); //May 1
                        int soundIndex2 = PLCCom.getDevice("D360"); //May 2
                        int soundIndex3 = PLCCom.getDevice("D362"); //May 3
                        if (soundIndex1 != soundIndex1_Old)
                        {
                            wplayer1.controls.pause();
                            soundIndex1_Old = soundIndex1;
                            var soundSelected = AmThanhConfigs.Where(a => a.Index == soundIndex1).FirstOrDefault();
                            if (soundSelected != null)
                                SoundControl(wplayer1, soundSelected.TenFile, Control.Play);
                            else
                                SoundControl(wplayer1, "", Control.Stop);

                        }
                        if (soundIndex2 != soundIndex2_Old)
                        {
                            wplayer2.controls.pause();
                            soundIndex2_Old = soundIndex2;
                            var soundSelected = AmThanhConfigs.Where(a => a.Index == soundIndex2).FirstOrDefault();
                            if (soundSelected != null)
                                SoundControl(wplayer2, soundSelected.TenFile, Control.Play);
                            else
                                SoundControl(wplayer2, "", Control.Stop);

                        }
                        if (soundIndex3 != soundIndex3_Old)
                        {
                            wplayer3.controls.pause();
                            soundIndex3_Old = soundIndex3;
                            var soundSelected = AmThanhConfigs.Where(a => a.Index == soundIndex3).FirstOrDefault();
                            if (soundSelected != null)
                                SoundControl(wplayer3, soundSelected.TenFile, Control.Play);
                            else
                                SoundControl(wplayer3, "", Control.Stop);

                        }
                    }
                }
            });
            scanRunning = false;
        }
    }
}
