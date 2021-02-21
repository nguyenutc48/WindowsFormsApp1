using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class ControlAddressModel
    {
        public int motorIndex { get; set; }
        public string plcAddress { get; set; }
        public string plcAddressType { get; set; }
        public string addressName { get; set; }
        public string controlName { get; set; }
    }
}
