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
    public partial class gsTongQuan : UserControl
    {
        private static gsTongQuan _instance;
        public static gsTongQuan Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new gsTongQuan();
                return _instance;
            }
        }
        public gsTongQuan()
        {
            InitializeComponent();
        }
    }
}
