using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class AlarmModel
    {
        public string plcAddress { get; set; }
        public string AlarmName { get; set; }
        public DateTime TimeAlarm { get; set; }
    }
}
