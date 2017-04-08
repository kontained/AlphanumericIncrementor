using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphanumericIncrementor.Rules
{
    public abstract class Rule
    {
        /// <summary>
        /// Increments the single char input
        /// </summary>
        /// <param name="input">Char to be incremented</param>
        /// <returns>Incremented char, or '\0' if increment was unsuccessful</returns>
        public abstract char Increment(char input);
    }
}
