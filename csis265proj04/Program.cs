using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csis265proj04
{
    public class Program
    {
        public static void InitializeArray(int[] integerArray, int LOWEST_NUMBER, int HIGHEST_NUMBER)
        {
            Random generator = new Random();
            for (int i = 0; i < integerArray.Length; i++)
            {
                integerArray[i] = generator.Next(LOWEST_NUMBER, HIGHEST_NUMBER);
            }

        }
        public static void DisplayArray(int[] integerArray)
        {
            for (int i = 0; i < integerArray.Length; i++)
            {
                System.Console.Write(integerArray[i] + "    ");
            }
        }
        public static void DisplaySquareInfo(int[] integerArray)
        {
            for (int i = 0; i < integerArray.Length; i++)
            {
                System.Console.WriteLine("For a square with side: " + integerArray[i] + ", the perimiter is: "
                                          + (integerArray[i] * 4) + " and the area is: " + (integerArray[i] * integerArray[i]));
            }
        }
        public static void DisplayCircleInfo(int[] integerArray)        {
            for (int i = 0; i < integerArray.Length; i++)
            {
                System.Console.WriteLine("For a circle with radius: " + integerArray[i] + ", the circumference is: "
                                          + (integerArray[i] * 2 * Math.PI) + " and the area is: " + (integerArray[i] * integerArray[i] * Math.PI));
            }
        }
        public static void DisplayRightTriangleInfo(int[] integerArray)
        {
            for (int i = 0; i < integerArray.Length; i++)
            {
                System.Console.WriteLine("For a right triangle with sides A/B: " + integerArray[i] + ", the hypotenuse is: "
                                          + (Math.Sqrt((integerArray[i] * integerArray[i] * 2))));
            }
        }
        public static void Main()
        {
            const int MAX_SIZE = 10;
            const int LOWEST_NUMBER = 10;
            const int HIGHEST_NUMBER = 31;
            int[] intArray = new int[MAX_SIZE];

            InitializeArray(intArray, LOWEST_NUMBER, HIGHEST_NUMBER);

            DisplayArray(intArray);
            System.Console.WriteLine();

            DisplaySquareInfo(intArray);
            System.Console.WriteLine();

            DisplayCircleInfo(intArray);
            System.Console.WriteLine();

            DisplayRightTriangleInfo(intArray);

            System.Console.ReadLine();
        }
    }
}
