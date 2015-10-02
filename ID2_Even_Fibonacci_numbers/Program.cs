using System;

namespace ID2_Even_Fibonacci_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 4000000;
            int sum = 0;
            int x = 1;
            int y = 2;
            int temp;

            do
            {
                if (y % 2 ==0)
                    sum += y;
                temp = y;
                y += x;
                x = temp;

            }
            while (y <= max);

            Console.WriteLine("Answer is {0}",sum);
        }
    }
}
