using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views.Setting
{
    public partial class sConfigMain : UserControl
    {
        string amthanhPath = "";
        string dongco1Path = "";
        string dongco2Path = "";
        string dongco3Path = "";

        private static sConfigMain _instance;
        public static sConfigMain Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new sConfigMain();
                return _instance;
            }
        }
        public sConfigMain()
        {
            InitializeComponent();
        }

        private void btnClickChonfileConfig(object sender, EventArgs e)
        {
            var btn = sender as Button;
            string btnName = btn.Name;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Title = "Chọn File Config";
            openFileDialog.DefaultExt = "xlsx";
            openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (btnName)
                {
                    case "btnChonfileAmthanh":
                        amthanhPath = openFileDialog.FileName;
                        lblAmthanhPath.Text = amthanhPath;
                        break;
                    case "btnChonfileDC1":
                        dongco1Path = openFileDialog.FileName;
                        lblDongco1Path.Text = dongco1Path;
                        break;
                    case "btnChonfileDC2":
                        dongco2Path = openFileDialog.FileName;
                        lblDongco2Path.Text = dongco2Path;
                        break;
                    case "btnChonfileDC3":
                        dongco3Path = openFileDialog.FileName;
                        lblDongco3Path.Text = dongco3Path;
                        break;
                }
            }
        }

        private void btnClickLuuConfig(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "Sound.wav";
            player.Play();
        }
    }
}
