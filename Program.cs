using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace SOLID_DIP
{
    public class Program
    {
        public static void Main()
        {
            Terminal terminal = new Terminal();
            while (!terminal.Exited)
            {
                ICommand command = terminal.PromptCommand();
                terminal.ExecuteCommand(command);
            }
        }
    }

}
