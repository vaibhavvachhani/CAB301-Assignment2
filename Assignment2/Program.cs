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
            int counter = 0;
            int dmin = 10000; //large number for distance comparision
            for (int i = 0; i < arr.GetLength(0) ; i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (++counter > 0 && i != j && (Math.Abs(arr[i] - arr[j]) < dmin)) //basic operation
                    {
                        dmin = Math.Abs(arr[i] - arr[j]); //assign the distance to dmin variable if true
                    }
                }
            }
            Console.WriteLine("minDistance counter "+ counter);
            return dmin; //return the variable

        }

        public static int minDistance2(int[] arr)
        {
            int counter1 = 0;
            int dmin = 10000; // large number for distance comparision
            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                for (int j = i+1; j < arr.GetLength(0); j++)
                {
                    int temp = Math.Abs(arr[i] - arr[j]); ;
                    if (++counter1 > 0 &&  temp < dmin) //basic operation
                    {
                        dmin = temp; //assign the distance to dmin variable if true
                    }
                }
            }
            Console.WriteLine("minDistance2 counter "+ counter1);
            return dmin; //return the variable

        }

        public static int[] generateRandomArray(int size, int start, int stop)
        {
            int[] arr = new int[size];
            
            Random randomNum = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = randomNum.Next(start, stop);
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
            int[] t1 = generateRandomArrayWithoutDup(20, -100, 100);
            for (int i = 0; i < t1.Count(); i++)

            {
                Console.Write(t1[i].ToString() + ", ");
                Console.WriteLine("");

            }
        }
    }
}
