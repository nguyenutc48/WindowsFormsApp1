using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Views;
using WindowsFormsApp1.Views.Monitoring;
using WindowsFormsApp1.Views.Setting;
using WindowsFormsApp1.Views.VirtuaData;
using PLCMitsuCom;
using PLC_MITSU_CONFIG;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private static PLCMitsu _plc;
        public static PLCMitsu PLC
        {
            get
            {
                if (_plc == null)
                    _plc = new PLCMitsu();
                return _plc;
            }
            set
            {
                _plc = value;
            }
        }
        private static bool _plcconnected = false;
        public static bool plcConnected { get { return _plcconnected; } set { _plcconnected = value; } }
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
        
        List<UserControl> userControls = new List<UserControl>();

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

        private void Form1_Load(object sender, EventArgs e)
        {
            StaticConfig.LoadView(mMainContent.Instance,pnl_mainContent);
            StaticConfig.LoadView(sConfigMain.Instance, pnl_mainContent);
            StaticConfig.LoadView(vMain.Instance, pnl_mainContent);

            btnClick_Menu(null, null);
            //var result = PLC.Open(PLC_UNIT_TYPE.UNIT_FXCPU);
            //if(result == 0)
            //{
            //    _plcconnected = true;
            //    timer1.Enabled = true;
            //    timer1.Start();
            //}
            var a = StaticConfig.GetAllControl(mMainContent.Instance);
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
