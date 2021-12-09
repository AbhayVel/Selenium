using QdnSeleniumDriver;
using System;
using System.Collections.Generic;
using System.Text;

namespace First
{

    // access modifier -> 
   // 1. default
   // internal 
   //private 
   //public 
   //protected 
   //internal protected 
  public  class User : Human
    {

internal int j = 90;
         private int k=12; //field 
        public int Id { get; set; } //property 

      public  User() //constroctor 
        {

        }

    internal    protected void ShowData() //method/behaviour  
        {
            k = 12;

        }

         void Show() //method/behaviour  
        {
            k = k + 4;
        }

        public override string GetId()
        {
            return "111";
        }

        
    }
}
