using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphanumericIncrementor.Core
{
    public interface IDeterminator
    {
        /// <summary>
        /// Returns an array of characters that are eligible for incrementation.
        /// </summary>
        /// <param name="value">Characters to be incremented</param>
        /// <returns>Array of the incremented characters</returns>
        char[] DetermineCharactersToIncrement(string value);
    }
}
