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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
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

        public void LoadPage(Control control)
        {
            if (!pnlBodyData.Controls.Contains(control))
            {
                pnlBodyData.Controls.Add(control);
                control.Dock = DockStyle.Fill;
                control.Visible = false;
            }
        }

        private void moveSidePanel(Control btn)
        {
            pnlBodyData.Top = btn.Top;
            pnlBodyData.Height = btn.Height;
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnlBodyData.Controls.Clear();
            pnlBodyData.Controls.Add(c);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            moveSidePanel(this);
            gsOverview overview = new gsOverview();
            AddControlsToPanel(overview);
            btnGiamSat.BackColor = Color.Green;
        }
    }
}
