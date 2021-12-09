using First;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstD
{
   public class OtherRun
    {

        public static void Main(string[] args)
        {

            Human user2 = new User();
            Human user;
            string input = Console.ReadLine();
            if (input.Equals("user"))
            {
                user = new User();
            }else
            {
                user = new UserData();
            }
            //User user = new Human();
            user.ShowHuman();
            string str = "Abhay";
            str.Equals("abhay", StringComparison.OrdinalIgnoreCase);

            Console.WriteLine(1);



           // user.j = user.j + 1;
            //user
        }
    }
}
