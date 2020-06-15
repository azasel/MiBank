using System;
using System.Collections.Generic;
using System.Text;

namespace MiBank {
    public interface navigations {

     
        public double level { get; }
        public void displayMenuItem(ref systemInitialise system);


        public double validateInput(double level, string input, ref systemInitialise system);

    }
}
