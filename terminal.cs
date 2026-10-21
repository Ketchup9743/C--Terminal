using System;
using System.Collections.Generic;

public static terminal
    {
        public static void Main()
        {
            bool admin = False;
            string password = "admin";
            bool logged_in = False;
            bool[] permissions = new bool[10]
            permissions[0] = False;     // permissions[0] = File Access
            permissions[1] = False;     // permissions[1] = Settings Access
            permissions[2] = False;     // permissions[2] = Root Access
            permissions[3] = False;     // permissions[3] = File.read
            permissions[4] = False;     // permissions[4] = Settings.read
            permissions[5] = False;     // permissions[5] = Root.read
            permissions[6] = False;     // permissions[6] = File.edit
            permissions[7] = False;     // permissions[7] = Settings.edit
            permissions[8] = False;     // permissions[8] = Root.edit
            permissions[9] = False;     // permissions[9] = Admin Access
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("                Welcome to Terminal v1"                         );
            Console.WriteLine("---------------------------------------------------------------");
        }
        static void commands
        {
            string command = Console.ReadLine("Type [HELP] for a list of commands");
            if (commands == "HELP")
            {
                Console.WriteLine("Showing list of available commands");
                Console.WriteLine("[HELP] - Shows a list of available commands");
                Console.WriteLine("[Login]")
            }
        }
    }