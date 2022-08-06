using CompilandoIdeas.PatternDesign.Rules.Rules;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CompilandoIdeas.PatternDesign.Rules
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var record = new Record();
                             

            IEnumerable<IRule> rules = typeof(IRule).Assembly.GetTypes()
                .Where(x => typeof(IRule).IsAssignableFrom(x) && !x.IsInterface)
                .Select(x => Activator.CreateInstance(x) as IRule);



            //rules.Add(new IsStartShift());

            var engine = new RuleEngine(rules);

            var result =  engine.Calculate(record);

            Console.WriteLine($"{result}");
        }
    }
}
