using System;

namespace MiBank {
    internal class menuMain : navigations {

        public double level { get; } = 2.0;
        
        public void displayMenuItem(ref systemInitialise system) {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("");
            Console.WriteLine($"********* WELCOME {system.customer._firstName.ToUpper()} ****************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("[1] Deposit");
            Console.WriteLine("[2] Withdraw");
            Console.WriteLine("[3] Transfer");
            Console.WriteLine("[4] My Statement");
            Console.WriteLine("[5] Logout");
            Console.WriteLine("[6] Reset System");
            Console.WriteLine("[7] Exit");
            Console.WriteLine();
            Console.Write("Choose an option: ");
        }

        public double validateInput(double nr, string input, ref systemInitialise system) {

            switch (input) {
                case "1":
                    return 2.1;
                case "2":
                    return 2.2;
                case "3":
                    return 2.3;
                case "4":
                    return 2.4;
                case "5":
                    return 2.5;
                case "6":
                    return 2.6;
                case "7":
                    return 2.0;
                default:
                    Console.WriteLine("You must only enter from the above delection");
                    return 2.0;
            }
        }
    }
}