using System;
using Teste007_Enums.Entities;
using Teste007_Enums.Entities.Enums;

namespace Teste007_Enums
{
    class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            
            Console.WriteLine(order);

            //Alterando o Enum para String
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            //Alterando string para Enum
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}
