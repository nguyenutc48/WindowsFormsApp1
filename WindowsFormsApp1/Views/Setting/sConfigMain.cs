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
                        if(File.Exists(amthanhPath))
                        {
                            await Task.Factory.StartNew(() =>
                            {
                                NFILEHELPER.ExcelHelper.Read(amthanhPath, out readData);
                                List<AmThanhModel> ListAmThanh = new List<AmThanhModel>();
                                for (int i = 1; i < readData.GetLength(0); i++)
                                {
                                    AmThanhModel amThanhModel = new AmThanhModel();
                                    amThanhModel.Index = Convert.ToInt16(readData[i, 0]);
                                    amThanhModel.TocdoTien = readData[i, 1]==null? "" : readData[i, 1].ToString();
                                    amThanhModel.TocdoLui = readData[i, 2]==null? "": readData[i, 2].ToString();
                                    amThanhModel.TenFile = readData[i, 3]==null?"": readData[i, 3].ToString();
                                    ListAmThanh.Add(amThanhModel);
                                }
                                Form1.AmThanhModel = ListAmThanh;
                            });
                            MessageBox.Show("Lưu file âm thanh thành công");

                        }
                    }
                    break;
                case "btnLuuDC1":
                    if (!string.IsNullOrEmpty(lblDongco1Path.Text))
                    {
                        string[,] readData;
                        if (File.Exists(dongco1Path))
                        {
                            await Task.Factory.StartNew(() =>
                            {
                                NFILEHELPER.ExcelHelper.Read(dongco1Path, out readData);
                                List<DongCoConfigModel> TempList = new List<DongCoConfigModel>();
                                for (int i = 1; i < readData.GetLength(0); i++)
                                {
                                    DongCoConfigModel dongco = new DongCoConfigModel();
                                    dongco.SizeAddress = Convert.ToInt16(readData[i, 2]);
                                    dongco.PLCAddress = readData[i, 0] == null ? "" : readData[i, 0].ToString();
                                    dongco.TypeAddress = readData[i, 1] == null ? "" : readData[i, 1].ToString();
                                    dongco.SpeedLevel = readData[i, 3] == null ? "" : readData[i, 3].ToString();
                                    dongco.ParameterName = readData[i, 4] == null ? "" : readData[i, 4].ToString();
                                    dongco.ParameterValue = readData[i, 5] == null ? "" : readData[i, 5].ToString();
                                    TempList.Add(dongco);
                                }
                                Form1.DongCo1Adress = TempList;
                            });
                            MessageBox.Show("Lưu file cài đặt thông số cho động cơ 1 thành công");

                        }
                    }
                    break;
                case "btnLuuDC2":
                    if (!string.IsNullOrEmpty(lblDongco2Path.Text))
                    {
                        string[,] readData;
                        if (File.Exists(dongco2Path))
                        {
                            await Task.Factory.StartNew(() =>
                            {
                                NFILEHELPER.ExcelHelper.Read(dongco2Path, out readData);
                                List<DongCoConfigModel> TempList = new List<DongCoConfigModel>();
                                for (int i = 1; i < readData.GetLength(0); i++)
                                {
                                    DongCoConfigModel dongco = new DongCoConfigModel();
                                    dongco.SizeAddress = Convert.ToInt16(readData[i, 2]);
                                    dongco.PLCAddress = readData[i, 0] == null ? "" : readData[i, 0].ToString();
                                    dongco.TypeAddress = readData[i, 1] == null ? "" : readData[i, 1].ToString();
                                    dongco.SpeedLevel = readData[i, 3] == null ? "" : readData[i, 3].ToString();
                                    dongco.ParameterName = readData[i, 4] == null ? "" : readData[i, 4].ToString();
                                    dongco.ParameterValue = readData[i, 5] == null ? "" : readData[i, 5].ToString();
                                    TempList.Add(dongco);
                                }
                                Form1.DongCo2Adress = TempList;
                            });
                            MessageBox.Show("Lưu file cài đặt thông số cho động cơ 2 thành công");
                        }    
                    }
                    break;
                case "btnLuuDC3":
                    if (!string.IsNullOrEmpty(lblDongco3Path.Text))
                    {
                        string[,] readData;
                        if (File.Exists(dongco3Path))
                        {
                            await Task.Factory.StartNew(() =>
                            {
                                NFILEHELPER.ExcelHelper.Read(dongco3Path, out readData);
                                List<DongCoConfigModel> TempList = new List<DongCoConfigModel>();
                                for (int i = 1; i < readData.GetLength(0); i++)
                                {
                                    DongCoConfigModel dongco = new DongCoConfigModel();
                                    dongco.SizeAddress = Convert.ToInt16(readData[i, 2]);
                                    dongco.PLCAddress = readData[i, 0] == null ? "" : readData[i, 0].ToString();
                                    dongco.TypeAddress = readData[i, 1] == null ? "" : readData[i, 1].ToString();
                                    dongco.SpeedLevel = readData[i, 3] == null ? "" : readData[i, 3].ToString();
                                    dongco.ParameterName = readData[i, 4] == null ? "" : readData[i, 4].ToString();
                                    dongco.ParameterValue = readData[i, 5] == null ? "" : readData[i, 5].ToString();
                                    TempList.Add(dongco);
                                }
                                Form1.DongCo3Adress = TempList;
                            });
                            MessageBox.Show("Lưu file cài đặt thông số cho động cơ 3 thành công");

                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
