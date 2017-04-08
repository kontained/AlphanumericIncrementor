using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphanumericIncrementor.Core
{
    public interface IFormatter
    {
        /// <summary>
        /// Builds the incremented alphanumeric string to be output
        /// </summary>
        /// <param name="input">Inital value</param>
        /// <param name="incrementedChars">Incremented characters</param>
        /// <returns>Incremented alphanumeric string</returns>
        string Format(string input, char[] incrementedChars);
    }
}
