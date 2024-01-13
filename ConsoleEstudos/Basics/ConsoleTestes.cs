using ConsoleEstudos.Basics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEstudos.Basics
{
    internal class ConsoleTestes
    {
        static void notMain()
        {
            Console.WriteLine("Qual seu nome?");
            var a = Console.ReadLine();
            Console.WriteLine("Prazer em te conhecer");
            Console.WriteLine("Diga-me, {0}, qual o seu pedido?", a);
            var b = Console.ReadLine();

            var order = new Orders { Id = 1, Name = b, OrderDate = DateTime.Now, Status = Entities.Enums.OrderStatus.Processing };

            Console.WriteLine(order.ToString());

        }
    }
}
