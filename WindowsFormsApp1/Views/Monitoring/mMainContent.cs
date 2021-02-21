using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;


namespace WindowsFormsApp1.Views.Monitoring
{
    public partial class mMainContent : UserControl
    {
        private static List<int> PageStore = new List<int>();
        public static List<PageControlModel> PageStoreLoad = new List<PageControlModel>();
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
        PLCDataModel _plcClass = new PLCDataModel();
        public mMainContent()
        {
            InitializeComponent();

            PageStoreLoad.Add(new PageControlModel() { Index = PAGE.HOME, PageControl = gsOverview.Instance, Title = "TỔNG QUAN HỆ THỐNG" });
            PageStoreLoad.Add(new PageControlModel() { Index = PAGE.HE_THONG_DONG_CO, PageControl = gsHethongDC.Instance, Title = "HỆ THỐNG ĐỘNG CƠ" }) ;
            PageStoreLoad.Add(new PageControlModel() { Index = PAGE.DONG_CO_1, PageControl = gsDongCo1.Instance, Title = "ĐỘNG CƠ 1" });
            PageStoreLoad.Add(new PageControlModel() { Index = PAGE.DONG_CO_2, PageControl = gsDongCo2.Instance, Title = "ĐỘNG CƠ 2" });
            PageStoreLoad.Add(new PageControlModel() { Index = PAGE.DONG_CO_3, PageControl = gsDongCo3.Instance, Title = "ĐỘNG CƠ 3" });
            PageStoreLoad.Add(new PageControlModel() { Index = PAGE.DIAGRAM, PageControl = gsDiagram.Instance, Title = "SƠ ĐỒ KẾT NỐI" });
            PageStoreLoad.Add(new PageControlModel() { Index = PAGE.TONGQUAT, PageControl = gsTongQuan.Instance, Title = "MÁY PHÁT ĐIỆN" });

            foreach (var item in PageStoreLoad)
            {
                StaticConfig.LoadView(item.PageControl, pnlBodyData);
            }

            StaticConfig.ShowView(gsOverview.Instance, pnlBodyData);
            lbl_title.Text = PageStoreLoad[0].Title;
            PageStore.Add(PAGE.HOME);
        }

        public void NextPage(int index)
        {
            switch (index)
            {
                case PAGE.HE_THONG_DONG_CO:
                    gsHethongDC.Instance.StartGetData();
                    gsDongCo1.Instance.StopGetData();
                    gsDongCo2.Instance.StopGetData();
                    gsDongCo3.Instance.StopGetData();
                    gsTongQuan.Instance.StopGetData();
                    break;
                case PAGE.DONG_CO_1:
                    gsHethongDC.Instance.StopGetData();
                    gsDongCo1.Instance.StartGetData();
                    gsDongCo2.Instance.StopGetData();
                    gsDongCo3.Instance.StopGetData();
                    gsTongQuan.Instance.StopGetData();
                    break;
                case PAGE.DONG_CO_2:
                    gsHethongDC.Instance.StopGetData();
                    gsDongCo1.Instance.StopGetData();
                    gsDongCo2.Instance.StartGetData();
                    gsDongCo3.Instance.StopGetData();
                    gsTongQuan.Instance.StopGetData();
                    break;
                case PAGE.DONG_CO_3:
                    gsHethongDC.Instance.StopGetData();
                    gsDongCo1.Instance.StopGetData();
                    gsDongCo2.Instance.StopGetData();
                    gsDongCo3.Instance.StartGetData();
                    gsTongQuan.Instance.StopGetData();
                    break;
                case PAGE.TONGQUAT:
                    gsHethongDC.Instance.StopGetData();
                    gsDongCo1.Instance.StopGetData();
                    gsDongCo2.Instance.StopGetData();
                    gsDongCo3.Instance.StopGetData();
                    gsTongQuan.Instance.StartGetData();
                    break;
                default:
                    gsHethongDC.Instance.StopGetData();
                    gsDongCo1.Instance.StopGetData();
                    gsDongCo2.Instance.StopGetData();
                    gsDongCo3.Instance.StopGetData();
                    gsTongQuan.Instance.StopGetData();
                    break;
            }
            if (index != PAGE.HOME)
                PageStore.Add(index);
            
            var ctrNeedShow = PageStoreLoad.Where(c => c.Index == index).FirstOrDefault();
            if (ctrNeedShow != null)
            {
                StaticConfig.ShowView(ctrNeedShow.PageControl, pnlBodyData);
                lbl_title.Text = ctrNeedShow.Title;

                if (PageStore.Count == 1)
                    pic_back_click.Enabled = false;
                else
                    pic_back_click.Enabled = true;


            }
       
        }

        private void pic_back_click_Click(object sender, EventArgs e)
        {
            
            var currentControl = PageStore[PageStore.Count - 2];
            NextPage(currentControl);
            PageStore.RemoveAt(PageStore.Count-1);
            if (PageStore.Count == 1)
                pic_back_click.Enabled = false;
            else
                pic_back_click.Enabled = true;
        }

        private void pic_home_click_Click(object sender, EventArgs e)
        {
            if (PageStore.Count == 1)
                return;
            NextPage(PAGE.HOME);

            PageStore.RemoveRange(1, PageStore.Count -1);
            if (PageStore.Count == 1)
                pic_back_click.Enabled = false;
            else
                pic_back_click.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Form1.plcConnected == true)
            {
                int spdDC1 = PLCCom.getDevice("D4");
                int spdDC2 = PLCCom.getDevice("D54");
                int spdDC3 = PLCCom.getDevice("D104");
                plc_dc1_gau_tocdo.Value = spdDC1;
                plc_dc2_gau_tocdo.Value = spdDC2;
                plc_dc3_gau_tocdo.Value = spdDC3;
                plc_dc1_lbl_tocdo.Text = spdDC1.ToString();
                plc_dc2_lbl_tocdo.Text = spdDC2.ToString();
                plc_dc3_lbl_tocdo.Text = spdDC3.ToString();
            }
        }
    }
}
