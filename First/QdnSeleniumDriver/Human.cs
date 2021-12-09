using System;
using System.Collections.Generic;
using System.Text;

namespace First
{
  public abstract  class Human
    {
       public abstract string GetId();

        public void ShowHuman()
        {
            Console.WriteLine(GetId());
        }
    }
}

// Class
// Object
// polymorphism
// ---> Run Time 
//--> compile Time --> Method overloading 
