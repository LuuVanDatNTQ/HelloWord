using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    public class Program
    {
        public static void Main(string[] args)
        {


        }
        public static void sayHi()
        {
            string name;
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
            Console.WriteLine("Welcome to NTQ!!!");
        }

    }
}
