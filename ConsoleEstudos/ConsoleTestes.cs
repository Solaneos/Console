using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEstudos
{
    internal class ConsoleTestes
    {
        static void Main()
        {
            Console.WriteLine("Qual seu nome");
            var a = Console.ReadLine();
            Console.WriteLine("Prazer em te conhecer, {0}", a);
        }
    }
}
