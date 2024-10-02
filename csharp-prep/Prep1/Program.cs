using System;

class Program
{
    static void Main(string[] args)
    {
         Console.Write("What is your first name? ");
         string fname = Console.Readline();

         Console.Write("What is your last name? ");
         string lname = Console.Readline();
         
         Console.Writeline($"Your name is {lname}, {fname}{lname}.");

    }
}