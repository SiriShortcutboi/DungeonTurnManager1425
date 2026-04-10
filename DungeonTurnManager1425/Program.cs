using System;
using System.Dynamic;
using System.IO;

public class Program
{
    static int Count;
	public static void Main()
	{
        

        Hero Rorin = new Hero(); //default hero needs no updates
        Hero Aria = new Hero("Aria the Mage", "Mage", 100); //new one update name, class, and health
        Hero Gonzo = new Hero("Gonzo the Archer", "Archer", 150); //new one

		Queue<Hero> HeroQueue = new Queue<Hero>();
        //use to take hero turns by dequeue-ing them

        Stack<string> actionHistory = new Stack<string>();
        //use to push messages onto the history, and pop to undo

        //the game loop
        while (true)//run 10 times
        { 
            Count++;
            if (Count >= 10)
            {
                break;
            }
            //enqueue just as much as dequeue in the 10-time-loop
        HeroQueue.Enqueue(Rorin); 
        HeroQueue.Enqueue(Aria);
        HeroQueue.Enqueue(Gonzo);

        Console.WriteLine($"{HeroQueue.Dequeue().Name} topples a giant! 50 damage!\n");//same command prints 
        actionHistory.Push("Rorin's toppling turn, 50 damage");
        Console.WriteLine("Would you like to undo turn? Type 'undo', or to continue press Enter");
        string userInput = Console.ReadLine(); //probably turn this whole if block into
                                               // another class or even namespaced cs file
                                               // starting with writeline and readline
        //userInput = userInput.ToLower().Trim();
        if (string.IsNullOrWhiteSpace(userInput) || userInput == "enter")
            {
                //continue on with the game
                continue;
            }
            //continue means we only sanitize the word "undo" if NOT NULL is already confirmed
        userInput.ToLower().Trim();
        if (userInput == "undo")
            {
                Console.WriteLine("Turn undone: Rorin's toppling turn, 50 damage\n");
                actionHistory.Pop();
            }
        else
            {
                Console.WriteLine("Selection not understood. THE WAR RAGES ON!\n");
            }

        //Aria's turn (start of code upper bound limit) Aria fires multi-shot
        Console.WriteLine($"{HeroQueue.Dequeue().Name} fires multi-shot explosion spell! 30 damage!\n");// out 3 different 
        //push the action onto the stack
        actionHistory.Push("Aria's fiery turn, 30 damage\n");
        Console.WriteLine("Would you like to undo turn? Type 'undo', or to continue press Enter");
        userInput = Console.ReadLine(); //probably turn this whole if block into
                                               // another class or even namespaced cs file
                                               // starting with writeline and readline
        //userInput = userInput.ToLower().Trim();
        if (string.IsNullOrWhiteSpace(userInput) || userInput == "enter")
            {
                //continue on with the game
                continue;
            }
            //continue means we only sanitize the word "undo" if NOT NULL is already confirmed
        userInput.ToLower().Trim();
        if (userInput == "undo")
            {
                Console.WriteLine("Turn undone: Arias fiery turn, 30 damage\n");
                actionHistory.Pop();
            }
        else
            {
                Console.WriteLine("Selection not understood. THE WAR RAGES ON!\n");
            }

        // lower bound Aria

        //Gonzo's turn (start of code upper bound limit) Gonzo must keep up
        Console.WriteLine($"{HeroQueue.Dequeue().Name} must keep up with Aria. Rains down" // things
        + " volley of arrows! 25 damage!\n");//             ^
                        //Dequeue print out the (^name property) of whatever Hero sits in Dequeue()
        actionHistory.Push("Gonzo's Bullseye turn, 25 damage");
        Console.WriteLine("Would you like to undo turn? Type 'undo', or to continue press Enter");
        userInput = Console.ReadLine(); //probably turn this whole if block into
                                               // another class or even namespaced cs file
                                               // starting with writeline and readline
        //userInput = userInput.ToLower().Trim();
        if (string.IsNullOrWhiteSpace(userInput) || userInput == "enter")
            {
                //continue on with the game
                continue;
            }
            //continue means we only sanitize the word "undo" if NOT NULL is already confirmed
        userInput.ToLower().Trim();
        if (userInput == "undo")
            {
                
                Console.WriteLine("Turn undone: No more arrows, 30 damage");
                actionHistory.Pop();
            }
        else
            {
                Console.WriteLine("Selection not understood. THE WAR RAGES ON!\n");
            }

        // lower bound Gonzo
        

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
    /* public class Turnselector()
    {   

        public static Stack<string> TurnUndo {get; set;}
        
        string userInput = Console.ReadLine();

                                userInput = userInput.ToLower().Trim();
  
  starting      if (string.IsNullOrWhiteSpace(userInput) || userInput == "enter")
            {
                //continue on with the game
                continue;
            }

        if (userInput == "undo")
            {
                actionHistory.Pop();
            }Console.WriteLine("Selection not understood. THE WAR RAGES ON!\n");
            




//random final project notes, how i might rework what i heard for my thing 
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

*/