using System.Text.RegularExpressions;

namespace ReproRegex.Lib
{
    public static class Parser
    {
        private static readonly Regex ProjectKeyRegEx = new Regex(@"^[a-zA-Z0-9:\-_\.]*[a-zA-Z:\-_\.]+[a-zA-Z0-9:\-_\.]*$", RegexOptions.Compiled | RegexOptions.Singleline);

        public static bool IsMatch(string value) =>
           ProjectKeyRegEx.IsMatch(value);
    }
}