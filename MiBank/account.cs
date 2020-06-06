using MiBank;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace MiBank{
    enum accountType { checking, savings };
    

    abstract class account{

        private float _balance;
        private int _accNumber;
        private int _customerID;
        private accountType _accType;
        private double _freeTrans;
       // private Hashtable _type = new Hashtable() { { "W", "Withdrawal" }, { "D", "Deposit" }, { "T", "Transfer" }, { "S", "Service Charge" } };
        private List<transaction> _transactions ;
        private int _nextTransactionID;


        public string deposit(double amount) {
            
            if (amount <= 0) {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            //char type, double amount, string method, DateTime dateTime, int customerID, int accNumber
            var deposit = new transaction('D',amount,"banking", DateTime.Now, _customerID, _accNumber);
            _transactions.Add(deposit);

            return "Deposit Made Successfully";
        }

        public abstract string withdrawal(float amount);
        public abstract string atmWithdrawal(float amount);
        public abstract string statement(int accountNumber);
        public abstract string serviceCharge(int accountNumber);
    }
}





/*The user should be able to make deposits and withdrawals within the constraints list in the
business rules section of this specification.
• The user should be able to transfer money between their own accounts.
• The transaction on both accounts should be of Type ‘T’.
Web Development Technologies
OUA Study Period 2 - 2020 6
iv) My Statement (3.5 marks)
My Statements allows the user to see the current balance for a specified account and list its
transaction history.
• The transactions should be ordered by transaction date/time with the most
recent transaction first.
• Transactions must be displayed in a paged manner, showing only 4 transactions
at a time and allows the user to move to the next page as appropriate.
• Selecting next page on the final page of transactions should return the user to
page one.
• Exiting the my statement feature should also set the current page back to page
one.
• If the my statement option is selected again, it should display the first page of
the statement, not the page it was on prior to exiting the statement feature.*/