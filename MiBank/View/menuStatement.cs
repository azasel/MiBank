using System;

namespace MiBank {
    internal class menuStatement : navigations {

        public double level { get; } = 2.3;
        public void displayMenuItem(ref systemInitialise system) {
            throw new System.NotImplementedException();
        }

        public double validateInput(double level, string input, ref systemInitialise system) {
            Console.WriteLine("STETMENT!!!!");
            return 2.0;
        }
    }
}