using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views.Setting
{
    public partial class sConfigMain : UserControl
    {
        
        string amthanhPath = "";
        string dongco1Path = "";
        string dongco2Path = "";
        string dongco3Path = "";

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
            lblAmthanhPath.Text = "";
            lblDongco1Path.Text = "";
            lblDongco2Path.Text = "";
            lblDongco3Path.Text = "";
        }

        private void btnClickChonfileConfig(object sender, EventArgs e)
        {
            var btn = sender as Button;
            string btnName = btn.Name;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Title = "Chọn File Config";
            openFileDialog.DefaultExt = "xlsx";
            openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (btnName)
                {
                    case "btnChonfileAmthanh":
                        amthanhPath = openFileDialog.FileName;
                        lblAmthanhPath.Text = amthanhPath;
                        break;
                    case "btnChonfileDC1":
                        dongco1Path = openFileDialog.FileName;
                        lblDongco1Path.Text = dongco1Path;
                        break;
                    case "btnChonfileDC2":
                        dongco2Path = openFileDialog.FileName;
                        lblDongco2Path.Text = dongco2Path;
                        break;
                    case "btnChonfileDC3":
                        dongco3Path = openFileDialog.FileName;
                        lblDongco3Path.Text = dongco3Path;
                        break;
                }
            }
        }

        private async void btnClickLuuConfig(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer myPlayer = new System.Media.SoundPlayer();
            //myPlayer.SoundLocation = "D:\\HMI C#\\sample.wav";
            //myPlayer.Play();
            var btn = sender as Button;
            string btnName = btn.Name;
            switch (btnName)
            {
                case "btnLuuAmthanh":
                    if (!string.IsNullOrEmpty(lblAmthanhPath.Text))
                    {
                        string[,] readData;
                        if (File.Exists(amthanhPath))
                        {
                            btnLuuAmthanh.Enabled = false;
                            await Task.Factory.StartNew(() =>
                            {
                                NFILEHELPER.ExcelHelper.Read(amthanhPath, out readData);
                                List<AmThanhModel> ListAmThanh = new List<AmThanhModel>();
                                var a = Application.StartupPath;
                                var temp = Path.Combine(a, "AmThanh");

                                if (!Directory.Exists(temp))
                                    Directory.CreateDirectory(temp);
                                
                                var files = Directory.GetFiles(temp);
                                if (files.Length > 0)
                                {
                                    for (int i = 1; i < readData.GetLength(0); i++)
                                    {
                                        AmThanhModel amThanhModel = new AmThanhModel();
                                        amThanhModel.Index = Convert.ToInt16(readData[i, 0]);
                                        amThanhModel.TocdoTien = readData[i, 1] == null ? "" : readData[i, 1].ToString();
                                        amThanhModel.TocdoLui = readData[i, 2] == null ? "" : readData[i, 2].ToString();

                                        amThanhModel.TenFile = readData[i, 3] == null ? "" : readData[i, 3].ToString();
                                        ListAmThanh.Add(amThanhModel);
                                    }
                                    Form1.AmThanhModel = ListAmThanh;
                                    MessageBox.Show("Lưu file âm thanh thành công");
                                }
                                else
                                {
                                    MessageBox.Show("Bạn cần đưa file âm thanh vào trong đường dẫn: \n" + temp);
                                }

                            });
                            btnLuuAmthanh.Enabled = true;

                        }
                        else
                        {
                            MessageBox.Show("File không tồn tại");
                        }
                    }
                    else
                        MessageBox.Show("Bạn chưa chọn file");
                    break;
                case "btnLuuDC1":
                    if (!string.IsNullOrEmpty(lblDongco1Path.Text))
                    {
                        string[,] readData;
                        if (File.Exists(dongco1Path))
                        {
                            btnLuuDC1.Enabled = false;
                            await Task.Factory.StartNew(() =>
                            {
                                NFILEHELPER.ExcelHelper.Read(dongco1Path, out readData);
                                List<DongCoConfigModel> TempList = new List<DongCoConfigModel>();
                                for (int i = 1; i < readData.GetLength(0); i++)
                                {
                                    DongCoConfigModel dongco = new DongCoConfigModel();
                                    dongco.Index = readData[i, 0] == null ? 0 : Convert.ToInt16(readData[i, 0]);
                                    dongco.SizeAddress = readData[i, 3] == null ? 32 : Convert.ToInt16(readData[i, 3]);
                                    dongco.PLCAddress = readData[i, 1] == null ? "" : readData[i, 1].ToString();
                                    dongco.TypeAddress = readData[i, 2] == null ? "" : readData[i, 2].ToString();
                                    dongco.SpeedLevel = readData[i, 4] == null ? "" : readData[i, 4].ToString();
                                    dongco.ParameterName = readData[i, 5] == null ? "" : readData[i, 5].ToString();
                                    if (readData[i, 2] == "Integer")
                                    {
                                        if(readData[i, 6] != null)
                                        {
                                            var temp = readData[i, 6].ToString().Trim().Split('.');
                                            dongco.ParameterValue = temp[0].ToString();
                                        }
                                        else
                                            dongco.ParameterValue =  "0";
                                    }
                                    
                                    TempList.Add(dongco);
                                }
                                foreach (var addr in TempList)
                                {
                                    if (addr.TypeAddress == "Integer")
                                    {
                                        Form1.PLC.setInt32Device(addr.PLCAddress, Convert.ToInt32(addr.ParameterValue));
                                    }
                                    else
                                    {
                                        Form1.PLC.setDoubleDevice(addr.PLCAddress, Convert.ToDouble(addr.ParameterValue));
                                    }
                                }

                                Form1.DongCoAdress.AddRange(TempList);
                            });
                            btnLuuDC2.Enabled = true;
                            MessageBox.Show("Lưu file cài đặt thông số cho động cơ 1 thành công");

                        }
                    }
                    else
                        MessageBox.Show("Bạn chưa chọn file");
                    break;
                case "btnLuuDC2":
                    if (!string.IsNullOrEmpty(lblDongco2Path.Text))
                    {
                        string[,] readData;
                        if (File.Exists(dongco2Path))
                        {
                            btnLuuDC2.Enabled = false;
                            await Task.Factory.StartNew(() =>
                            {
                                NFILEHELPER.ExcelHelper.Read(dongco2Path, out readData);
                                List<DongCoConfigModel> TempList = new List<DongCoConfigModel>();
                                for (int i = 1; i < readData.GetLength(0); i++)
                                {
                                    DongCoConfigModel dongco = new DongCoConfigModel();
                                    dongco.Index = readData[i, 0] == null ? 0 : Convert.ToInt16(readData[i, 0]);
                                    dongco.SizeAddress = readData[i, 3] == null ? 32 : Convert.ToInt16(readData[i, 3]);
                                    dongco.PLCAddress = readData[i, 1] == null ? "" : readData[i, 1].ToString();
                                    dongco.TypeAddress = readData[i, 2] == null ? "" : readData[i, 2].ToString();
                                    dongco.SpeedLevel = readData[i, 4] == null ? "" : readData[i, 4].ToString();
                                    dongco.ParameterName = readData[i, 5] == null ? "" : readData[i, 5].ToString();
                                    if (readData[i, 2] == "Integer")
                                    {
                                        if (readData[i, 6] != null)
                                        {
                                            var temp = readData[i, 6].ToString().Trim().Split('.');
                                            dongco.ParameterValue = temp[0].ToString();
                                        }
                                        else
                                            dongco.ParameterValue = "0";
                                    }
                                    TempList.Add(dongco);
                                }
                                foreach (var addr in TempList)
                                {
                                    if (addr.TypeAddress == "Integer")
                                    {
                                        Form1.PLC.setInt32Device(addr.PLCAddress, Convert.ToInt32(addr.ParameterValue));
                                    }
                                    else
                                    {
                                        Form1.PLC.setDoubleDevice(addr.PLCAddress, Convert.ToDouble(addr.ParameterValue));
                                    }
                                }
                                Form1.DongCoAdress.AddRange(TempList);
                            });
                            btnLuuDC2.Enabled = true;
                            MessageBox.Show("Lưu file cài đặt thông số cho động cơ 2 thành công");
                        }
                    }
                    else
                        MessageBox.Show("Bạn chưa chọn file");
                    break;
                case "btnLuuDC3":
                    if (!string.IsNullOrEmpty(lblDongco3Path.Text))
                    {
                        string[,] readData;
                        if (File.Exists(dongco3Path))
                        {
                            btnLuuDC3.Enabled = false;
                            await Task.Factory.StartNew(() =>
                            {
                                NFILEHELPER.ExcelHelper.Read(dongco3Path, out readData);
                                List<DongCoConfigModel> TempList = new List<DongCoConfigModel>();
                                for (int i = 1; i < readData.GetLength(0); i++)
                                {
                                    DongCoConfigModel dongco = new DongCoConfigModel();
                                    dongco.Index = readData[i, 0] == null ? 0 : Convert.ToInt16(readData[i, 0]);
                                    dongco.SizeAddress = readData[i, 3] == null ? 32 : Convert.ToInt16(readData[i, 3]);
                                    dongco.PLCAddress = readData[i, 1] == null ? "" : readData[i, 1].ToString();
                                    dongco.TypeAddress = readData[i, 2] == null ? "" : readData[i, 2].ToString();
                                    dongco.SpeedLevel = readData[i, 4] == null ? "" : readData[i, 4].ToString();
                                    dongco.ParameterName = readData[i, 5] == null ? "" : readData[i, 5].ToString();
                                    if (readData[i, 2] == "Integer")
                                    {
                                        if (readData[i, 6] != null)
                                        {
                                            var temp = readData[i, 6].ToString().Trim().Split('.');
                                            dongco.ParameterValue = temp[0].ToString();
                                        }
                                        else
                                            dongco.ParameterValue = "0";
                                    }

                                    TempList.Add(dongco);
                                }
                                foreach (var addr in TempList)
                                {
                                    if (addr.TypeAddress == "Integer")
                                    {
                                        Form1.PLC.setInt32Device(addr.PLCAddress, Convert.ToInt32(addr.ParameterValue));
                                    }
                                    else
                                    {
                                        Form1.PLC.setDoubleDevice(addr.PLCAddress, Convert.ToDouble(addr.ParameterValue));
                                    }
                                }
                                Form1.DongCoAdress.AddRange(TempList);
                            });
                            btnLuuDC3.Enabled = true;
                            MessageBox.Show("Lưu file cài đặt thông số cho động cơ 3 thành công");

                        }
                    }
                    else
                        MessageBox.Show("Bạn chưa chọn file");
                    break;
                default:
                    break;
            }
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            //WMPLib.WindowsMediaPlayer wplayer1 = new WMPLib.WindowsMediaPlayer();
            //wplayer1.URL = @"D:\\HMI C#\\sample1.wav";
            //wplayer1.controls.play();
            btnConnect.Enabled = false;
            await Task.Factory.StartNew(()=> {
                if (Form1.plcConnected == false)
                {
                    var result = Form1.PLC.Open(PLC_MITSU_CONFIG.PLC_UNIT_TYPE.UNIT_FXCPU);
                    if (result == 0)
                    {
                        Form1.plcConnected = true;
                        MessageBox.Show("Kết nối thành công!");
                    }
                    else
                    {
                        Form1.plcConnected = false;
                        MessageBox.Show("Kết nối không thành công!");
                    }
                }
            });
            btnConnect.Enabled = true;
   
        }

        private async void btnDisconnect_Click(object sender, EventArgs e)
        {
            //WMPLib.WindowsMediaPlayer wplayer1 = new WMPLib.WindowsMediaPlayer();
            //wplayer1.URL = @"D:\\HMI C#\\sample1.wav";
            //wplayer1.controls.play();
            btnDisconnect.Enabled = false;
            await Task.Factory.StartNew(() => {
                if (Form1.plcConnected == true)
                {
                    var result = Form1.PLC.Close();
                    if (result == 0)
                    {
                        Form1.plcConnected = false;
                        MessageBox.Show("Đã ngắt kết nối!");
                    }
                    else
                        MessageBox.Show("Không thể ngắt kết nối!");
                }
            });
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Form1.plcConnected == false)
            {
                lbltrangthai.Text = "Đang không kết nối với PLC";
                //btnLuuDC1.Enabled = false;
                //btnLuuDC2.Enabled = false;
                //btnLuuDC3.Enabled = false;
            }
            else
            {
                lbltrangthai.Text = "Đã kết nối với PLC";
                //btnLuuDC1.Enabled = true;
                //btnLuuDC2.Enabled = true;
                //btnLuuDC3.Enabled = true;
            }
        }
    }
}
