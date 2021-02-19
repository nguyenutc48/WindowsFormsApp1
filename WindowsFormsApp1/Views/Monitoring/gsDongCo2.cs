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
    public partial class gsDongCo2 : UserControl
    {
        private static gsDongCo2 _instance;
        public static gsDongCo2 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new gsDongCo2();
                return _instance;
            }
        }
        public gsDongCo2()
        {
            InitializeComponent();
        }
    }
}
