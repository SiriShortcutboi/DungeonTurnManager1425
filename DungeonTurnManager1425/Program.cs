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
        

        for (int i = 0; i <10; i++)
        { 
            //enqueue just as much as dequeue
        turnQueue.Enqueue(Rorin);
        turnQueue.Enqueue(Aria);
        turnQueue.Enqueue(Gonzo);

        Console.WriteLine($"{turnQueue.Dequeue().Name} topples a giant! 50 damage!\n");//same command prints 
        Console.WriteLine($"{turnQueue.Dequeue().Name} fires multi-shot explosion spell! 30 damage!\n");// out 3 different 
        Console.WriteLine($"{turnQueue.Dequeue().Name} must keep up with Aria. Rains down" // things
        + " volley of arrows!\n");//             ^
                        //Dequeue print out the (^name property) of whatever Hero sits in Dequeue()
        }//end loop
        Console.WriteLine("All turns completed");

    }

    public class Hero
    {
        public string Name {get; set;} = "RorinDefault"; //must already have a value
                                //but we set it again in each Hero
        public string SoldierClass {get; set;} = "WarriorDefault";
        public int Health {get; set;} //should it be int? or 
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

//If trying to make an inventory system each class would inherit 
//Accessory: Iitem
//Head: Iitem
//Potion: Iitem

//List<Iitem>

// you would never have just an armor though, like Helmet comes from Armor through abstract


//this could be pretty simple to just abstract washer or dryer for my laundry app

// a laundry machine object should have MachineType (washer or dryer)
//                                      MachineNumber (which machine out of 8)
//                                      MachineInitialTime
//                                      MachineTimeLeft
//                                      Machinebool isFinished

//                                      Machinebool hasNotifiedOwner
//                                      Machinebool hasNudgeMessagedOwner

