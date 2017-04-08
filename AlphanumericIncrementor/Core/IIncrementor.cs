namespace AlphanumericIncrementor.Core
{
    public interface IIncrementor
    {
        /// <summary>
        /// Increments an alphanumeric string
        /// </summary>
        /// <param name="input">An alphanumeric string</param>
        /// <returns>Alphanumeric string</returns>
        string Increment(string input);
    }
}