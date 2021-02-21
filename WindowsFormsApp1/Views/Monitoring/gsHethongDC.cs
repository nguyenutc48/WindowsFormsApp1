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
        List<Control> controls = new List<Control>();
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
        public void StartGetData()
        {
            timer1.Start();
        }
        public void StopGetData()
        {
            timer1.Stop();
        }
        public gsHethongDC()
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

                plc_dc1_sld_tocdo.Value = Convert.ToInt32(plc_dc1_lbl_tocdo.Text);
                plc_dc1_sld_nhienlieu.Value = Convert.ToInt32(plc_dc1_lbl_nhienlieu.Text);
                plc_dc1_sld_apluckhi.Value = Convert.ToInt32(plc_dc1_lbl_apluckhi.Text);
                plc_dc1_sld_TxakhiveA.Value = Convert.ToInt32(plc_dc1_lbl_TxakhiveA.Text);
                plc_dc1_sld_TxakhiveB.Value = Convert.ToInt32(plc_dc1_lbl_TxakhiveB.Text);

                plc_dc2_sld_tocdo.Value = Convert.ToInt32(plc_dc2_lbl_tocdo.Text);
                plc_dc2_sld_nhienlieu.Value = Convert.ToInt32(plc_dc2_lbl_nhienlieu.Text);
                plc_dc2_sld_apluckhi.Value = Convert.ToInt32(plc_dc2_lbl_apluckhi.Text);
                plc_dc2_sld_TxakhiveA.Value = Convert.ToInt32(plc_dc2_lbl_TxakhiveA.Text);
                plc_dc2_sld_TxakhiveB.Value = Convert.ToInt32(plc_dc2_lbl_TxakhiveB.Text);

                plc_dc3_sld_tocdo.Value = Convert.ToInt32(plc_dc3_lbl_tocdo.Text);
                plc_dc3_sld_nhienlieu.Value = Convert.ToInt32(plc_dc3_lbl_nhienlieu.Text);
                plc_dc3_sld_apluckhi.Value = Convert.ToInt32(plc_dc3_lbl_apluckhi.Text);
                plc_dc3_sld_TxakhiveA.Value = Convert.ToInt32(plc_dc3_lbl_TxakhiveA.Text);
                plc_dc3_sld_TxakhiveB.Value = Convert.ToInt32(plc_dc3_lbl_TxakhiveB.Text);
            }
            

            
        }
    }
}
