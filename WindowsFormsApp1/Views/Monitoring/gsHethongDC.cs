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
            plc_dc1_pnl_lamp_left.BackColor = Color.LightGray;
            plc_dc2_pnl_lamp_left.BackColor = Color.LightGray;
            plc_dc3_pnl_lamp_left.BackColor = Color.LightGray;
            plc_dc1_pnl_lamp_right.BackColor = Color.LightGray;
            plc_dc2_pnl_lamp_right.BackColor = Color.LightGray;
            plc_dc3_pnl_lamp_right.BackColor = Color.LightGray;
            plc_dc1_pnl_lamp_lihop.BackColor = Color.LightGray;
            plc_dc2_pnl_lamp_lihop.BackColor = Color.LightGray;
            plc_dc3_pnl_lamp_lihop.BackColor = Color.LightGray;
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

        private async void timer1_Tick(object sender, EventArgs e)
        {
            await Task.Factory.StartNew(()=> 
            {
                if (Form1.plcConnected == true)
                {
                    if (Form1.loadConfigFinsh == true)
                    {
                        int left1 = PLCCom.getDevice("M670");
                        int right1 = PLCCom.getDevice("M671");
                        int lyhop1 = PLCCom.getDevice("M672");

                        if (left1 == 1)
                            plc_dc1_pnl_lamp_left.BackColor = Color.Green;
                        else
                            plc_dc1_pnl_lamp_left.BackColor = Color.LightGray;
                        if (right1 == 1)
                            plc_dc1_pnl_lamp_right.BackColor = Color.Green;
                        else
                            plc_dc1_pnl_lamp_right.BackColor = Color.LightGray;
                        if (lyhop1 == 1)
                            plc_dc1_pnl_lamp_lihop.BackColor = Color.Green;
                        else
                            plc_dc1_pnl_lamp_lihop.BackColor = Color.LightGray;

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

                        int left3 = PLCCom.getDevice("M676");
                        int right3 = PLCCom.getDevice("M677");
                        int lyhop3 = PLCCom.getDevice("M678");

                        if (left3 == 1)
                            plc_dc3_pnl_lamp_left.BackColor = Color.Green;
                        else
                            plc_dc3_pnl_lamp_left.BackColor = Color.LightGray;
                        if (right3 == 1)
                            plc_dc3_pnl_lamp_right.BackColor = Color.Green;
                        else
                            plc_dc3_pnl_lamp_right.BackColor = Color.LightGray;
                        if (lyhop3 == 1)
                            plc_dc3_pnl_lamp_lihop.BackColor = Color.Green;
                        else
                            plc_dc3_pnl_lamp_lihop.BackColor = Color.LightGray;

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
                                        else if (data > 1 && data < 4)
                                            control.Text = StaticConfig.CheDoDieuKhien[1];
                                        else
                                            control.Text = "";
                                    }
                                    else
                                        control.Text = PLCCom.getInt32Device(item.plcAddress).ToString();

                                }
                                else
                                {
                                    control.Text = Math.Round(PLCCom.getDoubleDevice(item.plcAddress),2).ToString();
                                }
                            }
                        }
                    }

                    plc_dc1_sld_tocdo.Value = Convert.ToInt32(plc_dc1_lbl_tocdo.Text);
                    plc_dc1_sld_nhienlieu.Value = Convert.ToInt32(plc_dc1_lbl_luong_nhien_lieu.Text);
                    //plc_dc1_sld_apluckhi.Value = Convert.ToInt32(plc_dc1_lbl_apluc_khinap.Text);
                    plc_dc1_sld_TxakhiveA.Value = Convert.ToInt32(plc_dc1_lbl_nhietdo_khixaA.Text);
                    plc_dc1_sld_TxakhiveB.Value = Convert.ToInt32(plc_dc1_lbl_nhietdo_khixaB.Text);

                    plc_dc2_sld_tocdo.Value = Convert.ToInt32(plc_dc2_lbl_tocdo.Text);
                    plc_dc2_sld_nhienlieu.Value = Convert.ToInt32(plc_dc2_lbl_luong_nhien_lieu.Text);
                    //plc_dc2_sld_apluckhi.Value = Convert.ToInt32(plc_dc2_lbl_apluc_khinap.Text);
                    plc_dc2_sld_TxakhiveA.Value = Convert.ToInt32(plc_dc2_lbl_nhietdo_khixaA.Text);
                    plc_dc2_sld_TxakhiveB.Value = Convert.ToInt32(plc_dc2_lbl_nhietdo_khixaB.Text);

                    plc_dc3_sld_tocdo.Value = Convert.ToInt32(plc_dc3_lbl_tocdo.Text);
                    plc_dc3_sld_nhienlieu.Value = Convert.ToInt32(plc_dc3_lbl_luong_nhien_lieu.Text);
                    //plc_dc3_sld_apluckhi.Value = Convert.ToInt32(plc_dc3_lbl_apluc_khinap.Text);
                    plc_dc3_sld_TxakhiveA.Value = Convert.ToInt32(plc_dc3_lbl_nhietdo_khixaA.Text);
                    plc_dc3_sld_TxakhiveB.Value = Convert.ToInt32(plc_dc3_lbl_nhietdo_khixaB.Text);
                }
            });
            
            

            
        }
    }
}
