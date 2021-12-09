using QdnSeleniumDriver;
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
    class Program_002_5
    {

        //Create one Method which take string and return distict charcters of that string in any case.
        static void Main_005_1(string[] args)
        {
            string name = "Sajag Karki s";


           // "SajgKrkis"<---
           //"sajgkri"<--
            var result = GetDistinct(name);

            Console.WriteLine(result);
            Console.ReadLine();

        }


        public static string GetDistinct(string name)
        {
            string result = "";
            name = name.ToLower();
            name = name.Replace(" ", "");
             for (int i=0;i< name.Length; i = i + 1)
            {
                if(!result.Contains(name[i]))
                {
                    result = result + name[i].ToString();
                  //result=  result.Insert(result.Length, name[i].ToString());
                }
            }


            return result;
        }

        
        
    }
}
