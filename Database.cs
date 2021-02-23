using System;
using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.EntityFrameworkCore;
using ConnectTerminal.Admin;

namespace ConnectTerminal
{
    public class Database
    {
        public string connectionString;
        public void CreateConnection()
        {
            Console.Write("Server: ");
            var server = Console.ReadLine();
            Console.Write("Database: ");
            var database = Console.ReadLine();
            Console.Write("User: ");
            var user = Console.ReadLine();
            Console.Write("Pass: ");
            var pass = Console.ReadLine();
            
            connectionString = $"Server={server};Database={database};User={user};Password={pass}";
        }

        public void TestConnection()
        {
            using(var context = new anonContext())
            {
                var users = context.Users.ToListAsync();
            }
        }
    }
}