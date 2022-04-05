using System.Text.RegularExpressions;
namespace Packt.Shared
{
    public static class StringExtensions
    {
        public static bool IsValidEmail(this string input)
        {
            // use simple regular expresssion to check
            // that the input stirn is a valid email
            return Regex.IsMatch(input, @"[a-zA-Z0-9\.-_]+@[a-zA-Z0-9\.-_]+");
        }
    }
}