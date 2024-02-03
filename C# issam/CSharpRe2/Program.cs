internal class Program
{
    private static void Main(string[] args)
    {
        // casting
        
        //1-implicit casting 
        int num = 1000;
        long numLong = num;
        
        //2-Explicit casting
        double numDouble = 21.5;
        int numInt = (int)numDouble;
        Console.WriteLine(numDouble);
        //Boxing
        int x = 10;//value type
        object obj;//reference type
        obj = x;//casting done implicity
        //unBoxing
        int y = (int)obj;//conversion done explicity
        //type.Parse
        string str = "2020";
        int num1=int.Parse(str);
        Console.WriteLine(num1);
        //tryParse
        string str2 = "9999999999999";
        if (long.TryParse(str2,out long number))
        {
            Console.WriteLine(number);
        }
        else
        {
            Console.WriteLine("Invalid Number ");
        }
        //BitConverter
        var number1 = 255;
        var bytes=BitConverter.GetBytes(number1);
        foreach (var b in bytes)
        {
            var binary = Convert.ToString(b,2).PadLeft(8,'0');
            Console.WriteLine(binary);
        }
        //
        var name = "Mohammed";
        char[] letters = name.ToCharArray();
        foreach (var l in letters)
        {
            int ascii = Convert.ToInt32(l);
            var output = $"'{l}'-> ASCII: {ascii},Binary: {Convert.ToString(ascii,2).PadLeft(8,'0')},Hexadecimal:{ascii:x}";
            Console.WriteLine(output);

        }
        //
        string[] hexValues = { "49", "73", "61", "6D" };
        foreach (var h in hexValues)
        {
            int value = Convert.ToInt32(h, 16);
            var stringValue = Char.ConvertFromUtf32(value);
            var ch=(char)value;
            Console.WriteLine(ch);
            Console.WriteLine(stringValue);
        }
        //
        var hex = "8E2";
        int number3=Int32.Parse(hex,System.Globalization.NumberStyles.HexNumber);
        Console.WriteLine(number3);
   
        
        Console.ReadKey();
    }
}