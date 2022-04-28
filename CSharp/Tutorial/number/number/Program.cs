using System;
//nameSpace
namespace number
{
    //Main class
    class Program
    {
        //entry 
        static void Main(string[] args)
        {
            //START Here
            string appName = "Number lucky";
            string appVer = "1.1.2";
            string appMake = "DevTrinh";
            //change text color
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("APPLICATON \nAppName: {0} \nVersion: {1}\nMake by: {2}", appName, appVer, appMake);
            Console.ResetColor();
            Console.WriteLine("APPLICATON \nAppName: {0} \nVersion: {1}\nMake by: {2}", appName, appVer, appMake);
            Console.WriteLine("What is your name ?");
            string inputName = Console.ReadLine();
            Console.WriteLine("my name is {0}", inputName);
            int correctNumber = 7;
            int guess = 0;
            Console.WriteLine("Guess a number between 1 and 10 !");
            while(guess != correctNumber)
            {
                string input = Console.ReadLine();
                //chuyển kiểu string sang int;
                guess = Int32.Parse(input);
            }
        }
    }
}