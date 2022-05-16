
using System;
using MemoryDB.OrderMemoryDB;

namespace Options.OrderOptions
{

    class PrintAllOption : Option
    {

        public PrintAllOption() : base(
          "4 - Print all\n",
          4,
          PrintAll
      )
        { }
        public static int PrintAll()
        {
            Console.Clear();
            foreach (Order.Order order in OrderMemoryDB.GetAll())
                Console.WriteLine(order);
            return 0;
        }
    }
}