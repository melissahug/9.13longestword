using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._13longestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] favFood = { "pizza", "taco", "meatloaf", "salad" };
            string[] favDrink = { "wine", "water", "milkshakes", "reallyhotcoffee" };
            int lenght1 = favFood.Length;

            Console.WriteLine(lenght1);
            /*
            for (int index = 0; index < favFood.Length; favFood++)
            {
                if (favFood[index] < favDrink)
                    favDrink = favFood[index];
            }
            */


        }
    }
}
