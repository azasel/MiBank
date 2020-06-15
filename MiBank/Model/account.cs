using MiBank;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace MiBank{
    public enum accountType { savings, checking  };
    

    public abstract class account{

        public int _accNumber { get; set; }
        public accountType _accType { get; set; }
        public float _balance { get; set; }
        public int _customerID { get; set; }
        public double _freeTrans { get; set; }
        public List<transaction> _transactions { get; set; }
        public int _nextTransactionID { get; set; }


        public abstract string deposit(double amount);
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