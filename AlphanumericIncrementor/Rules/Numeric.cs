using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AlphanumericIncrementor.Rules
{
    public class Numeric : Rule
    {
        private IDictionary<Regex, char> _numberConversions;

        public Numeric()
        {
            _numberConversions = new Dictionary<Regex, char>
            {
                { new Regex("^[9]{1}$"), 'A' },
                { new Regex("^[0]{1}$"), '1' },
                { new Regex("^[1]{1}$"), '2' },
                { new Regex("^[2]{1}$"), '3' },
                { new Regex("^[3]{1}$"), '4' },
                { new Regex("^[4]{1}$"), '5' },
                { new Regex("^[5]{1}$"), '6' },
                { new Regex("^[6]{1}$"), '7' },
                { new Regex("^[7]{1}$"), '8' },
                { new Regex("^[8]{1}$"), '9' }
            };
        }

        public override char Increment(char input)
        {
            if (Char.IsWhiteSpace(input) || input == '\0')
            {
                throw new ArgumentNullException("Null value passed into AlphanumericIncrementor.Rules.Numeric.Increment!");
            }
            return _numberConversions.Where(x => x.Key.Match(input.ToString()).Success).FirstOrDefault().Value;
        }
    }
}
