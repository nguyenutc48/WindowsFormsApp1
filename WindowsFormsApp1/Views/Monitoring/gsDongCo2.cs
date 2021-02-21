using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views.Monitoring
{
    public partial class gsDongCo2 : UserControl
    {
        bool scanRunning = false;

        List<Control> controls = new List<Control>();

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
        public void StartGetData()
        {
            timer1.Start();
        }
        public void StopGetData()
        {
            timer1.Stop();
        }
        public gsDongCo2()
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

        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (scanRunning == true)
                return;
            scanRunning = true;
            await Task.Factory.StartNew(() =>
            {
                if (Form1.plcConnected == true)
                {
                    if (Form1.loadConfigFinsh == true)
                    {
                        int left2 = PLCCom.getDevice("M673");
                        int right2 = PLCCom.getDevice("M674");
                        int lyhop2 = PLCCom.getDevice("M675");

                        if (left2 == 1)
                            plc_dc2_pnl_lamp_left.BackColor = Color.Green;
                        else
                            plc_dc2_pnl_lamp_left.BackColor = Color.LightGray;
                        if (right2 == 1)
                            plc_dc2_pnl_lamp_right.BackColor = Color.Green;
                        else
                            plc_dc2_pnl_lamp_right.BackColor = Color.LightGray;
                        if (lyhop2 == 1)
                            plc_dc2_pnl_lamp_lihop.BackColor = Color.Green;
                        else
                            plc_dc2_pnl_lamp_lihop.BackColor = Color.LightGray;

                        foreach (var item in Form1.ControlAddressList)
                        {
                            var control = controls.Where(c => c.Name == item.controlName.Trim()).FirstOrDefault();
                            if (control != null)
                            {
                                if (item.plcAddressType == "Integer")
                                {
                                    if (control.Name.Contains("vitri_chanvit"))
                                    {
                                        int data = PLCCom.getDevice(item.plcAddress);
                                        if (data < 3)
                                            control.Text = StaticConfig.PosLiHop[data];
                                        else
                                            control.Text = "";

                                    }
                                    else if (control.Name.Contains("chedo"))
                                    {
                                        int data = PLCCom.getDevice(item.plcAddress);
                                        if (data < 2)
                                            control.Text = StaticConfig.CheDoDieuKhien[0];
                                        else if(data >1 && data <4)
                                            control.Text = StaticConfig.CheDoDieuKhien[1];
                                        else
                                            control.Text = "";
                                    }
                                    else
                                    {
                                        var temp = PLCCom.getInt32Device(item.plcAddress);
                                        control.Text = temp < 0 ? "0" : PLCCom.getInt32Device(item.plcAddress).ToString();
                                    }

                                }
                                else
                                {
                                    control.Text = Math.Round(PLCCom.getDoubleDevice(item.plcAddress), 2).ToString();

                                }
                            }
                        }
                    }
                }
            });
            scanRunning = false;
        }
        int togle = 0;
        private void plc_dc2_btn_dieukhien_Click(object sender, EventArgs e)
        {
            togle = 1 - togle;
            PLCCom.setDevice("M1010", togle);
        }

        private void plc_dc1_btn_khoi_dong_Click(object sender, EventArgs e)
        {
            PLCCom.setDevice("M1011", 1);
            Thread.Sleep(100);
            PLCCom.setDevice("1001", 0);
        }

        private void plc_dc1_btn_dung_Click(object sender, EventArgs e)
        {
            PLCCom.setDevice("M1012", 1);
            Thread.Sleep(100);
            PLCCom.setDevice("1012", 0);
        }
    }
}
