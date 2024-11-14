using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PracticeLoop
{
    //Write a C# Sharp program that displays the sum of n natural numbers.
    public class Loop2
    {
        int num;

        Loop2()
        {
            Console.WriteLine("Enter the no");
            int num = Convert.ToInt32(Console.ReadLine());
            this.num = num;
        }

        public void whole()

        {
            int sum = 0;
            Console.WriteLine("The first n natural number is :");   
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine("The Sum of Natural Number upto n terms :");
            Console.WriteLine(sum); 
        }
        class Execute()
        {
            //public static void Main(string[] args)
            //{
            //    Loop2 l2 = new Loop2();
            //    l2.whole();

            //}
        }
    }
}
