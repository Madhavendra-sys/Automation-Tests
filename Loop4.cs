using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLoop
{
    class Loop5
    {
        public void Multable() // Create Multiplication table 
        {
            Console.WriteLine("enter the no");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2} \n", n, i, n * i);
            }
        }



        public void countdigit() // count digit 
        {
            //123

            int count = 0;
            int num = 1234;

            while (num != 0)
            {
                num = num / 10;
                count++;

            }
            
            Console.WriteLine(count);
        }

        public void factori() //Factorial of a Number
        {

           int  num = Convert.ToInt32(Console.ReadLine());
           int i;
           int f = 1;
            {
                for (i = 1; i <= num; i++)  
                    f = f * i;
                

            }
            Console.WriteLine(f);   
        }

        public void Sumdig() // sum and rev of digits
        {
            int remender = 0;
            int sum = 0;
            int rev = 0;
            int   num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {

               remender = num % 10;
               sum = sum + remender;
               rev = rev * 10 + remender;
               num = num / 10;
            }
            Console.WriteLine(rev);
            Console.WriteLine(sum);
           

        }

        public void countw() // count no of characters 
        {
            string word = Console.ReadLine();
            int count = 0;

            foreach (char c in word) 
            { 
                ++count; 
            
            }

            Console.WriteLine("Number of characters: " + count);
        }
        //public static void Main(string[] args)
        //{
        //    Loop5 l5 = new Loop5();
        //    //l5.Multable();
        //    //l5.countdigit();
        //    //l5.factori();
        //    //l5.Sumdig();
        //    //l5.countw(); 

        //}

    }
}
