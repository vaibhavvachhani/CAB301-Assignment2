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
            int dmin = 100000;//large number for distance comparision
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
            int dmin = 100000;// large number for distance comparision
            for (int i = 0; i < arr.GetLength(0) - 1; i++) //loop over the array
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
            /*
            Random r1 = new Random();
            
            for (int i = 0; i < 30; i++)
            {
                long randomsize = r1.Next(500, 5000);

                int[] t1 = generateRandomArray(randomsize, -50000, 50000);
                Console.WriteLine("Counters for array of size" + randomsize);
                long minD1 = minDistance(t1);
                long min2 = minDistance2(t1);
                Console.WriteLine("");
                Console.WriteLine("");
            }
            
            
             *testing code 
             * 
             * /
            */
            int[] t1 = { -9, 9713, 01836, 859, -9484, -516, 200, 100458 };
            int answer = Convert.ToInt32(minDistance2(t1));
            Console.WriteLine(answer);
            
        }
    }
}
