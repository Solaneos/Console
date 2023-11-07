using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleEstudos.Entities.Enums;

namespace ConsoleEstudos.Entities
{
    internal class Orders
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public DateTime? OrderDate { get; set; }
        public OrderStatus? Status { get; set; }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + OrderDate + ", " + Status;
        }
    }
}
