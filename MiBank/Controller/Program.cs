using System;




namespace MiBank {
    class Program
    {
        static void Main(string[] args)
        {
            systemInitialise system = new systemInitialise();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("");
            Console.WriteLine("          *   *    * *****  *****  *    *   *   *    ");
            Console.WriteLine("         * * * *     *   *  *   *  * *  *   *  *   ");
            Console.WriteLine("        *   *   *  * *****  *****  *  * *   * * ");
            Console.WriteLine("        *       *  * *   *  *   *  *   **   *  *      ");
            Console.WriteLine("        *       *  * *****  *   *  *    *   *   *      ");
            Console.ForegroundColor = ConsoleColor.White;
            //await system.api.getResponse();
            //javaScriptSerialixer serializer = new JavaScriptSerializer();




            string val;
            double wLevel;

                do {
                double level = system.currMenu.level;
                wLevel = system.currMenu.level;
                system.currMenu.displayMenuItem(ref system);
                val = Console.ReadLine();
                system.SetMenu(system.currMenu.validateInput(wLevel, val,ref system));
                } while (wLevel != 2.0 || string.Compare(val,"7")!=0);
        }

 
    }
}
