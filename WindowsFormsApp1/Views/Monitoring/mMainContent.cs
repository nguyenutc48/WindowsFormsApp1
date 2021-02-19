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
        public static List<Control> PageStore = new List<Control>();
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

            PageStoreLoad.Add(new PageControlModel() { PageControl = gsOverview.Instance, Title = "TỔNG QUAN HỆ THỐNG" });
            PageStoreLoad.Add(new PageControlModel() { PageControl = gsHethongDC.Instance, Title = "HỆ THỐNG ĐỘNG CƠ" });
            PageStoreLoad.Add(new PageControlModel() { PageControl = gsDongCo1.Instance, Title = "ĐỘNG CƠ 1" });
            PageStoreLoad.Add(new PageControlModel() { PageControl = gsDongCo2.Instance, Title = "ĐỘNG CƠ 2" });
            PageStoreLoad.Add(new PageControlModel() { PageControl = gsDongCo3.Instance, Title = "ĐỘNG CƠ 3" });

            foreach (var item in PageStoreLoad)
            {
                StaticConfig.LoadView(item.PageControl, pnlBodyData);
            }

            NextPage(PageStoreLoad[0].PageControl, PageStoreLoad[0].Title);
        }

        public void NextPage(Control control, string title)
        {
            PageStore.Add(control);
            StaticConfig.ShowView(control, pnlBodyData);
            lbl_title.Text = title;
            if (PageStore.Count == 1)
                pic_back_click.Enabled = false;
            else
                pic_back_click.Enabled = true;
        }

        private void pic_back_click_Click(object sender, EventArgs e)
        {
            var currentControl = PageStore[PageStore.Count - 1];
            var findControl = PageStoreLoad.Where(c => c.PageControl == currentControl).FirstOrDefault();
            if(findControl !=null)
                NextPage(findControl.PageControl, findControl.Title);
        }

        private void pic_home_click_Click(object sender, EventArgs e)
        {
            PageStore.RemoveRange(1, PageStore.Count - 1);
            StaticConfig.ShowView(PageStore[0], pnlBodyData);
        }
    }
}
