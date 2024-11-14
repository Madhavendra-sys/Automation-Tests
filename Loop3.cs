using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLoop
{
    class Loop3
    {
        int num;
        Loop3()
        {
            Console.WriteLine("Enter The Count");
            int num = Convert.ToInt32(Console.ReadLine());
            this.num = num;
        }
        public void input()
        {
            
            double sum = 0;
            double avg = 0;
            Console.WriteLine("Enter" + num + "no");
            for (int i = 1; i <= num; i++)
            {
                
                int val = Convert.ToInt32(Console.ReadLine());
                sum = sum +val;
                avg = sum / num;
            }
            Console.WriteLine("Sum of entered no is "+sum);
            Console.WriteLine("Average of entered no is " + avg);

        }



        //class Execute()
        //{
        //    public static void Main(string[] args)
        //    {
        //        Loop3 l3 = new Loop3();
        //        l3.input();
              


        //    }
        //}
    }
}
