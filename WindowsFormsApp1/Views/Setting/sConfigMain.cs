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
    }
}
