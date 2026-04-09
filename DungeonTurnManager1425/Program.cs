using System;
using System.Dynamic;

public class Program //BuildYourOwnQueueO51
{
	public static void Main()
	{

        Hero Rorin = new Hero(); //default hero needs no updates
        Hero Aria = new Hero("Aria", "Mage", 100); //new one update name, class, and health
        Hero Gonzo = new Hero("Gonzo", "Archer", 150); //new one

		Queue<Hero> turnQueue = new Queue<Hero>();
        //change this to Queue<Hero> not string

        
        turnQueue.Enqueue(Rorin);
        turnQueue.Enqueue(Aria);
        turnQueue.Enqueue(Gonzo);

    }

    public class Hero
    {
        string Name {get; set;} = "RorinDefault"; //must already have a value
                                //but we set it again in each Hero
        string SoldierClass {get; set;} = "WarriorDefault";
        int Health {get; set;} //should it be int? or 
    //should i convert like int.Parse, math, and save toString? everytime
        public Hero()
        {
            this.Name = "Rorin the brave";
            this.SoldierClass = "Warrior";
            this.Health = 200;
        }
        public Hero(string name, string SoldierClass, int Health)
        {
            this.Name = name;
            this.SoldierClass = SoldierClass;
            this.Health = Health;
        }
    }
}