using System;

namespace Options
{


    class Option
    {
        public string message;
        public int optionNumber;
        public Func<int> executable;

        public Option(string message, int optionNumber, Func<int> executable)
        {
            this.message = message;
            this.optionNumber = optionNumber;
            this.executable = executable;
        }

    }
}