using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_ConsoleUI.Consoles
{
    public interface IConsole
    {
        void WriteLine(string s);
        void WriteLine(object o);
        void Write(string s);
        void Clear();
        string ReadLine();
        ConsoleKeyInfo ReadKey();
    }
}
