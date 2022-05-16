
using System;
using MemoryDB.OrderMemoryDB;

namespace Options.OrderOptions
{

    class DeleteOption : Option
    {

        public DeleteOption() : base(
          "2 - Delete order\n",
          2,
          Delete
      )
        { }
        public static int Delete()
        {
            Console.Clear();
            string message = @$"
            Insert order id: 
            ";
            Console.WriteLine(message);
            int orderId = int.Parse(Console.ReadLine());
            OrderMemoryDB.Delete(orderId);
            return 0;
        }
    }
}