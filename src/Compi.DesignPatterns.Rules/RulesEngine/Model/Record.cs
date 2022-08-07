using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compi.DesignPatterns.RulesEngine.Model
{
    public class Record
    {
        public bool IsStartShift { get; internal set; }
        public bool IsEndShift { get; internal set; }

        public DateTime ShiftEntry { get; set; }

        public DateTime ShiftDeparture { get; set; }
    }
}
