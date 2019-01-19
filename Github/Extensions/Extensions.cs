namespace Github.Extensions
{
    public static class Extensions
    {
        public static string Between(this string str, string firstString, string lastString)
        {
            string final;
            int pos1 = str.IndexOf(firstString) + firstString.Length;
            int pos2 = str.IndexOf(lastString);
            final = str.Substring(pos1, pos2 - pos1);
            return final;
        }
    }
}