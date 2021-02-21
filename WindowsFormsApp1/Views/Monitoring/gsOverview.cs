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
using WindowsFormsApp1.Views.Monitoring;

namespace WindowsFormsApp1.Views
{
    public partial class gsOverview : UserControl
    {
        private static gsOverview _instance;
        public static gsOverview Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new gsOverview();
                return _instance;
            }
        }
        public gsOverview()
        {
            InitializeComponent();
        }

        // Xem chi tiet 3 dong co
        private void btnClickChiTietDongCo(object sender, EventArgs e)
        {
            var btn = sender as Button;
            string btnName = btn.Name;
            switch (btnName)
            {
                case "btndc1":
                    mMainContent.Instance.NextPage(PAGE.DONG_CO_1);
                    break;
                case "btndc2":
                    mMainContent.Instance.NextPage(PAGE.DONG_CO_2);
                    break;
                case "btndc3":
                    mMainContent.Instance.NextPage(PAGE.DONG_CO_3);
                    break;
            }

        }

        private void btncauhinhhethong_Click(object sender, EventArgs e)
        {
            mMainContent.Instance.NextPage(PAGE.DIAGRAM);

        }

        private void btnhethongdc_Click(object sender, EventArgs e)
        {
            mMainContent.Instance.NextPage(PAGE.HE_THONG_DONG_CO);
        }

        private void btnbangdienchinh_Click(object sender, EventArgs e)
        {
            mMainContent.Instance.NextPage(PAGE.TONGQUAT);
        }

    }
}
