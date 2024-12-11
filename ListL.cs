using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class ListL
    {
        //public void List()
        //{

        //    List<int> list = new List<int>();
        //    list.Add(1);
        //    list.Add(2);
        //    list.Add(9);
        //    list.Add(9);
        //    list.Add(9);


        //    //Console.WriteLine(list.Count); // count is the no of elements 

        //    for (int i = 0; i <= list.Count - 1; i++)
        //    {             

        //        for (int j =i+1; j <= list.Count - 1; j++)
        //        {
        //            if (list[i] == list[j])
        //            {

        //                list.Remove(list[i]);

        //            }
        //        }

        //        Console.WriteLine(list[i]);


        //    }
        //foreach (int k in list)
        //{
        //    Console.WriteLine(k);
        //}


        public void list1()
        {
            List<int> l1 = new List<int>();
            l1.Add(1);
            l1.Add(2);
            l1.Add(9);
            l1.Add(9);
            l1.Add(9);
            l1.Add(9);
          


            for (int i = 0; i <= l1.Count-1 ; i++)
              
            {
                int count = 0;

                for (int j = 0; j <= l1.Count-1 ; j++)
                {
              

                    if (l1[i] == l1[j])
                    {
                        count++;
                        if (count > 1)
                        {
                            l1.Remove(l1[j]);

                        }
                    }
                    
                    
                }
               
            }
            foreach (int a in l1)
            {
                Console.WriteLine(a);
            }
        }
    
        


        class execute
        {
            public static void Main()
            {

                ListL z = new ListL();

                z.list1();
            }

        }
    }
}

