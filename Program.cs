using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_4
{
    internal class Program
    {
        class User
        {
            public string Name { get; set; }
            public string Location { get; set; }
        }
        static void Main(string[] args)
        {
            User u = new User();
            u.Name = "Ekta Patel";
            u.Location = "Gujarat";
            Console.WriteLine("Name: " + u.Name);
            Console.WriteLine("Location: " + u.Location);
            Console.ReadLine();
        }
    }
}
