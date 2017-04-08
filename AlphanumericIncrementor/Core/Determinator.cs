using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AlphanumericIncrementor.Core
{
    public class Determinator : IDeterminator
    {
        public char[] DetermineCharactersToIncrement(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentNullException("Null input passed to Alphanumeric.Core.Determinator.DetermineCharactersToIncrement!");
            }

            //Matches all of the 'special' increment scenarios
            //Example - "ACZ". We need to increment 'C' and 'Z'
            MatchCollection results = Regex.Matches(input, ".[zZ]{1,}$");

            //match not found, return the last character
            if (results.Count != 1)
            {
                return new char[] { input.Last() };
            }

            return results[0].Value.ToCharArray();
        }
    }
}
