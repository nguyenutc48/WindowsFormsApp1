using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Views;
using WindowsFormsApp1.Views.Monitoring;
using WindowsFormsApp1.Views.Setting;
using WindowsFormsApp1.Views.VirtuaData;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
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

    }
}
