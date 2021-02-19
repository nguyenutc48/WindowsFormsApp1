using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void btncauhinhhethong_Click(object sender, EventArgs e)
        {

        }

        private void btnhethongdc_Click(object sender, EventArgs e)
        {

        }

        private void btnbangdienchinh_Click(object sender, EventArgs e)
        {

        }
    }
}
