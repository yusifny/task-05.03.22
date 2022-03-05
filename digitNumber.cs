using System;

namespace digitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            while (number > 0)

            {
                number = number / 10;
                count += 1;

            }
            Console.WriteLine(count);
        }
    }
}
