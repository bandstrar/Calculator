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
            int sum = 0;
            int[] divideArray = new int[splitNums.Length];
            int divideTotal = 0;
            string squareJoin = "";

            if (splitOperator[0] == "*")
            {
                foreach (var num in splitNums)

                { 
                    int stringToInt = Int32.Parse(num);
                    prod *= stringToInt;
                }
                Console.WriteLine($"The product of your numbers is {prod}.");
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
            else if (splitOperator[0] == "+")
            {
                foreach (var num in splitNums)
                {
                    int stringToInt = Int32.Parse(num);
                    sum += stringToInt;
                }
                Console.WriteLine($"The sum of your numbers is {sum}.");
            }
            else if (splitOperator[0] == "/")
            {
                for (var num = 0; num < splitNums.Length; num++)
                {
                    int stringToInt = Int32.Parse(splitNums[num]);
                    divideArray[num] = stringToInt;
                }
                for (var div = 1; div < divideArray.Length; div++)
                {
                    if (div == 1)
                    {
                        divideTotal = divideArray[div - 1] / divideArray[div];
                    }
                    else
                    {
                        divideTotal = divideTotal / divideArray[div];
                    }
                }
                Console.WriteLine($"Your numbers divided by each other is equal to {divideTotal}.");
            }
        }
    }
}
