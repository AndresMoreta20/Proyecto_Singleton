using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelado2
{
    public sealed class ConsolePrinter
    {
        private static ConsolePrinter? instance = null;
        private int count = 0;
        ConsolePrinter()
        {

        }

        public static ConsolePrinter Instance
        {
            get
            {
                instance ??= new ConsolePrinter();
                return instance;
            }
        }

        public void Print(string text)
        {
            Console.WriteLine(text);
            count++;
        }

        public void PrintCount() {
            Console.WriteLine(count);
        }
    }
}
