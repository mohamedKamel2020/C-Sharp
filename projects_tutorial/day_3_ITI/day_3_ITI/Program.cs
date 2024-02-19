using System;

namespace day_3_ITI
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menu = new string[] { "New", "Display", "Exit" };
            int highlight = 0;
            bool exit_flag = false;
            do
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i == highlight)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.SetCursorPosition(30, 5 + 5 * i);
                    Console.WriteLine(menu[i]);
                }
                Console.CursorVisible = false;
                ConsoleKeyInfo k = Console.ReadKey();
                switch (k.Key)
                {
                    case ConsoleKey.UpArrow:
                        highlight--;
                        if (highlight < 0)
                            highlight = 2;
                        break;
                    case ConsoleKey.DownArrow:
                        highlight++;
                        if (highlight > 2)
                            highlight = 0;
                        break;
                    case ConsoleKey.Enter:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        switch (highlight)
                        {
                            case 0:
                                Console.WriteLine("New");
                                Console.ReadLine();
                                break;
                            case 1:
                                Console.WriteLine("Display");
                                Console.ReadLine();
                                break;
                            case 2:
                                exit_flag = true;
                                Console.ReadLine();
                                break;
                        }
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        break;
                    case ConsoleKey.Escape:
                        exit_flag = true;
                        break;
                }
            } while (exit_flag != true);
        }
    }
}
