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

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lpcom_ReferencesProgType = new ActProgTypeLib.ActProgTypeClass();
            lpcom_ReferencesUtlType = new ActUtlTypeLib.ActUtlTypeClass();
            // Create EventHandler(ActUtlType)
            lpcom_ReferencesUtlType.OnDeviceStatus +=
                new ActUtlTypeLib._IActUtlTypeEvents_OnDeviceStatusEventHandler(ActUtlType1_OnDeviceStatus);
            /**************************************************************************/
        }
        private void ActUtlType1_OnDeviceStatus(String szDevice, int iData, int iReturnCode)
        {
            System.String[] arrData;	        //Array for 'Data'
            //Assign the array for the read data.
            arrData = new System.String[txt_Data.Lines.Length + 1];

            //Copy the read data to the 'arrData'.
            Array.Copy(txt_Data.Lines, arrData, txt_Data.Lines.Length);

            //Add the content of new event to arrData.
            arrData[txt_Data.Lines.Length]
            = String.Format("OnDeviceStatus event by ActUtlType [{0}={1}]", szDevice, iData);

            //The new 'Data' is displayed.
            txt_Data.Lines = arrData;

            //The return code of the method is displayed by the hexadecimal.
            txt_ReturnCode.Text = String.Format("0x{0:x8}", iReturnCode);

        }
    }
}
