using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using Inheritance_Mangum_Stephen;

public class Fortnite : Game // A derived class from Game. Its Fortnite!!! Yippee yippee yippee!!!
{
    public Fortnite(string esrb, string title) : base(esrb, title) // Constructor that passes Fortnite's ESRB rating and title to itself.
    {
    }

    public override string Describe() // Overrides the abstract class Describe.
    {
        return $"{Title} is a third-person shooter game rated {ESRB}. Get ready to crank some 90s, boiiiii!!!";
    }
}

