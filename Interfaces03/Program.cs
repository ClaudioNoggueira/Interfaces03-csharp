using Devices;
using System;

namespace Interfaces03 {
    class Program {
        static void Main(string[] args) {
            Printer printer = new Printer() { SerialNumber = 1080 };
            printer.ProcessDoc("My letter");
            printer.Print("My letter");

            Scanner scanner = new Scanner { SerialNumber = 2112 };
            scanner.ProcessDoc("My email");
            System.Console.WriteLine(scanner.Scan());

            ComboDevice combo = new ComboDevice() { SerialNumber = 2124 };
            combo.ProcessDoc("My dissertation");
            combo.Print("My dissertation");
            Console.WriteLine(combo.Scan());
        }
    }
}
