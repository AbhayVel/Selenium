using System;
using System.Collections.Generic;
using System.Text;

namespace First
{

    //ACssess Modifier + *"static"  + "class" + ClassName + *":" + *"Parent Class"
   public  class StartProgram123
    {//<-Scope of the class 

        //*"AM" + *"static" + Type + Name


        //=  "new" + Constructor{ClassName}
        Human human = new Human(); //F

        Human Human2;


        

        //ACssess Modifier + *"static"  + return Type + MethodName (*"Type Name", *"Type Name",*"Type Name",................(0..n))
        public void PrintData()  //Verb
        {
            human.SetName("Sajag");

            human.Salary = 20000;
            human.GetName();
            Console.WriteLine(human.Salary);

        }

        public void PrintData(string s)//Verb
        {

            Console.WriteLine("I am in Print Data");

        }

        public void PrintData(string s, string s2)//Verb
        {

            Console.WriteLine("I am in Print Data");

        }



       

        public void ShowData()//Verb
        {
            PrintData();
            Console.WriteLine("I am in Print Data");

        }

        //property 
        //feilds 
        //constant 
        //Method 


    }
}


//ACssess Modifier
//public
//private 
//protected
//internal
//Default -Nothing 
