using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views.Monitoring
{
    public partial class gsDongCo1 : UserControl
    {
        private static gsDongCo1 _instance;
        public static gsDongCo1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new gsDongCo1();
                return _instance;
            }
        }
        public void StartGetData()
        {
            timer1.Start();
        }
        public void StopGetData()
        {
            timer1.Stop();
        }
        public gsDongCo1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
