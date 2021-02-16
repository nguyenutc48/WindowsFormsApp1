using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views.VirtuaData
{
    public partial class vMain : UserControl
    {
        private static vMain _instance;
        public static vMain Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new vMain();
                return _instance;
            }
        }
        public vMain()
        {
            InitializeComponent();
        }
    }
}
