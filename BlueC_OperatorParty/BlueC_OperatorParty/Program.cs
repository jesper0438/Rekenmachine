using System;

namespace BlueC_OperatorParty
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Geef een som in (prefix notatie)...");

                string invoer = Console.ReadLine();

                string[] opgesplitsteInvoer = invoer.Split(" ");

                string operatorr = opgesplitsteInvoer[1];

                string number1 = opgesplitsteInvoer[0];
                int getal1 = int.Parse(number1);

                string number2 = opgesplitsteInvoer[2];
                int getal2 = int.Parse(number2);

                if (operatorr == "+")
                {
                    var programma = new Calculator();

                    int result = programma.Plus(getal1, getal2);

                    Console.WriteLine(result);
                    Console.ReadLine();
                    // roep hier netjes de methode
                    // van de calculatorclass aan

                }
                if (operatorr == "*")
                {
                    var programma = new Calculator();

                    int result = programma.Keer(getal1, getal2);

                    Console.WriteLine(result);
                    Console.ReadLine();
                }

                if (operatorr == "-")
                {
                    var programma = new Calculator();

                    int result = programma.Min(getal1, getal2);

                    Console.WriteLine(result);
                    Console.ReadLine();
                }

                if (operatorr == "/")
                {
                    var programma = new Calculator();

                    int result = programma.Gedeeld(getal1, getal2);

                    Console.WriteLine(result);
                    Console.ReadLine();
                }
            }
        }
    }
}
