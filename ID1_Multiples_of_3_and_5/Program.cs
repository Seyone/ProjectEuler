using System;

namespace ID1_Multiples_of_3_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowerEndpoint = 0;
            int upperEndpoint = 1000;
            int sum = 0;

            for (int i = lowerEndpoint; i < upperEndpoint; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Answer is {0}", sum);
        }
    }
}
