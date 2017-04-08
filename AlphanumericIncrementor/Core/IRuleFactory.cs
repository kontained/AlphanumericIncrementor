using AlphanumericIncrementor.Rules;

namespace AlphanumericIncrementor.Core
{
    public interface IRuleFactory
    {
        /// <summary>
        /// Returns the appropriate increment rule
        /// </summary>
        /// <param name="input">The character being incremented</param>
        /// <returns>Increment rule, or '\0' if unsuccessful</returns>
        Rule GetIncrementRule(char input);
    }
}
