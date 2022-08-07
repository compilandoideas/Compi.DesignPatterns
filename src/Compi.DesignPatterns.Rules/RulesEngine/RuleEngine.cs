using Compi.DesignPatterns.RulesEngine.Model;
using Compi.DesignPatterns.RulesEngine.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compi.DesignPatterns.RulesEngine
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
