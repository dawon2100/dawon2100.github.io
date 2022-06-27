using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pocustudy
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the first Numeber : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second Numeber : ");
            int num2 = int.Parse(Console.ReadLine());

            int max;
            if (num1 > num2)
            {
                max = num1;
            }
            else
            {
                max = num2;

            }


            Console.WriteLine($"Max number is : {max}");

        }
    }
}
