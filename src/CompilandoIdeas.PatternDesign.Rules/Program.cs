using CompilandoIdeas.PatternDesign.Rules.Rules;
using System;
using System.Collections.Generic;

namespace CompilandoIdeas.PatternDesign.Rules
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var record = new Record();

            //var ruleType = typeof(IRule);
            //IEnumerable<IRule> rules = GetType().Assembly.GetTypes()
            //    .Where(p => ruleType.IsAssignableFrom(p) && !p.IsInterface)
            //    .Select(r => Activator.CreateInstance(r) as IRule);

            List<IRule> rules = new List<IRule>();

            rules.Add(new IsStartShift());

            var engine = new RuleEngine(rules);

            var result =  engine.Calculate(record);

            Console.WriteLine($"{result}");
        }
    }
}
