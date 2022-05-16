using MemoryDB.OrderMemoryDB;
using System;
namespace Options.OrderOptions
{

    class AddOption : Option
    {
        public AddOption() : base(
            "1 - Add order\n",
            1,
            Add
        )
        { }
        public static int Add()
        {
            Console.Clear();
            string message = @$"
            Insert order name: 
            ";
            Console.WriteLine(message);
            string orderName = Console.ReadLine();
            message = @$"
            Inser order price:
            ";
            Console.WriteLine(message);
            int orderPrice = int.Parse(Console.ReadLine());
            OrderMemoryDB.Add(new Order.Order(orderName, orderPrice));
            return 0;
        }
    }
}