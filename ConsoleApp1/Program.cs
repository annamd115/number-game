using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            var input = "1,2,3";
            var total = 1;

            var noCommas = input.Split(',');

            Console.WriteLine("Do you want to multiply or square these numbers? m/s");
            var answer = Console.ReadLine();

            if (answer == "m")
            {
                foreach (var num in noCommas)
                {
                    total *= int.Parse(num);
                    Console.WriteLine(total);
                }
            }
            else if (answer == "s")
            {
                var squareNum = 0;
                var squareArr = "";

                foreach (var num in noCommas)
                {
                    var num2 = int.Parse(num);
                    squareNum = num2 * num2;
                    squareArr += squareNum.ToString() + ",";
                }
                squareArr = squareArr.TrimEnd(new char[] { ',' });
                Console.WriteLine(squareArr);
            }
            Console.ReadLine();
        }
    }
}
