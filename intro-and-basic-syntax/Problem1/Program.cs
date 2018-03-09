
using System;
using System.Collections.Generic;

namespace DebitCardNumber

{
    class Program
    {
        static void Main()
           {

           List<int> list = new List<int>();
            int numbers;


            for (int i = 0; i < 4; i++)
            {
                numbers = int.Parse(Console.ReadLine());
                list.Add(numbers);
            }

            foreach (var num in list)
            {
                Console.Write($"{num:D4} ");
            }
        }
    }
}