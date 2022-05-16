using System;
using System.Collections.Generic;
using Options;
using Options.OrderOptions;

namespace Menu
{

    class Menu
    {
        private static string menuMessage = @$"";

        private static Dictionary<int, Func<int>> menuOptions = new Dictionary<int, Func<int>>();

        static public void RegisterOption(Option option)
        {
            menuOptions.Add(option.optionNumber, option.executable);
            menuMessage += option.message;
        }
        static public void ExecuteApp()
        {
            while (true)
            {
                Console.WriteLine(menuMessage);
                int input = int.Parse(Console.ReadLine());
                if (menuOptions.ContainsKey(input))
                    menuOptions[input]();
            }
        }

    }
}