using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class StaticConfig
    {
        public static void moveSidePanel(Control btn, Panel pnl_Content)
        {
            pnl_Content.Top = btn.Top;
            pnl_Content.Height = btn.Height;
        }
        public static void transferData(Control control, Panel pnl_Content)
        {
            if (!pnl_Content.Controls.Contains(control))
            {
                pnl_Content.Controls.Add(control);
                control.Dock = DockStyle.Fill;
                control.Visible = false;
            }
        }
        public static void AddControlsToPanel(Control c, Panel pnl_Content)
        {
            c.Dock = DockStyle.Fill;
            pnl_Content.Controls.Clear();
            pnl_Content.Controls.Add(c);
        }
    }
}
