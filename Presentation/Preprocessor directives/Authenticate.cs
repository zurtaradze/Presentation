namespace Presentation.Preprocessor_directives
{
    public class Authenticate
    {
        public static bool IsAuthenticated(string username, string password)
        {
#if DEBUG
            return true;
#endif
            // do some work
        }
    }
}
