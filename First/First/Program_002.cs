using System;
using System.Collections.Generic;
//using System.Linq;
/*
 * 
 * 
 * 
 */
namespace First
{
    class Program_002
    {
        static void Main_002(string[] args)
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
            string[] empNames = { "Sajag", "Abhay", "Manish", "John", "Praveen", "Suraj", "Santosh", "Akash" };


            List<string> lstEmployee = GetEmployeeNameStartWith(empNames, "A");
            List<string> lstEmployee2 = GetEmployeeNameStartWith(empNames, "S");
            List<string> lstEmployee3 = GetEmployeeNameStartWith(empNames, "M");

            PrintEmployees(lstEmployee, "A");
            PrintEmployees(lstEmployee2, "S");
            PrintEmployees(lstEmployee3, "M");
            //for(var i=0; i < lstEmployee.Count; i =i + 1)
            //{
            //    Console.WriteLine("Start with A  :" + lstEmployee[i]);
            //}


            //for (var i = 0; i < lstEmployee2.Count; i = i + 1)
            //{
            //    Console.WriteLine("Start with S  :" + lstEmployee2[i]);
            //}


            //for (var i = 0; i < lstEmployee3.Count; i = i + 1)
            //{
            //    Console.WriteLine("Start with M  :" + lstEmployee3[i]);
            //}

            //List<string> lstEmployee2 = new List<string>();

            //for (var i = 0; i < empNames.Length; i = i + 1)
            //{

            //    if (empNames[i].StartsWith("S"))
            //    {
            //        lstEmployee2.Add(empNames[i]);
            //    }
            //}






            Console.WriteLine("Hello World!");
        }



        public static void PrintEmployees(List<string> lstEmployee, string swith)
        {
            for (var i = 0; i < lstEmployee.Count; i = i + 1)
            {
                Console.WriteLine("Start with "+ swith + ":" + lstEmployee[i]);
            }
        }

        public static List<string> GetEmployeeNameStartWith(string[] empNames , string swith)
        {
            List<string> lstEmployee = new List<string>();

            for (var i = 0; i < empNames.Length; i = i + 1)
            {

                if (empNames[i].StartsWith(swith))
                {
                    lstEmployee.Add(empNames[i]);
                }
            }

            return lstEmployee;
        }
    }
}
