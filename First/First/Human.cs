using System;
using System.Collections.Generic;
using System.Text;

namespace First
{
   public  class Human
    {
     //   *"AM" + ClassName(*"Type name", *Type name",....(0..n)
        public  Human()
        {

        }

      private  Human(string s)
        {

        }
        //*"AM" + *"static" + Type + Name

       //Field //instance variable 
     

      private  string Address;


        //***C# way for Property START ***/
        public string Age { get; set; }

        //***C# way for Property END ***/



        //***C# way for Property START ***/
        private float _salary;
        public float Salary { 
            get {
                
                
                return _salary;


            } 
            set
            {

                _salary = value;
            }
        }
        //***C# way for Property END ***/

        public string gender;

    //***Java way for Property START ***/
        private string name;
      public string GetName() //<-- Getter 
      {
            if (gender == "M")
            {
                return "Mr. " + name;
            }
            return "Miss. " + name;
        }
    public void SetName(string name) //<-Setter 
        {
            
            this.name = name.ToUpper();
        }
        //***Java way START ***/


    }


    public class Child : Human
    {
       public string schoolName;
    }
}
