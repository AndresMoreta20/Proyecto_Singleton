using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrinterSystem
{
    public sealed class ConsolePrinter
    {
        private static ConsolePrinter instance = null;
        ConsolePrinter()
        {

        }

        public static ConsolePrinter Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ConsolePrinter();
                }
                return instance;
            }
        }

        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
//public sealed class ConsolePrinter
//{
//    private static ConsolePrinter instance = null;
//    ConsolePrinter()
//    {

//    }

//    public static ConsolePrinter Instance
//    {
//        get
//        {
//            if (instance == null)
//            {
//                instance = new ConsolePrinter();
//            }
//            return instance;
//        }
//    }

//    public void Print(string text)
//    {
//        Console.WriteLine(text);
//    }
//}
