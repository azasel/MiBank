using System;

namespace MiBank {
    internal class menuDeposit : navigations {


        public double level { get; } = 2.1;
        public void displayMenuItem(ref systemInitialise system) {
            Console.WriteLine("");
            Console.WriteLine("   ****  DEPOSIT  ****");
            Console.WriteLine("");
            Console.WriteLine("Please Enter The Amount or X to exit: ");
        }

        public double validateInput(double level, string input, ref systemInitialise system) {
          
            string accountType;
            if (String.Compare("X", input.ToUpper()) == 0) { return 2.0; }
            if (!system.validations.isDouble(input)) {
                return 2.1;
            }
            do {
                System.Console.WriteLine("Please Select Account Savings (S) or Checking (C):");
                accountType = Console.ReadLine();
                if (String.Compare("X", input.ToUpper()) == 0) { return 2.0; }
            } while (!system.validations.CheckStringInput(new string[] { "C", "S" }, accountType));

            system.customer.GetAccountByType(accountType).deposit(Convert.ToDouble(input));
            return 2.0;
        }
    }
}