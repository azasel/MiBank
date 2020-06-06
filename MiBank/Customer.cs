using System;
using System.Collections.Generic;
using System.Text;

namespace MiBank
{
    
    class Customer
    {
        private string _firstName;
        private string _lastName;
        private int _customerID; // 4 didgits
        private  account[] _accounts;

        Customer (account[] accounts, string firstName, string lastName, int customerID) {
            _accounts = accounts;
            _firstName = firstName;
            _lastName = lastName;
            _customerID = customerID;

        }
    }


    
   
}
