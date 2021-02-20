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
        public mMainContent()
        {
            InitializeComponent();

            PageStoreLoad.Add(new PageControlModel() { Index = PAGE.HOME, PageControl = gsOverview.Instance, Title = "TỔNG QUAN HỆ THỐNG" });
            PageStoreLoad.Add(new PageControlModel() { Index = PAGE.HE_THONG_DONG_CO, PageControl = gsHethongDC.Instance, Title = "HỆ THỐNG ĐỘNG CƠ" }) ;
            PageStoreLoad.Add(new PageControlModel() { Index = PAGE.DONG_CO_1, PageControl = gsDongCo1.Instance, Title = "ĐỘNG CƠ 1" });
            PageStoreLoad.Add(new PageControlModel() { Index = PAGE.DONG_CO_2, PageControl = gsDongCo2.Instance, Title = "ĐỘNG CƠ 2" });
            PageStoreLoad.Add(new PageControlModel() { Index = PAGE.DONG_CO_3, PageControl = gsDongCo3.Instance, Title = "ĐỘNG CƠ 3" });

            foreach (var item in PageStoreLoad)
            {
                StaticConfig.LoadView(item.PageControl, pnlBodyData);
            }

            NextPage(PAGE.HOME);
        }

        public void NextPage(int index)
        {
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
            var findControl = PageStoreLoad.Where(c => c.Index == currentControl).FirstOrDefault();
            if (findControl != null)
            {
                StaticConfig.ShowView(findControl.PageControl, pnlBodyData);
                lbl_title.Text = findControl.Title;
            }
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
            var findControl = PageStoreLoad.Where(c => c.Index == PAGE.HOME).FirstOrDefault();
            if (findControl != null)
            {
                StaticConfig.ShowView(findControl.PageControl, pnlBodyData);
                lbl_title.Text = findControl.Title;
            }
            PageStore.RemoveRange(1, PageStore.Count -1);
            if (PageStore.Count == 1)
                pic_back_click.Enabled = false;
            else
                pic_back_click.Enabled = true;
        }
    }
}
