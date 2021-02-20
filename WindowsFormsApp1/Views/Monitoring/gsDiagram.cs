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
    public partial class gsDiagram : UserControl
    {
        private static gsDiagram _instance;
        public static gsDiagram Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new gsDiagram();
                return _instance;
            }
        }
        public gsDiagram()
        {
            InitializeComponent();
        }
    }
}
