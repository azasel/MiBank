using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using SimpleHashing;

namespace MiBank {
    public class inputValidations {

        public bool isDouble (string input) {
            double val;
            if (string.IsNullOrEmpty(input)) {
                Console.WriteLine("You Must Enter a Dollar Amount or X to exit");
                return false;
            }else if (!double.TryParse(input, out val)) {
                Console.WriteLine("You Must Enter Dollar Amounts Only");
                return false;
            }else if (val <= 0) {
                Console.WriteLine("You Can Only Deposit Positive Amounts");
                return false;
            } else {
                return true;
            }
        }


        public bool isInterger(string input) {
            int val;
            if (string.IsNullOrEmpty(input)) {
                Console.WriteLine("You Must Enter an Interger or X to exit");
                return false;
            }
            else if (!int.TryParse(input, out val)) {
                Console.WriteLine("You Must Enter Integers Amounts Only");
                return false;
            }
            else if (val <= 0) {
                Console.WriteLine("You Can Only Deposit Positive Amounts");
                return false;
            }
            else {
                return true;
            }
        }

        public bool CheckStringInput(string[] validValues, string input) {

            foreach (string validValue in validValues) {
                if (String.Compare(validValue, input.ToUpper()) == 0) {
                    return true;
                }
            }
            return false; 
        }

        public bool validatePassword(string input, string hash) {

            if (SimpleHashing.PBKDF2.Verify(hash, input, 50000)) {
                return true;
            }else { return false;}
        }

    }
}
