using System;
using System.Collections.Generic;
using System.Text;

namespace MiBank {
    class SavingsAccount : account {


        
        public SavingsAccount() {
            _accType = accountType.savings;
            _accNumber = 2222;
            _balance = 300;
            _transactions = new List<transaction>();
        }

      
        public override string atmWithdrawal(float amount) {
            throw new NotImplementedException();
        }

        public override string serviceCharge(int accountNumber) {
            throw new NotImplementedException();
        }

        public override string statement(int accountNumber) {
            Console.WriteLine("STETMENT!!!!");
            return "Satement Completed";
        }

        public override string withdrawal(float amount) {
            throw new NotImplementedException();
        }

        public override string deposit(double amount) {
           
            if (amount <= 0) {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            //char type, double amount, string method, DateTime dateTime, int customerID, int accNumber
            transaction receipt = new transaction('D', amount, "banking", DateTime.Now, _customerID, _accNumber);
            _transactions.Add(receipt);

            return "Deposit Made Successfully";
        }
    }
}
