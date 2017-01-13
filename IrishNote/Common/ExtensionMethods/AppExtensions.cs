namespace Common.ExtensionMethods
{
    public static class AppExtensions
    {
        public static string StartWithCapitalLetter(this string text)
        {
            var withoughtFirst = text.Substring(1, text.Length-1);
            var newText = char.ToUpper(text[0]) + withoughtFirst;

            return newText;
        }
    }
}
