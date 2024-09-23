namespace FindIndexStrMatching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string haystack = "sadbutsad";
            string needle = "sad";
            int n = Program.strStr(haystack, needle);
            Console.WriteLine($"Result : {n}");

        }
        static int strStr(string haystack, string needle)
        {
            int i = 0;
            int k = haystack.Length;
            int l = needle.Length;
            while (i < k )
            {
                string subStr = haystack.Substring(i, l);
                if (subStr == needle)
                {
                    return i;
                }
                else if (i - k < l)
                {
                    break;
                }
                else
                {
                    i++;
                }
            }
            return -1;
        }

    }
}
