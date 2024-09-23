namespace Way_Too_Long_Words
{
    internal class Program
    {
        static void Main()
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            string[] words = new string[n];
            for (int i = 0; i < n; i++)
            {
                words[i] = (Console.ReadLine());
            }

            for(int i = 0;i < n; i++)
            {
                if (words[i].Length <=10)
                    Console.WriteLine(words[i]);
                else
                {
                    int len= words[i].Length-2;
                    var newWord = words[i].Substring(0, 1) + len + words[i].Substring(len+1,1);
                    Console.WriteLine(newWord);
                }
            }
           

        }
    }
}
