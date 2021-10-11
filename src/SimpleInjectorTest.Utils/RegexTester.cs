using System.Text.RegularExpressions;

namespace SimpleInjectorTest.Utils
{
    public class RegexTester : IRegexTester
    {
        private readonly Regex numberRegex;
        public RegexTester()
        {
            numberRegex = new Regex("^\\d+$");
        }

        public bool IsNumberRegex(string value)
        {
            return numberRegex.IsMatch(value);
        }
    }
}
