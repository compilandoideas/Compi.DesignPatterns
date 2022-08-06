using Compi.DesignPatterns.Rules.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compi.DesignPatterns.Rules.Rules
{

    public class IsStartShift : IRule
    {
        public Record Evaluate(Record record)
        {

            if (record.ShiftEntry > record.ShiftDeparture)
            {
                record.IsEndShift = true;
             
            }

            return record;
        }

        public bool ShouldRun(Record record)
        {
            return record.IsStartShift ? record.IsEndShift : false;
        }
    }
}
