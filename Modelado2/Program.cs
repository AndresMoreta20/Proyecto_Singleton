using Modelado2;

class Program
{
    static void Main(string[] args)
    {
        ConsolePrinter printer1 = ConsolePrinter.Instance;
        printer1.Print("Mensaje de prueba");
        printer1.PrintCount();

        ConsolePrinter printer2= ConsolePrinter.Instance;
        printer2.Print("Mensaje de prueba");
        printer2.PrintCount();
    }

}