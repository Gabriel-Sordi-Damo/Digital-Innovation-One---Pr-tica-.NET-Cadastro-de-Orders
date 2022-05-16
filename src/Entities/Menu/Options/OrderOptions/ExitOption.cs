using MemoryDB.OrderMemoryDB;
using System;
namespace Options.OrderOptions
{

    class ExitOption : Option
    {
        public ExitOption() : base(
            "0 - Exit\n",
            0,
            Exit
        )
        { }
        public static int Exit()
        {
            System.Environment.Exit(0);
            return 0;
        }
    }
}