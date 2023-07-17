using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assesment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace assignment_5
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int attempts = 0;

                string validUsername = "john";
                string validPassword = "pass123";

                while (attempts < 3)
                {
                    Console.Write("Input username: ");
                    string username = Console.ReadLine();

                    Console.Write("Input password: ");
                    string password = Console.ReadLine();

                    if (username == validUsername && password == validPassword)
                    {
                        Console.WriteLine("Login successful...");
                        return;
                    }
                    else if (username == validUsername)
                    {
                        Console.WriteLine("Invalid password.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid username.");
                    }

                    attempts++;
                    Console.WriteLine();
                }

                Console.WriteLine("Login failed.");
                Console.ReadLine();
            }
        }
    }
}
    }
}
