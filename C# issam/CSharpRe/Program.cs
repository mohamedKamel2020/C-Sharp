internal class Program
{
    private static void Main(string[] args)
    {
        //Primary Expression has value
        var amount=Math.Cos(30)+1;
        Console.WriteLine(amount);
        //void expression no value
        Console.WriteLine("Mohamed");
        //assigment
        var x = 2;
        var y = 5;

        Console.WriteLine($" x + y = {x+y}\n");
        Console.WriteLine($" x - y = {x-y}\n");
        Console.WriteLine($" x * y = {x*y}\n");
        Console.WriteLine($" x / y = {x/y}\n");
        Console.WriteLine($" x % y = {x%y}\n");
        var z = 8 / 4 / 2;
        Console.WriteLine($"Z = {z} \n");
        var s1 = "";//empty string not null 
        var s2 = "";
        var s3 = s1 = s2 = "Mohammed";
        Console.WriteLine($"{s3}\n");//inline statment 
        //bolok statment 
        {
            Console.WriteLine("mohamed kamel mohamed\n");
            Console.WriteLine("mohamed kamel mohamed\n");
            Console.WriteLine("mohamed kamel mohamed\n");
            Console.WriteLine("mohamed kamel mohamed\n");
            Console.WriteLine("mohamed kamel mohamed\n");
        }
        //Increment/decrement
        var total = 150;
        Console.WriteLine(++total);
        Console.WriteLine(--total);
        var num = 2;
        Console.WriteLine(num++);//2
        Console.WriteLine(num);//3

        //if
        var mark = 90;
        if (mark >= 85)
        {
            Console.WriteLine("Excellent");
        }
        Console.WriteLine("***************");
        //if else
        var de = 55;
        if (de >= 60)
        {
            Console.WriteLine("Pass");
        }
        else
        {
            Console.WriteLine("fail");
        }
        Console.WriteLine("*************");
        //else if 
        if (de >= 60)
        {
            Console.WriteLine("Pass");
        }else if(de>=55){
            Console.WriteLine("you have a chance in a make up exam");
        }
        else
        {
            Console.WriteLine("fail");
        }
        //switch case
        var amountPound = 1000;
        var currtype = "USD";
        var output = 0d;

        var poundToUSD = 0.0300d;
        var poundToEUR = 0.0305d;
        var poundToGBP = 0.0362d;

        switch (currtype)
        {
            case "USD":
                output = amountPound * poundToUSD;
                Console.WriteLine($"{amountPound} Eg={output} USD");
                break;
            case "EUR":
                output = amountPound * poundToEUR;
                Console.WriteLine($"{amountPound} Eg={output} EUR");
                break;
            case "GBP":
                output = amountPound * poundToGBP;
                Console.WriteLine($"{amountPound} Eg={output} GBP");
                break;
            default:
                Console.WriteLine("unknow currency type");
                break;
        }

        //
        var num1 = 3;
        switch (num1)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 9:
                Console.WriteLine("odd");
                break;
            case 2:
            case 4:
            case 6:
            case 8:
                Console.WriteLine("even");
                break;

        }
        object o = 3;
        switch (o)
        {
            case int i:
                Console.WriteLine($"it's int ,sqr of {i}={i*i}");
                break;
            case string i:
                Console.WriteLine($"it's string ,captialization of {i}={i.ToUpper()}");
                break;
        }
        //
        bool isVip = true;
        switch (isVip)
        {
            case bool i when i == true:
                Console.WriteLine("yes");
                break;
            case bool i when i == false:
                Console.WriteLine("No");
                break;
        }
        //
        var cardNo = 13;
        string cardName = cardNo switch
        {

            1 => "ACE",
            13 => "King",
            12 => "Queen",
            10 => "Jack",
            _ => cardNo.ToString()
        };

        Console.WriteLine(cardName);

        //Iteration
        var counter = 0;
        while (counter<10)
        {
            Console.Write(counter);
            ++counter;
        }
        Console.WriteLine(" ");

        Console.WriteLine("****************");
        counter = 0;
        do
        {
            Console.Write(counter+" ");
            ++counter;
        }while (counter<10);
        Console.WriteLine("\n**************");
        for (var i=0;i<10;++i)
        {
            Console.Write(i+" ");
        }
        //
        Console.WriteLine("\n**************");
        var arr = new int[] { 1, 2, 4, 6, 8 };
        foreach(var n in arr)
        {
            Console.Write(n + " ");
        }
        //
        Console.WriteLine("\n**************");
        for (int i=0;i<arr.Length;i++)
        {
            Console.Write(arr[i] +" ");
        }
        //Jump[break, continue,goto ,return]
        Console.WriteLine("\n********break******");
        var num5=0;
        while (num5 < 10)
        {
            if (num5 > 5)
                break;
            Console.WriteLine(num5);
            ++num5;
        }
        Console.WriteLine("\n*******continue*******");
        var num6 = 0;
        while (num6 < 10)
        {
            if (num6 == 5)
                continue;
            Console.WriteLine(num6);
            ++num6;
        }
        Console.WriteLine("\n****************");
        Console.WriteLine("\nodd");
        for (int num3 = 0; num3 < 10; num3++)
        {
            if(num3%2==0)
                continue;
            Console.Write(num3+ " ");
        }
        Console.WriteLine("\neven");
        for (int num3 = 0; num3 < 10; num3++)
        {
            if (num3 % 2 != 0)
                continue;
            Console.Write(num3 + " ");
        }
        Console.WriteLine("\n*******goto*****");
        var num4 = 0;
        start:
        if (num4 <= 5)
        {
            Console.WriteLine(num4+" ");
            ++num4;
            goto start;
        }
       

        Console.ReadKey();
    }
}