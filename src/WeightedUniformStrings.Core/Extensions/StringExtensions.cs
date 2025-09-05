namespace WeightedUniformStrings.Core.Extensions
{
    public static class StringExtensions
    {
        private static string weigths = "abcdefghijklmnopqrstuvwxyz";
        public static int CalcWeigth(this string s)
        {
            int weigth = 0;
            foreach (var x in s)
                weigth += s.IndexOf(x) + 1;

            return weigth;
        }
    }
}
