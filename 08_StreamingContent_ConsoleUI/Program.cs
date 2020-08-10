using _08_StreamingContent_ConsoleUI.Consoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a RealConsole for the "production" app
            var console = new RealConsole();
            // UI Class Instance
            ProgramUI ui = new ProgramUI(console);
            ui.Start();
        }
    }
}
