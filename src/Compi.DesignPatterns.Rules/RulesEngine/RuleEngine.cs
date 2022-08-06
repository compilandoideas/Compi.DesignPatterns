using Compi.DesignPatterns.Rules.Model;
using Compi.DesignPatterns.Rules.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compi.DesignPatterns.Rules
{
    public class RuleEngine
    {
        private readonly IEnumerable<IRule> _rules;

        public RuleEngine(IEnumerable<IRule> rules)
        {
            _rules = rules;
        }

        public Record Calculate(Record record)
        {

            foreach (var rule in _rules)
            {
                if (rule.ShouldRun(record))
                    record = rule.Evaluate(record);
            }

            return record;
        }
    }
}
