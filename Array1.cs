using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace PracticeLoop
{
    class Array1
    {
        //Write a  Program to add numbers in Array
        public void sum()
        {
            int[] a = { 10, 76, 98, 43 };
            int sum = 0;
            Console.WriteLine(a.Length);
            for (int i = 0; i <= a.Length - 1; i++)
            {

                sum = sum + a[i];

            }
            Console.WriteLine(sum);
        }


        // calculate max and min
        public void array() 


        {
            int[] array = { 1, 456, 7, 8 };
            int max = array[0];
            int min = array[0];
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);


        }
        // reverse
        public void rev()  
        {

            int[] arr = new int[5];

            Console.Write("Element - {0}; ");
            arr[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Element - {1}; ");
            arr[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Element - {2}; ");
            arr[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Element - {3}; ");
            arr[3] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Element - {4}; ");
            arr[4] = Convert.ToInt32(Console.ReadLine());

            int n = arr.Length;
            Console.WriteLine(n);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
        }
        //start with one
        public void start1() 

        {
            int[] arr = { 123, 21, 34, 11, 6 };
            int str;

            for (int i = 0; i < arr.Length; i++)
            {

                str = arr[i];
                if (str > 0)
                {
                    str = str / 10;

                    if (str > 0)
                    {
                        str = str / 10;
                    }
                    Console.WriteLine(str);
                }


            }

        }

        //class Execute
        //{
        //    public static void Main(string[] args)

        //    {
        //        Array1 a = new Array1();
        //        a.array();
        //        a.sum();
        //        a.rev();
        //        a.start1();

        //    }

        //}
    }
}


