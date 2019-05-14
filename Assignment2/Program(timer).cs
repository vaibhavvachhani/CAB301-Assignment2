using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program_timer_
    {
        
        public static int minDistance(int[] arr)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew(); //in built stopwatch ulitility 
            watch.Start(); //start the stopwatch
            int counter = 0;
            int dmin = 10000; //large number for distance comparision
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (++counter > 0 && i != j && (Math.Abs(arr[i] - arr[j]) < dmin)) //basic operation
                    {
                        dmin = Math.Abs(arr[i] - arr[j]); //assign the distance to dmin variable if true
                    }
                }
            }
            watch.Stop();
            Console.WriteLine("time taken minDistance (ms): " + watch.ElapsedMilliseconds);
            return dmin; //return the variable

        }

        public static int minDistance2(int[] arr)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew(); //in built stopwatch ulitility 
            watch.Start(); //start the stopwatch
            int counter1 = 0;
            int dmin = 10000; // large number for distance comparision
            for (int i = 0; i < arr.GetLength(0) - 2; i++)
            {
                for (int j = i + 1; j < arr.GetLength(0)-1; j++)
                {
                    int temp = Math.Abs(arr[i] - arr[j]); ;
                    if (++counter1 > 0 && temp < dmin) //basic operation
                    {
                        dmin = temp; //assign the distance to dmin variable if true
                    }
                }
            }
            watch.Stop();
            Console.WriteLine("time taken minDistance2 (ms): " + watch.ElapsedMilliseconds);
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

        

    }
}
