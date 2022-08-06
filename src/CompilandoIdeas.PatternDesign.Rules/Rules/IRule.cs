using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompilandoIdeas.PatternDesign.Rules.Rules
{
    public interface IRule
    {
        Record Evaluate(Record record);
        bool ShouldRun(Record record);
    }
}
