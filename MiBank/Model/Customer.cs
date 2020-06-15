using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MiBank
{

    public class Customer {
        public string _firstName { get; }
        private string _lastName;
        private int _customerID; // 4 didgits
        public List<account> _accounts = new List<account>();

        public Customer(List<account> accounts, string firstName, string lastName, int customerID) {
            _accounts = accounts;
            _firstName = firstName;
            _lastName = lastName;
            _customerID = customerID;

        }

        public account GetAccountByNumber(int accountNumber) {

          /*  foreach (account acc in _accounts) {
                if (acc.AccNumber == accountNumber) {
                    return acc;
                }
            }*/
            return null;

        }
        public account GetAccountByType(string type) {
            accountType accType;
           
            if (String.Equals(type.ToUpper(), "S")) {
                accType = accountType.savings;
            }else { accType = accountType.checking; }

            foreach (account acc in _accounts) {
                if (String.Equals(acc._accType.ToString(), accType.ToString())) {
                    return acc;
                }
            }
            return null;

        }


    }


}
