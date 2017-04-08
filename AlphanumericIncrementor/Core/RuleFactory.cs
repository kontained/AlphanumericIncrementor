using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using AlphanumericIncrementor.Rules;

namespace AlphanumericIncrementor.Core
{
    public class RuleFactory : IRuleFactory
    {
        private readonly IDictionary<Regex, Rule> _rules;

        public RuleFactory()
        {
            _rules = new Dictionary<Regex, Rule>
            {
                { new Regex("^[0-9]{1}"), new AlphanumericIncrementor.Rules.Numeric() },
                { new Regex("^[a-zA-Z]{1}$"), new AlphanumericIncrementor.Rules.Alpha() }
            };
        }

        public Rule GetIncrementRule(char input)
        {
            if (Char.IsWhiteSpace(input) || input == '\0')
            {
                throw new ArgumentNullException("Null value passed into AlphanumericIncrementor.Core.RuleFactory.GetIncrementRule");
            }
            return _rules.Where(x => x.Key.Match(input.ToString()).Success).FirstOrDefault().Value;
        }
    }
}
