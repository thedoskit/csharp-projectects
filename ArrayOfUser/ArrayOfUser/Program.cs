// See https://aka.ms/new-console-template for more information
using System;

class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public string Gender { get; set; }

    public User(string name, string email, string password, string phoneNumber, string address, string gender)
    {
        Name = name;
        Email = email;
        Password = password;
        PhoneNumber = phoneNumber;
        Address = address;
        Gender = gender;
    }
}

class Program
{
    static void Main(string[] args)
    {
        const int MaxUsers = 100; // Maximum number of users
        User[] users = new User[MaxUsers];
        int userCount = 0;

        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add a new user");
            Console.WriteLine("2. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    if (userCount < MaxUsers)
                    {
                        User newUser = CreateUser();
                        if (newUser != null)
                        {
                            users[userCount] = newUser;
                            userCount++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Maximum number of users reached.");
                    }
                    break;
                case "2":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }
        }
    }

    static User CreateUser()
    {
        Console.WriteLine("Enter user details:");

        Console.Write("Name: ");
        string name = Console.ReadLine();
        if (string.IsNullOrEmpty(name) || name.Length < 4)
        {
            Console.WriteLine("Name must not be empty and should be at least 4 characters long.");
            return null;
        }

        Console.Write("Email: ");
        string email = Console.ReadLine();

        Console.Write("Password: ");
        string password = Console.ReadLine();
        if (string.IsNullOrEmpty(password) || password.Length < 8)
        {
            Console.WriteLine("Password must not be empty and should be at least 8 characters long.");
            return null;
        }

        Console.Write("Phone number (11 digits): ");
        string phoneNumber = Console.ReadLine();
        if (string.IsNullOrEmpty(phoneNumber) || phoneNumber.Length != 11)
        {
            Console.WriteLine("Phone number must not be empty and should contain exactly 11 digits.");
            return null;
        }

        phoneNumber = "+234" + phoneNumber;

        Console.Write("Address: ");
        string address = Console.ReadLine();

        Console.Write("Gender (Male/Female): ");
        string gender = Console.ReadLine().ToLower();
        if (gender != "male" && gender != "female")
        {
            Console.WriteLine("Gender must be either Male or Female.");
            return null;
        }

        return new User(name, email, password, phoneNumber, address, gender);
    }
}
