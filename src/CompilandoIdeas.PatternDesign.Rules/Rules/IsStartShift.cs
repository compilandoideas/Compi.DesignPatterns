using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompilandoIdeas.PatternDesign.Rules.Rules
{
   
    public class IsStartShift : IRule
    {
        public Record Evaluate(Record record)
        {

            //TODO: add awesome rule
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
