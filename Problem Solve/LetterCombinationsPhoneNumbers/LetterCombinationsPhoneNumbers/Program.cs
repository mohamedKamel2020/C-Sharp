namespace LetterCombinationsPhoneNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program c = new Program();
            IList<string> res = c.LetterCombinations("234");
            foreach (string s in res)
            {
                Console.WriteLine(s);
            }
        }
        Dictionary<char, char[]> keypad = new Dictionary<char, char[]> {
               {'2', new char[]{'a', 'b', 'c'}},
               {'3', new char[]{'d', 'e', 'f'}},
               {'4', new char[] {'g', 'h', 'i'}},
               {'5', new char[] {'j', 'k', 'l'}},
               {'6', new char[] {'m', 'n', 'o'}},
               {'7', new char[] {'p', 'q', 'r', 's'}},
               {'8', new char[] {'t', 'u', 'v'}},
               {'9', new char[] {'w', 'x', 'y', 'z'}}};
        public  void getCombination(string curr, string digits, int index, IList<string> list)
        {
            if (index >= digits.Length)
                list.Add(curr);
            else
            {
                char[] map = keypad[digits[index]];

                for (int i = 0; i < map.Length; i++)
                {
                    string newCurr = curr + map[i];
                    getCombination(newCurr, digits, index + 1, list);
                }
            }
        }
        public  IList<string> LetterCombinations(string digits)
        {


            IList<string> res = new List<string>();
            if (digits.Length > 0) getCombination("", digits, 0, res);

            return res;

        }
    }
}
