using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program_counter_
    {
        public static int minDistance(int[] arr)
        {
            int counter = 0;
            int dmin = 100000;//large number for distance comparision
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
            Console.WriteLine("minDistance counter " + counter);
            return dmin; //return the variable

        }

        public static int minDistance2(int[] arr)
        {
            int counter1 = 0;
            int dmin = 100000;// large number for distance comparision
            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                for (int j = i + 1; j < arr.GetLength(0); j++)
                {
                    int temp = Math.Abs(arr[i] - arr[j]); ;
                    if (++counter1 > 0 && temp < dmin) //basic operation
                    {
                        dmin = temp; //assign the distance to dmin variable if true
                    }
                }
            }
            Console.WriteLine("minDistance2 counter " + counter1);
            return dmin; //return the variable

        }
    }
}
