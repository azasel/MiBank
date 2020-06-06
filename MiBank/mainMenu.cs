using System;
using System.Collections.Generic;
using System.Text;

namespace MiBank
{
    class mainMenu
    {

        public int currentMenuLevel;

        

        public void DisplayMenu() {
            Console.WriteLine("-- Customer Name Placeholder --");
            Console.WriteLine();
            Console.WriteLine("[1] Deposit");
            Console.WriteLine("[2] Withdraw");
            Console.WriteLine("[3] Transfer");
            Console.WriteLine("[4] My Statement");
            Console.WriteLine("[5] Logout");
            Console.WriteLine("[6] Reset System");
            Console.WriteLine("[7] Exit");
            Console.WriteLine();
            Console.Write("Choose an option: ");
        }
    }
}
