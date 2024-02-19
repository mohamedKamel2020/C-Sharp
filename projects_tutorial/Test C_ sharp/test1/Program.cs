using System;

namespace test1
{
    class Program
    {
        static void Main()
        {
            int firstNum = 25;
            int secondNum = 4;
            int result;
            result = firstNum + secondNum;
            Console.WriteLine( firstNum + secondNum);/*sum */
            result = firstNum - secondNum;
            Console.WriteLine( result );/*subtract */

            Console.WriteLine("result Mult is " ,firstNum  *  secondNum );/*Multiply*/
            result = firstNum / secondNum;
            Console.WriteLine("result Divid is {0}", result);/*dividing*/
            result = firstNum % secondNum;
            Console.WriteLine("result models is {0}", result);/*Models*/
            
        }
    }
}
/*Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user. 
Test Data:
Input the first number: 25
Input the second number: 4
Expected Output:
25 + 4 = 29
25 - 4 = 21
25 x 4 = 100
25 / 4 = 6
25 mod 4 = 1
*/
