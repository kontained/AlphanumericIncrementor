using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlphanumericIncrementor.Core;
using AlphanumericIncrementor.Rules;

namespace AlphanumericIncrementor.Core
{
    public class Incrementor : IIncrementor
    {
        private readonly IDeterminator _determinator;
        private readonly IFormatter _formatter;
        private readonly IRuleFactory _ruleFactory;

        public Incrementor(IDeterminator determinator, IFormatter formatter, IRuleFactory ruleFactory)
        {
            _determinator = determinator;
            _formatter = formatter;
            _ruleFactory = ruleFactory;
        }

        public string Increment(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentNullException("Null input passed to AlphanumericIncrementor.Increment!");
            }

            char[] charsToIncrement = _determinator.DetermineCharactersToIncrement(input);

            for (int i = 0; i < charsToIncrement.Length; i++)
            {
                Rule rule = _ruleFactory.GetIncrementRule(charsToIncrement[i]);
                charsToIncrement[i] = rule.Increment(charsToIncrement[i]);
            }

            return _formatter.Format(input, charsToIncrement);
        }
    }
}
