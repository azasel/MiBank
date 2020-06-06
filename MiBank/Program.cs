using System;
using System.Security.Cryptography;

namespace MiBank
{
    class Program
    {
        static void Main(string[] args)
        {
            mainMenu navigator = new mainMenu();

            //MyCode.ListInit();

            ConsoleKeyInfo cki;

            do
            {
                navigator.DisplayMenu();
                cki = Console.ReadKey(false); // show the key as you read it
                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        Console.WriteLine("selected 1");
                        break;
                    case "2":
                        Console.WriteLine("selected 2");
                        break;
                    // etc..
                    case "7":
                        Console.WriteLine("..... Exiting Sytem");
                        break;
                    default :
                        Console.WriteLine("You Must only Enter the Numbers detailed in the menue or escape to exit");
                        break;

                }
            } while (cki.Key != ConsoleKey.NumPad7 & cki.Key != ConsoleKey.D7);
        }
    }
}
