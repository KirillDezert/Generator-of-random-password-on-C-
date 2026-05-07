using System;

class Password

{
    static void Main()
    {
        Console.Write("Enter the password: ");
        
        int lenght = int.Result(Console.ReadLine());

        string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQ0123456789!@#$%";

        Random rnd = new Random();
        string password = "";

        for(int i = 0; i < lenght; i++)
        {
            int index = rnd.Next(chars.Lenght);
            password += chars[index];
        }

        Console.WriteLine("Generated password: " + password);
    }
}