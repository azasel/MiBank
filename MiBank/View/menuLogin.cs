using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MiBank {
    class menuLogin : navigations {


        public double level { get; } = 1.0;



        public void displayMenuItem(ref systemInitialise system) {

            Console.WriteLine();
            Console.WriteLine("LOGIN");
            Console.WriteLine("Please Enter Your Login ID: ");
        }

        public double validateInput(double level, string input, ref systemInitialise system) {
            string drowssap = "";
            bool pwCheck;
            string userPW;
            if (input.Length > 0) {
                userPW = system.api.GetResponse(input).Result;
                if (String.IsNullOrEmpty(userPW)) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("****** USER NOT FOUND PLEASE TRY AGAIN ******");
                    Console.ForegroundColor = ConsoleColor.White;
                    system.LoginAttemps = system.LoginAttemps + 1;
                    if (system.LoginAttemps == 3) {
                        Environment.Exit(0);
                    }
                    return 1.0;
                }
            }
            else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("****** USER NOT FOUND PLEASE TRY AGAIN ******");
                Console.ForegroundColor = ConsoleColor.White;
                system.LoginAttemps = system.LoginAttemps + 1;
                if (system.LoginAttemps == 3) {
                    Environment.Exit(0);
                }
                return 1.0; 
            }

            do {
                Console.WriteLine("{0}Please Enter Your Password: ", Environment.NewLine);
                drowssap = Console.ReadLine();
                pwCheck = system.validations.validatePassword(drowssap, userPW);
                if (!pwCheck) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0}****** INCORRECT PASSWORD - PLEASE TRY AGAIN ******{0}", Environment.NewLine);
                    Console.ForegroundColor = ConsoleColor.White;
                    system.LoginAttemps = system.LoginAttemps + 1;
                }
                if (system.LoginAttemps == 3) {
                    Environment.Exit(0);
                }
            } while (!system.validations.validatePassword(drowssap, userPW));



            SavingsAccount testAccount = new SavingsAccount();
            Console.WriteLine($"the created account has an account type {testAccount._accType}");
            List<account> tempList = new List<account>();
            tempList.Add(testAccount);
            system.customer = new Customer(tempList, "Steven", "Jones", 100);
            return 2.0;
        }
    }
}

