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
        List<Control> controls = new List<Control>();

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
            var allControls = StaticConfig.GetAllControl(this).ToList();
            foreach (var item in allControls)
            {
                if (item.Name.Contains("plc"))
                {
                    controls.Add(item);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Form1.plcConnected == true)
            {
                if (Form1.loadConfigFinsh == true)
                {
                    foreach (var item in Form1.ControlAddressList)
                    {
                        var control = controls.Where(c => c.Name == item.controlName.Trim()).FirstOrDefault();
                        if (control != null)
                        {
                            if (item.plcAddressType == "Integer")
                            {
                                control.Text = PLCCom.getInt32Device(item.plcAddress).ToString();
                            }
                            else
                            {
                                control.Text = PLCCom.getDoubleDevice(item.plcAddress).ToString();
                            }
                        }
                    }
                }
            }
            }
    }
}
