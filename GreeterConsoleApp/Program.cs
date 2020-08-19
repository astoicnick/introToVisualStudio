using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreeterConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string usersName = GetName();
            Console.WriteLine("Hello, " + usersName);
            Console.ReadLine();
        }
        static string GetName()
        {
            Console.WriteLine("Hey! What's yo name?");
            string name = Console.ReadLine();
            return name;
        }
    }
}
