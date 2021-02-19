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
    public partial class mMainContent : UserControl
    {

        private static mMainContent _instance;
        public static mMainContent Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new mMainContent();
                return _instance;
            }
        }
        public mMainContent()
        {
            InitializeComponent();
        }
    }
}
