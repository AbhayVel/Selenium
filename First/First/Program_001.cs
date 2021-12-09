using System;
//using System.Linq;
/*
 * 
 * 
 * 
 */
namespace First
{
    class Program_001
    {

        //*"ACssess Modifier" + *"static"  + return Type + MethodName (*"Type Name", *"Type Name",*"Type Name"...........(0......n))

     public   static void Main_001(string[] args)
        {
            // string <- 
            // number 
            // boolean 
            // groups <- Collection 
            // Date
            //Type //Variable

            string str = "Sajag";
            int count = 2;
            //Array
            string[] empNames = { "Sajag", "Abhay", "Manish", "John", "Praveen" };

            //i++
            for(int i = 0; i <= 4; i = i + 1)
            {
                Console.WriteLine(empNames[i]);
            }


            Console.WriteLine(str.Length);
            Console.WriteLine(str.Contains("sa"));
            for(int j = 3; j >= 1; j = j - 1)
            {
                for (int i = 1; i <= j; i = i + 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
           

            //for (int i = 1; i <= 2; i = i + 1)
            //{
            //    Console.Write("*");
            //}
            //Console.WriteLine("");


            //for (int i = 1; i <= 1; i = i + 1)
            //{
            //    Console.Write("*");
            //}
            //Console.WriteLine("");




            //Console.WriteLine(empNames[1]);
            //Console.WriteLine(empNames[2]);
            //Console.WriteLine(empNames[3]);
            //Console.WriteLine(empNames[4]);



            Console.WriteLine("Hello World!");
        }
    }
}
