using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private ActProgTypeLib.ActProgTypeClass lpcom_ReferencesProgType;
        private ActUtlTypeLib.ActUtlTypeClass lpcom_ReferencesUtlType;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PLCMitsuCom.PLCMitsu pLCMitsu = new PLCMitsuCom.PLCMitsu();
            //var result = pLCMitsu.Open(PLC_MITSU_CONFIG.PLC_UNIT_TYPE.UNIT_FXCPU);
            //MessageBox.Show(result.ToString());
            //Set the value of 'UnitType' to the property(UNIT_QNUSB).
            //lpcom_ReferencesProgType.ActUnitType = 0x000F;
            //Set the value of 'ProtocolType' to the property(PROTOCOL_USB).
            //lpcom_ReferencesProgType.ActProtocolType = 0x0D;
            //Set the value of 'Password'.


            //The Open method is executed.
            //var iReturnCode = lpcom_ReferencesProgType.Open();
            //MessageBox.Show(iReturnCode.ToString());

            //Set the value of 'LogicalStationNumber' to the property.
            lpcom_ReferencesUtlType.ActLogicalStationNumber = 1;


            //The Open method is executed.
            var iReturnCode = lpcom_ReferencesUtlType.Open();
            MessageBox.Show(iReturnCode.ToString());
            timer1.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lpcom_ReferencesProgType = new ActProgTypeLib.ActProgTypeClass();
            lpcom_ReferencesUtlType = new ActUtlTypeLib.ActUtlTypeClass();
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int data = Convert.ToInt32(textBox1.Text);
            lpcom_ReferencesUtlType.WriteDeviceRandom("D2000", 32, ref data);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int data = 0;
            lpcom_ReferencesUtlType.ReadDeviceRandom("D2000", 32, out data);
            textBox2.Text = data.ToString();
        }
    }
}
