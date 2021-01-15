using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select your operator, then type in 3 numbers separated by commas, then press Enter");

            var stringNums = Console.ReadLine();

            string[] splitOperator = stringNums.Split(' ');

            string[] splitNums = splitOperator[1].Split(',');

            int prod = 1;
            string squareJoin = "";

            if (splitOperator[0] == "*")
            {
                foreach (var num in splitNums)

                { 
                    int stringToInt = Int32.Parse(num);
                    prod *= stringToInt;
                }
                Console.WriteLine($"Your product is {prod}");
            }
            else if (splitOperator[0] == "^2")
            {
                foreach (var num in splitNums)
                {
                    int stringToInt = Int32.Parse(num);
                    int squaredInt = stringToInt *= stringToInt;
                    string stringSquare = squaredInt.ToString();
                    squareJoin += $"{stringSquare},";
                }
                Console.WriteLine($"Your squared numbers are {squareJoin.TrimEnd(',')}");
            }
        }
    }
}
