using PLC_MITSU_CONFIG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class PLCCom
    {
        public static ActUtlTypeLib.ActUtlTypeClass plc;

        

        /// <summary>
        /// Open connect to PLC by USB cable
        /// </summary>
        /// <param name="unit_type">Unit type of PLC, please check in NPLCMitsuConfig on nuget.org</param>
        /// <param name="time_out">Time of waiting connection</param>
        /// <returns>Code of return when connect, return 0 -> OK</returns>
        public static int Open(int stationNumber, int time_out = 3000)
        {
            plc = new ActUtlTypeLib.ActUtlTypeClass();
            plc.ActLogicalStationNumber = stationNumber;
            int iReturnCode;
            iReturnCode = plc.Open();
            return iReturnCode;
        }

        /// <summary>
        /// Close connect to PLC
        /// </summary>
        /// <returns>Return the code of action</returns>
        public static int Close()
        {
            int iReturnCode;
            try
            {
                iReturnCode = plc.Close();
                return iReturnCode;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        /// <summary>
        /// Get multi devices on list from PLC
        /// </summary>
        /// <param name="devices">List devices need to read from PLC</param>
        /// <param name="values">List devices return with value update</param>
        /// <returns>Return result when active read data from PLC</returns>
        public static int getDevices(List<plc_address> devices, out List<plc_address> values)
        {
            values = new List<plc_address>();
            int iReturnCode;				//Return code
            string szDeviceName = "";		//List data for 'DeviceName'
            int iNumberOfData = devices.Count;			//Data for 'DeviceSize'
            short[] arrDeviceValue;		    //Data for 'DeviceValue'

            foreach (var device in devices)
            {
                szDeviceName = szDeviceName + device.device + "\n";
            }

            arrDeviceValue = new short[iNumberOfData];
            try
            {
                iReturnCode = plc.ReadDeviceRandom2(szDeviceName, iNumberOfData, out arrDeviceValue[0]);
                for (int i = 0; i < arrDeviceValue.Length; i++)
                {
                    plc_address device = new plc_address();
                    device.device = devices[i].device;
                    device.value = arrDeviceValue[i].ToString();
                    values.Add(device);
                }
            }

            //Exception processing			
            catch (Exception)
            {
                //MessageBox.Show(exception.Message, Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                iReturnCode = -1;
            }

            return iReturnCode;
        }

        /// <summary>
        /// Set multi devices to PLC
        /// </summary>
        /// <param name="devices">List devices need to set to PLC</param>
        /// <returns>Return result when active read data from PLC</returns>
        public static int setDevices(ref List<plc_address> devices)
        {
            int iReturnCode;				//Return code
            string szDeviceName = "";		//List data for 'DeviceName'
            int iNumberOfData = devices.Count;			//Data for 'DeviceSize'
            short[] arrDeviceValue;		    //Data for 'DeviceValue'
            arrDeviceValue = new short[iNumberOfData];

            for (int i = 0; i < iNumberOfData; i++)
            {
                szDeviceName = szDeviceName + devices[i].device + "\n";
                if (!string.IsNullOrWhiteSpace(devices[i].value))
                {
                    arrDeviceValue[i] = Convert.ToInt16(devices[i].value);
                }
                else
                {
                    iReturnCode = -1;
                }

            }
            try
            {
                iReturnCode = plc.WriteDeviceRandom2(szDeviceName, iNumberOfData, ref arrDeviceValue[0]);
            }

            //Exception processing			
            catch (Exception)
            {
                //MessageBox.Show(exception.Message, Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                iReturnCode = -1;
            }

            return iReturnCode;
        }

        /// <summary>
        /// Read value in PLC
        /// </summary>
        /// <param name="name">PLC address</param>
        /// <returns>Current value of PLC address</returns>
        public static int getDevice(string name)
        {
            if (addressPLCCheck(name))
            {
                int resultDeviceValue = 0;
                int iReturnCode = plc.GetDevice(name.ToUpper(), out resultDeviceValue);
                if (iReturnCode != 0)
                {
                    return -1;
                }
                else
                {
                    return resultDeviceValue;
                }
            }
            else
                return -1;
        }

        /// <summary>
        /// Set value in PLC
        /// </summary>
        /// <param name="name">PLC address</param>
        /// <param name="value">Value of address</param>
        /// <returns>Return error or not</returns>
        public static int setDevice(string name, int value)
        {
            if (addressPLCCheck(name))
            {
                int resultDeviceValue = 0;
                int iReturnCode = plc.SetDevice(name.ToUpper(), value);
                if (iReturnCode != 0)
                {
                    return -1;
                }
                else
                {
                    return resultDeviceValue;
                }
            }
            else
                return -1;

        }

        /// <summary>
        /// Read float data of PLC
        /// </summary>
        /// <param name="name">First address of PLC register</param>
        /// <returns>Current value of PLC address</returns>
        public static double getDoubleDevice(string name)
        {
            if (addressPLCCheck(name))
            {
                int num_addr = getNumberOfAddr(name);
                string addr = name.Substring(0, 1);

                List<plc_address> plc_result = new List<plc_address>();
                List<plc_address> plc_Addresses = new List<plc_address>() { new plc_address() { device = addr + num_addr }, new plc_address() { device = addr + (num_addr + 1) } };
                getDevices(plc_Addresses, out plc_result);
                if (plc_result.Count > 1)
                {
                    int num1 = Convert.ToInt16(plc_result[0].value);
                    int num2 = Convert.ToInt16(plc_result[1].value);
                    return convertPLC2Double(num1, num2);
                }
                else
                    return -1;

            }
            else
                return -1;

        }

        /// <summary>
        /// Set value double of PLC register
        /// </summary>
        /// <param name="name">Address of PLC</param>
        /// <param name="value">Value need to set</param>
        /// <returns>Return error or not</returns>
        public static int setDoubleDevice(string name, double value)
        {
            if (addressPLCCheck(name))
            {
                int num_addr = getNumberOfAddr(name);
                string addr = name.Substring(0, 1);

                var value_set = convertDouble2PLC(value);
                List<plc_address> plc_Addresses = new List<plc_address>() { new plc_address() { device = addr + num_addr, value = value_set[0].ToString() }, new plc_address() { device = addr + (num_addr + 1), value = value_set[1].ToString() } };
                int result = setDevices(ref plc_Addresses);
                if (result != -1)
                {
                    return 0;
                }
                else
                    return -1;

            }
            else
                return -1;
        }

        /// <summary>
        /// get data int32
        /// </summary>
        /// <param name="name">PLC address</param>
        /// <returns>int32 value</returns>
        public static Int32 getInt32Device(string name)
        {
            if (addressPLCCheck(name))
            {
                int num_addr = getNumberOfAddr(name);
                string addr = name.Substring(0, 1);

                List<plc_address> plc_result = new List<plc_address>();
                List<plc_address> plc_Addresses = new List<plc_address>() { new plc_address() { device = addr + num_addr }, new plc_address() { device = addr + (num_addr + 1) } };
                getDevices(plc_Addresses, out plc_result);
                if (plc_result.Count > 1)
                {
                    int num1 = Convert.ToInt16(plc_result[0].value);
                    int num2 = Convert.ToInt16(plc_result[1].value);
                    return convertPLC2Int32(num1, num2);
                }
                else
                    return -1;

            }
            else
                return -1;
        }

        public static int getInt32(string name)
        {
            short[] data = new short[2];
            plc.ReadDeviceBlock2(name, 2, out data[0]);
            return ShortToInt(data[0], data[1]);
        }

        public static void setInt32(string name, int data)
        {
            int temp = Convert.ToInt32(data);
            plc.WriteDeviceRandom(name, 32, temp);
        }

        /// <summary>
        /// set value int32 to plc
        /// </summary>
        /// <param name="name">PLC address</param>
        /// <param name="value">value int32</param>
        /// <returns>Error value return</returns>
        public static int setInt32Device(string name, Int32 value)
        {
            if (addressPLCCheck(name))
            {
                int num_addr = getNumberOfAddr(name);
                string addr = name.Substring(0, 1);

                var value_set = convertInt32ToPLC(value);
                List<plc_address> plc_Addresses = new List<plc_address>() { new plc_address() { device = addr + num_addr, value = value_set[0].ToString() }, new plc_address() { device = addr + (num_addr + 1), value = value_set[1].ToString() } };
                int result = setDevices(ref plc_Addresses);
                if (result != -1)
                {
                    return 0;
                }
                else
                    return -1;

            }
            else
                return -1;
        }


        private static double convertPLC2Double(int i_num1, int i_num2)
        {
            var int_bytes1 = BitConverter.GetBytes(i_num1);
            var int_bytes2 = BitConverter.GetBytes(i_num2);
            Buffer.BlockCopy(int_bytes2, 0, int_bytes1, 2, 2);
            return Convert.ToDouble(BitConverter.ToSingle(int_bytes1, 0));
        }


        private static int[] convertDouble2PLC(double number)
        {
            float in_data = Convert.ToSingle(number);
            int[] data = new int[2];
            byte[] byte1 = new byte[4];
            byte[] byte2 = new byte[4];
            var data_byte = BitConverter.GetBytes(in_data);
            Buffer.BlockCopy(data_byte, 0, byte1, 0, 2);
            Buffer.BlockCopy(data_byte, 2, byte2, 0, 2);

            data[0] = BitConverter.ToInt16(byte1, 0);
            data[1] = BitConverter.ToInt16(byte2, 0);
            return data;
        }

        private static int[] convertInt32ToPLC(Int32 number)
        {
            Int32 in_data = Convert.ToInt32(number);
            int[] data = new int[2];
            byte[] byte1 = new byte[4];
            byte[] byte2 = new byte[4];
            var data_byte = BitConverter.GetBytes(in_data);
            Buffer.BlockCopy(data_byte, 0, byte1, 0, 2);
            Buffer.BlockCopy(data_byte, 2, byte2, 0, 2);

            data[0] = BitConverter.ToInt16(byte1, 0);
            data[1] = BitConverter.ToInt16(byte2, 0);
            return data;
        }

        private static Int32 convertPLC2Int32(int i_num1, int i_num2)
        {
            //int result = unchecked((int)(((uint)i_num1 << 16) | i_num2));
            var int_bytes1 = BitConverter.GetBytes(i_num1);
            var int_bytes2 = BitConverter.GetBytes(i_num2);
            Buffer.BlockCopy(int_bytes2, 0, int_bytes1, 2, 2);
            return (int)Convert.ToDouble(BitConverter.ToInt32(int_bytes1, 0));
        }

        private static bool addressPLCCheck(string name)
        {
            string check_regex = @"^\w{1}\d{1,5}$";
            if (Regex.IsMatch(name, check_regex))
            {
                return true;
            }
            return false;
        }

        private static int getNumberOfAddr(string name)
        {
            string temp = name.Substring(1);
            return Convert.ToInt32(temp);
        }

        private static int ShortToInt(short low, short hight)
        {
            byte[] bytesLow = BitConverter.GetBytes(low);
            byte[] bytesHight = BitConverter.GetBytes(hight);
            return BitConverter.ToInt32(new byte[] { bytesLow[0], bytesLow[1], bytesHight[0], bytesHight[1] }, 0);
        }
    }
}
