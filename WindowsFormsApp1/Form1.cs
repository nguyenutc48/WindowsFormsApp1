using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Views;
using WindowsFormsApp1.Views.Monitoring;
using WindowsFormsApp1.Views.Setting;
using WindowsFormsApp1.Views.VirtuaData;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
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
        private static List<AmThanhModel> _amThanhModels;
        public static List<AmThanhModel> AmThanhModel
        {
            get
            {
                if (_amThanhModels == null)
                    _amThanhModels = new List<AmThanhModel>();
                return _amThanhModels;
            }
            set
            {
                _amThanhModels = value;
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

        private async void Form1_Load(object sender, EventArgs e)
        {
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

                string[,] motor1ConfigData;
                string[,] motor2ConfigData;
                string[,] motor3ConfigData;

                NFILEHELPER.ExcelHelper.Read(motor1Config, out motor1ConfigData);
                NFILEHELPER.ExcelHelper.Read(motor2Config, out motor2ConfigData);
                NFILEHELPER.ExcelHelper.Read(motor3Config, out motor3ConfigData);
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
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
