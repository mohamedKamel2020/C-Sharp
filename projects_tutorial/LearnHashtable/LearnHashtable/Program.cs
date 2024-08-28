using System.Collections;

namespace LearnHashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht1 = new Hashtable();
            ht1.Add("apple", 30);
            ht1.Add("banan", 25);
            ht1.Add("avocado", 40);
            ht1.Add("meat", 400);
            ht1.Add("rice", 50);

            //Remove to delete element with key
            //Clear to delete all elements
            Console.WriteLine("i will element remove key \"rice\" with value = {0}",ht1["rice"]);

            ht1.Remove("rice");
            foreach (DictionaryEntry ele in ht1)
            {
                Console.WriteLine("{0} and {1}", ele.Key, ele.Value);
            }

            Hashtable ht2 = new Hashtable() { {1,"Front-end" }, { 2, "Backend" },{ 3, "developer" },{ 4, "Database" } };
            Console.WriteLine("Total Number of elements in hashtable = {0}", ht2.Count);

            ht2.Clear();

            Console.WriteLine("Total Number of elements in hashtable with Clear() = {0}", ht2.Count);

            //foreach (DictionaryEntry ele in ht2) {
            //    Console.WriteLine("{0} and {1}",ele.Key, ele.Value);
            //}

            // check whether the given pair is present or not key and value
            //Contains: This method is used to check whether the Hashtable contains a specific key.
            //ContainsKey: This method is also used to check whether the Hashtable contains a specific key.
            //ContainsValue: This method is used to check whether the Hashtable contains a specific value.

            Console.WriteLine(ht1.Contains("meat"));
            Console.WriteLine(ht1.Contains("rice"));

            Console.WriteLine(ht1.ContainsKey("banan"));
            Console.WriteLine(ht1.ContainsKey(2));

            Console.WriteLine(ht1.ContainsValue(30));
            Console.WriteLine(ht1.ContainsValue(2));

            //In C#, the Hashtable class does not provide a direct method to update the value of an existing key
            //but you with some steps can update
            //ex => edit meat from 400 to 350 
            string keyToEdit = "meat";
            if (ht1.ContainsKey(keyToEdit))
            {
                ht1[keyToEdit] = 350;
            }
            //int updatedValue = (int)ht1[keyToEdit];
            //Console.WriteLine("Updated value: " + updatedValue);

            foreach (DictionaryEntry ele in ht1)
            {
                Console.WriteLine("{0} and {1}", ele.Key, ele.Value);
            }



        }
    }
}
