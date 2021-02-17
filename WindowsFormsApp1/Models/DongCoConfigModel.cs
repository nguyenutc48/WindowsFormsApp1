using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class DongCoConfigModel
    {
        public string ParameterName { get; set; }
        public string PLCAddress { get; set; }
        public int SizeAddress { get; set; }
        public string TypeAddress { get; set; }
        public string SpeedLevel { get; set; }
        public string ParameterValue { get; set; }
    }
}
