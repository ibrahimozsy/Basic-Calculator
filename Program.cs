using System;
using System.Runtime.CompilerServices;
class Program
{
    static void Main()
    {
        int number1, number2, result;
        char symbol;
        bool another = true;
        while (another)

        {
            Console.WriteLine("Please Type Number 1");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter Number 2");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the operation you want to perform:  (+, -, *, /)");
            symbol = Convert.ToChar(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Result is: " + result); break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("REsult is:" + result); break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("result is: " + result); break;
                case '/':
                    if (number2 == 0)
                    {
                        Console.WriteLine("Second number cannot be zero when dividing");
                    }
                    else
                    {
                        result = number1 / number2;
                        Console.WriteLine("result is: " + result);
                    }
                    break;
            }
            Console.WriteLine("do you want another calculate?: (Y/N)");
            string respond = Console.ReadLine().ToUpper();
            if (respond != "Y")
            {
                another = false;
            } 

        }
        



    }
}