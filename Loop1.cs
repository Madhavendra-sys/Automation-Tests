namespace PracticeLoop
{
    class Loop1
    {
        //Write a program in C# Sharp to display the first 10 natural numbers.
        //Write a C# Sharp program to find the sum of the first 10 natural numbers.
        public void Whole() // Display no 1 to 10

        {

            Console.WriteLine("No from 1 t0 10 ");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        public int WholeAdd() //Addition of whole no 1 to 10  // query why can i do with return type as void 
        {
            Console.WriteLine("Addition of 1 t0 10 ");
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;
              
                
            }
            Console.WriteLine(sum);
            return sum;
        }

        //public void WholeAvg(float sum) //Average of whole no 1 to 10 

        //{
        //    Console.WriteLine("Average of nos 1 t0 10 ");
        //    float avg = sum/10;
          
        //    Console.WriteLine(avg);

        //}

        class Execute()
        {
            //public static void Main(string[] args)
            //{
            //    Loop1 l1 = new Loop1();
            //    l1.Whole();
            //    int sum = l1.WholeAdd();
            //    l1.WholeAvg(sum);




            //}
        }
    }
}
