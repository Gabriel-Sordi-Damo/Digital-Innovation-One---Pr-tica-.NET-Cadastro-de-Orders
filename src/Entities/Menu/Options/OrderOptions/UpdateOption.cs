using MemoryDB.OrderMemoryDB;
using System;
namespace Options.OrderOptions
{

    class UpdateOption : Option
    {
        public UpdateOption() : base(
            "3 - Update order\n",
            3,
            Update
        )
        { }
        public static int Update()
        {
            Console.Clear();
            string message = @$"
            Insert order name: 
            ";
            Console.WriteLine(message);
            string orderName = Console.ReadLine();
            message = @$"
            Insert order price:
            ";
            Console.WriteLine(message);
            int orderPrice = int.Parse(Console.ReadLine());
            message = @$"
            Insert order id:
            ";
            Console.WriteLine(message);
            int orderId = int.Parse(Console.ReadLine());

            Order.Order order = OrderMemoryDB.GetById(orderId);
            order.Update(orderName, orderPrice);
            OrderMemoryDB.Update(order);

            return 0;
        }
    }
}