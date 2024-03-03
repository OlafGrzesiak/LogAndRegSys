using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

class program
{
    private static Dictionary<string, string> users = new Dictionary<string, string>();

    static void Main()
    {
        Console.WriteLine("Welcome to login and register system.");

        while (true)
        {
            Console.WriteLine("\nChoose option:");
            Console.WriteLine("1. Log In");
            Console.WriteLine("2. Register");
            Console.WriteLine("3. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Login();
                    break;
                
                case "2":
                    Register();
                    break;
                
                case "3":
                    Environment.Exit(0);
                    break;
            }
        }
    }

    static void Login()
    {
        Console.Write("Username: ");
        string username = Console.ReadLine();
        
        Console.Write("Password: ");
        string password = Console.ReadLine();

        if (users.ContainsKey(username) && users[username] == password)
        {
            Console.WriteLine("You have logged in successfully");
        }
        else
        {
            Console.WriteLine("Error, try again");
        }
    }

    static void Register()
    {
        Console.Write("Enter a new username: ");
        string newUsername = Console.ReadLine();

        if (users.ContainsKey(newUsername))
        {
            Console.WriteLine("The username already exists. Choose another one.");
            return;
        }
        
        Console.Write("Choose password: ");
        string newPassword = Console.ReadLine();
        
        users.Add(newUsername, newPassword);
        
        Console.WriteLine("Registration completed successfully");
    }
}

