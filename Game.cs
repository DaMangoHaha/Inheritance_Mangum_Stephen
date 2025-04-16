using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

public abstract class Game // The abstract class named Game. It's like, right there dawg.
{
    public string ESRB { get; set; }
    public string Title { get; set; }
    // Automatic properties for Fortnite's ESRB rating and the title...Fortnite...woah

    public Game(string esrb, string title) // Constructor that sets Fortnite's ESRB rating and its title.
    {
        ESRB = esrb;
        Title = title;
    }
   
    public void PlayGame() //Prints that Fortnite is starting!! S0 kewl!1!!!!11 ;-;
    {
        Console.WriteLine($"{Title} is Starting");
    }

    public abstract string Describe(); //Abstract method or something that tells the derived classes what to do, I don't know how to word it...ouch.
}
