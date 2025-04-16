namespace Inheritance_Mangum_Stephen
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Fortnite myGame = new Fortnite("E", "Fortnite"); // Creates a new Fortnite object and gives it the ESRB rating and name (Fortnite).
            Console.WriteLine(myGame.Describe()); // Calls Describe and prints the information to the console
            myGame.PlayGame(); // Starts Fortnite!! YAY.
        }
    }

}