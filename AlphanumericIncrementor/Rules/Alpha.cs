using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AlphanumericIncrementor.Rules
{
    public class Alpha : Rule
    {
        private IDictionary<Regex, Char> _alphaConversions;

        public Alpha()
        {
            _alphaConversions = new Dictionary<Regex, char>
            {
                { new Regex("^[aA]{1}$"), 'B' },
                { new Regex("^[bB]{1}$"), 'C' },
                { new Regex("^[cC]{1}$"), 'D' },
                { new Regex("^[dD]{1}$"), 'E' },
                { new Regex("^[eE]{1}$"), 'F' },
                { new Regex("^[fF]{1}$"), 'G' },
                { new Regex("^[gG]{1}$"), 'H' },
                { new Regex("^[hH]{1}$"), 'I' },
                { new Regex("^[iI]{1}$"), 'J' },
                { new Regex("^[jJ]{1}$"), 'K' },
                { new Regex("^[kK]{1}$"), 'L' },
                { new Regex("^[lL]{1}$"), 'M' },
                { new Regex("^[mM]{1}$"), 'N' },
                { new Regex("^[nN]{1}$"), 'O' },
                { new Regex("^[oO]{1}$"), 'P' },
                { new Regex("^[pP]{1}$"), 'Q' },
                { new Regex("^[qQ]{1}$"), 'R' },
                { new Regex("^[rR]{1}$"), 'S' },
                { new Regex("^[sS]{1}$"), 'T' },
                { new Regex("^[tT]{1}$"), 'U' },
                { new Regex("^[uU]{1}$"), 'V' },
                { new Regex("^[vV]{1}$"), 'W' },
                { new Regex("^[wW]{1}$"), 'X' },
                { new Regex("^[xX]{1}$"), 'Y' },
                { new Regex("^[yY]{1}$"), 'Z' },
                { new Regex("^[zZ]{1}$"), '0' }
            };
        }

        public override char Increment(char input)
        {
            if (Char.IsWhiteSpace(input) || input == '\0')
            {
                throw new ArgumentNullException("Null value passed into AlphanumericIncrementor.Rules.Alpha.Increment!");
            }
            return _alphaConversions.Where(x => x.Key.Match(input.ToString()).Success).FirstOrDefault().Value;
        }
    }
}
