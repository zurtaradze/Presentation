namespace Presentation.Methods
{
    public static class StringExtensions
    {
        public static bool Validate(this string stg, int minlen, int maxlen)
        {
            return stg.Length >= minlen && stg.Length <= maxlen;
        }
    }
}
