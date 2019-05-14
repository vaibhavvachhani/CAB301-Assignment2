using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {

        public static int minDistance(int[] arr)
        {
            int dmin = 2147483647; //large number for distance comparision (max value allowed)
            for (int i = 0; i < arr.GetLength(0) ; i++) //loop over the array
            {
                for (int j = 0; j < arr.GetLength(0); j++) //loop over the array
                {
                    if (i != j && (Math.Abs(arr[i] - arr[j]) < dmin)) //basic operation
                    {
                        dmin = Math.Abs(arr[i] - arr[j]); //assign the distance to dmin variable if true
                    }
                }
            }
            return dmin; //return the variable

        }

        public static int minDistance2(int[] arr)
        {
            int dmin = 2147483647; //large number for distance comparision (max value allowed)
            for (int i = 0; i < arr.GetLength(0)-1; i++) //loop over the array
            {
                for (int j = i + 1; j < arr.GetLength(0); j++) //loop over the rest of the array
                {
                    int temp = Math.Abs(arr[i] - arr[j]); ;
                    if (temp < dmin) //basic operation
                    {
                        dmin = temp; //assign the distance to dmin variable if true
                    }
                }
            }
            return dmin; //return the variable

        }

        public static int[] generateRandomArray(long size, int start, int stop)
        {
            int[] arr = new int[size];
            
            Random randomNum = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = randomNum.Next((start), stop);
            }
            return arr;

        }
        public static int[] generateRandomArrayWithoutDup(int size, int start, int stop)
        {
            int[] arr = new int[size];
            Random randomNum = new Random();
            int num = 0;
            for (int i = 0; i < size; i++)
            {
                
                num = randomNum.Next(start, stop);
                while (arr.Contains(num))
                {
                    num = randomNum.Next(start, stop);
                }
                arr[i] = num;
                
            }
            return arr;

        }

        static void Main(string[] args)
        {
            
            Random r1 = new Random();
            
            for (int i = 0; i < 30; i++)
            {
                long randomsize = r1.Next(500, 10000);

                int[] t1 = generateRandomArrayWithoutDup((int)randomsize, -50000, 50000);
                Console.WriteLine("Counters for array of size" + randomsize);
                long minD1 = Program_timer_.minDistance(t1);
                long min2 = Program_timer_.minDistance2(t1);
                Console.WriteLine("");
                Console.WriteLine("");
            }
           
        }
    }
}
