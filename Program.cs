using System;
using System.Linq;
using ConnectTerminal.Admin;

namespace ConnectTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new anonContext())
            {
                // https://stackoverflow.com/questions/23433980/c-sharp-console-hide-the-input-from-console-window-while-typing#36332407
                /* while (true)
                {
                    var key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                    pass += key.KeyChar;
                }
                */
                Console.Write("Login: ");
                var login = Console.ReadLine();
                Console.Write("Pass: ");
                var pass = Console.ReadLine();

                var users = db.Users.Where(a => a.Login.Contains(login) && a.Pass.Contains(pass));

                if(users.Count() <= 1)
                {
                    Console.WriteLine($"Hello {login}");
                }
                else 
                {
                    Console.WriteLine("Wrong login or pass");
                }
                // foreach (var user in users)
                // {
                //     if (login != user.Login || pass != user.Pass)
                //     {
                //         Console.WriteLine("Wrong passwordl!");
                //     }
                //     else
                //     {
                //         Console.WriteLine("Hello world!");
                //     }
                // }
            }

        }
    }
}
