using System;
namespace COS2007_Lab1._2P
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Message myMessage = new("Hello, World! Greetings from Message Object.");
            myMessage.Print();

            Message[] messages = new Message[4];

            messages[0] = new("Hello Dylan, nice to see you again!");
            messages[1] = new("Hello Chris, intersting you are here!");
            messages[2] = new("Hello Noah, what did you do today?");
            messages[3] = new("Hello Narlah, do you want some food?");
            messages[4] = new("Hello stranger, what's up?");

            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            if (name.ToLower() == "dylan")
            {
                messages[0].Print();
            }
            else if (name.ToLower() == "chris")
            {
                messages[1].Print();
            }
            else if (name.ToLower() == "noah")
            {
                messages[2].Print();
            }
            else if (name.ToLower() == "narlah")
            {
                messages[3].Print();
            }
            else
            {
                messages[4].Print();
            }
        }
    }
}


