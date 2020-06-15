using System;

namespace MiBank {
    internal class menuWithdrawal : navigations {

        public double level { get; } = 2.2;
        public void displayMenuItem(ref systemInitialise system) {
            Console.WriteLine("");
            Console.WriteLine("   ****  WITHDRAWAL  ****");
            Console.WriteLine("");
            Console.WriteLine("Please Enter The Amount: ");
        }

        public double validateInput(double level, string input, ref systemInitialise system) {
            return 2.0;
        }
    }
}