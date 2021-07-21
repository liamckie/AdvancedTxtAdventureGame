using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedTxtAdventure
{
    static class ConsoleUtils
    {
        public static void WaitForKey()
        {
            Console.WriteLine("Press any key...");
            Console.ReadKey(true);
        }

        public static void QuitConsole()
        {
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
            Environment.Exit(0);
        }
    }
}
