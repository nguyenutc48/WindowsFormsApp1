using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Views.Monitoring;

namespace WindowsFormsApp1.Views
{
    public partial class gsHethongDC : UserControl
    {
        private static gsHethongDC _instance;
        public static gsHethongDC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new gsHethongDC();
                return _instance;
            }
        }
        public gsHethongDC()
        {
            InitializeComponent();
        }

        private void btnDC1_Click(object sender, EventArgs e)
        {
            mMainContent.Instance.NextPage(PAGE.DONG_CO_1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mMainContent.Instance.NextPage(PAGE.DONG_CO_2);

        }

        private void btnDC3_Click(object sender, EventArgs e)
        {
            mMainContent.Instance.NextPage(PAGE.DONG_CO_3);

        }
    }
}
