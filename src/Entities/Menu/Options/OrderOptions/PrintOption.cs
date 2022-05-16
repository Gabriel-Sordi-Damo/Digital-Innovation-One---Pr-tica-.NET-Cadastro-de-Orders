
using System;
using MemoryDB.OrderMemoryDB;

namespace Options.OrderOptions
{

    class PrintOption : Option
    {

        public PrintOption() : base(
          "5 - Print order\n",
          5,
          Print
      )
        { }
        public static int Print()
        {
            Console.Clear();
            string message = @$"
            Insert order id: 
            ";
            Console.WriteLine(message);
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine(OrderMemoryDB.GetById(id));
            return 0;
        }
    }
}