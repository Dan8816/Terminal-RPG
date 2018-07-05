using System;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Adam = new Human("Adam",2,4,6);
            System.Console.WriteLine(Adam.health);
            Human Eve = new Human("Eve",2,4,6,50);
            System.Console.WriteLine(Eve.health);
            Adam.attack(Eve);
            System.Console.WriteLine(Eve.health);
            Wizard Merlin = new Wizard("Merlin"); 
            Adam.attack(Merlin);  
            System.Console.WriteLine(Merlin.health);       
            Merlin.heal();           
            Merlin.fireball(Adam);
            Ninja Ryoku = new Ninja("Ryoku");
            Ryoku.stealHealth(Merlin);          
            Ryoku.get_away();
            Samurai TomCruise = new Samurai("Tom Cruise");
            TomCruise .deathBlow(Eve);
            System.Console.WriteLine(Eve.health);
            TomCruise.meditate();
            System.Console.WriteLine(TomCruise.health);
            System.Console.WriteLine(Samurai.activeCount);


           

            
            
 

        }
    }
}