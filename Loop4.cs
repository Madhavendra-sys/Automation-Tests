using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeLoop;

namespace PracticeLoop
{
    class Loop4
    {

        public void Star1()
        { 
        
        for (int i = 1; i<=5; i++) // row
            {
                for(int j = 1; j<=i; j++) // column 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
           }
        
        }

        public void Star2()
        {

            for (int i = 5; i >= 1; i--) // row
            {
               for(int j=i; j>=1;j--) //column
                {
                    Console.Write("*"); 
                }
                Console.WriteLine();
            }
            
        }

    }

}
class Execute()
{
    public static void Main(string[] args)
    {
        Loop4 l4 = new Loop4();
        //l4.Star1();
        l4.Star2();
    }
}
