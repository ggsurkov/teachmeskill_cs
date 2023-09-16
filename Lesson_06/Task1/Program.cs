using Lib;
using System.Xml.Linq;

namespace JustApp
{
    class JustExample
    {
        static void Main()
        {
            Admin admin = new Admin();
            WebSecurity webSecurity = new WebSecurity();

            Console.WriteLine("Hello! Please, enter the name of new user and access level of system from 0 to 3");
            string nameOfNewUser = Console.ReadLine();
            int accessLevelOfNewUser = Convert.ToInt32(Console.ReadLine());

            if (nameOfNewUser == null || accessLevelOfNewUser == null)
            {
                Console.WriteLine("Wrong insert! Restart the application please");
            }
            User newUser = admin.CreateUserByNameAndAccessLevel(nameOfNewUser, accessLevelOfNewUser);

            Console.WriteLine("Thank you! Let's look at this information: \r\n");
            webSecurity.GetInfoByParam(newUser);
        }
    }
}