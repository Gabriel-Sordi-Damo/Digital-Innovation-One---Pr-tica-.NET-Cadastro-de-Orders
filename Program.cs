using System;
using Menu;
using Options.OrderOptions;
using Options;

namespace APPCadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            ExitOption exitOption = new ExitOption();
            AddOption addOption = new AddOption();
            DeleteOption deleteOption = new DeleteOption();
            UpdateOption updateOption = new UpdateOption();
            PrintAllOption printAllOption = new PrintAllOption();
            PrintOption printOption = new PrintOption();
            Menu.Menu.RegisterOption(exitOption);
            Menu.Menu.RegisterOption(addOption);
            Menu.Menu.RegisterOption(deleteOption);
            Menu.Menu.RegisterOption(updateOption);
            Menu.Menu.RegisterOption(printAllOption);
            Menu.Menu.RegisterOption(printOption);
            Menu.Menu.ExecuteApp();
            Console.WriteLine("Hello World!");
        }
    }
}
