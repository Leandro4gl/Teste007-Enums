using System;
using System.Collections.Generic;
using System.Text;
using Teste007_Enums.Entities.Enums;

namespace Teste007_Enums.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}
