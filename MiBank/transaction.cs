using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MiBank {

    class transaction {

        private int transactionID;
        private int customerID;
        private int accNumber;
        private DateTime _dateTime;
        private char _type;
        private double _amount;
        private string _method;


        public transaction(char type, double amount, string method, DateTime dateTime, int customerID, int accNumber) {

        }
    }
}
