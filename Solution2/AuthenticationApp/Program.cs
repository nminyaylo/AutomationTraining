using System;

// Пользователю предлагается ввести имя пользователя и пароль, при совпадении имени пользователя
// и пароля с имеющимися в системе – выдать сообщение об успешном логине, при несовпадении –
// выдать сообщение об ошибке 

namespace AuthenticationApp
{
    class Program
    {
        static void Main()
        {
            string user = "admin";
            string password = "adminPass1";

            Console.WriteLine("Enter user name:");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter password:");
            string userPass = Console.ReadLine();

            bool credMatch = (userName == user) && (userPass == password);

            if (credMatch == true)
            {
                Console.WriteLine("Authentication successful!");
            }
            else
            {
                Console.WriteLine("Authentication failed :(");
            }
        }
    }
}
