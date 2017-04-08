using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphanumericIncrementor.Core
{
    public class Formatter : IFormatter
    {
        public string Format(string input, char[] incrementedChars)
        {
            if (String.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentNullException("Null input passed to AlphanumericIncrementor.Core.Formatter.Format!");
            }

            if (!incrementedChars.Any())
            {
                throw new ArgumentNullException("Empty incrementedChars passed to AlphanumericIncrementor.Core.Formatter.Format!");
            }

            StringBuilder sb = new StringBuilder(input);
            int index = ((sb.Length - 1) - (incrementedChars.Length - 1));
            sb.Remove(index, incrementedChars.Length);
            sb.Insert(index, incrementedChars);
            return sb.ToString();
        }
    }
}
