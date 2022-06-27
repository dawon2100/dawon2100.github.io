using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GrasshopperConnectionTest
{
    class Program
    {


        public enum testEnum
        {
            Hello = 0,
            Dawon = 1,
            Wow = 9
        }

        public static void ShiftLeft<T>(List<T> lst, int shifts)
        {
            

            int listLength = lst.Count;
            List<T> clonedList = new List<T>(lst);

            for (int i = 0; i < lst.Count; i++)
            {
                lst[i] = clonedList[(i + shifts) % listLength];
            }


        }

        static void Main(string[] args)
        {
            int[] arrTest = new int[4];

            arrTest[0] = (int)testEnum.Hello;

            Console.WriteLine((testEnum)0);

            List<int> testList = new List<int>();
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);

            Console.WriteLine(String.Join(" ", testList));
            ShiftLeft(testList, 2);

            Console.WriteLine(String.Join(" ", testList));

        }
    }
}
