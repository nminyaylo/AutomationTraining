using System;

// Пользователю предлагается ввести имя пользователя и пароль, при совпадении имени пользователя
// и пароля с имеющимися в системе – выдать сообщение об успешном логине, при несовпадении –
// выдать сообщение об ошибке и предложить еще одну попытку. 
// Максимальное количество попыток – 3, при 3 неуспешных попытках авторизации – выдать сообщение об
// ошибке, закрыть приложение после нажатия любого символа.

namespace AuthenticationApp
{
    class Program
    {
        static bool Authentication()
        {
            string user = "admin";
            string password = "pass";

            Console.WriteLine("Enter user name:");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter password:");
            string userPass = Console.ReadLine();

            bool credMatch = (userName == user) && (userPass == password);

            return credMatch;
        }

        static void Main()
        {
            if (Authentication() == true)
            {
                Console.WriteLine("Authentication successful!");
            }
            else 
            {
                int i = 0;
                do
                {
                    Console.WriteLine("Authentication failed. Please try again.");
                    Authentication();
                    i++;
                }
                while (i < 2);

                Console.WriteLine("Authentication failed :(");
            }

            Console.ReadKey();
        }
    }
}