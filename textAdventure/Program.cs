using System;

namespace textAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            gameTitle();
        }
        public static void gameTitle()
        {
            Console.WriteLine("Welcome to Zombie Adventure!");
            Console.WriteLine("Press 'Enter' to begin");
            Console.ReadLine();
            Console.Clear();
            location();
        }

        public static void location()
        {
            Console.WriteLine("You wake up in a stranger's living room, not sure of how you got there. You start to feel a pain in the back of your \nhead to discover you've got a bump.");
            Console.ReadLine();
            Console.Clear();
            first();
        }


        public static void first()
        {
            string choice;
            Console.WriteLine("You're in the living room");
            Console.WriteLine("What do you do?");
            Console.WriteLine("1.Check your pockets.");
            Console.WriteLine("2.Check for a way out.");
            Console.WriteLine("3.Call out for anyone inside the house.");
            Console.WriteLine("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    {
                        Console.WriteLine("You check your pockets");
                        Console.WriteLine("You find a note");
                        Console.WriteLine("The note reads 'Hey Ted, it's me Martha. We packed our things to go to the bunker, we'll meet you there!'");
                        Console.WriteLine("On the back of the note it says 'Watch out for any zombies lurking around...'");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        first();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("You look around the room looking for an exit.");
                        Console.WriteLine("You spot a door that leads outside.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        second();
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("You call out for occupants that might be in the house.");
                        Console.WriteLine("You hear a groaning sound.");
                        Console.WriteLine("Realizing that yelling at the top of my lungs was not a good idea, I look for a place to hide.");
                        Console.ReadLine();
                        Console.WriteLine("I open a door to find a zombie in the closet.");
                        Console.ReadLine();
                        Console.WriteLine("I get chomped down by it....");
                        Console.ReadLine();
                        gameOver();
                        break;

                    }
            }
        }
        public static void second()
        {
            string choice;
            Console.WriteLine("You exit the building.");
            Console.WriteLine("You see a burning neighborhood and crashed vehicles around.");
            Console.WriteLine("You see a sign that shows the directions of the bunker");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Find a weapon to get there safely");
            Console.WriteLine("1.Search cars");
            Console.WriteLine("2.Search garage");
            Console.WriteLine("3.Go back inside house and look for weapon");
            Console.WriteLine("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                {
                        Console.WriteLine("You search inside the vehicles");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("You find a small handgun with 30 rounds of ammunition!");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        third();
                        break;
                }
                case "2":
                {
                        Console.WriteLine("You searched the garage");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("You find a golf club!");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        third();
                        break;
                }
                case "3":
                {
                        Console.WriteLine("You go back inside the house..");
                        Console.WriteLine("Zombies escaped the rooms that kept them inside!");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("There are too many and they grab you!");
                        Console.ReadLine();
                        Console.Clear();
                        gameOver();
                        break;
                }
            }

        }
        public static void third()
        {
            string choice;
            Console.WriteLine("You run towards the bunker!");
            Console.WriteLine("You notice there are a few zombies on the way!");
            Console.WriteLine("What do you do?");
            Console.WriteLine("Press 'Enter' to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("A.Slay the zombies on the way!");
            Console.WriteLine("B.Avoid the zombies!");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "slay":
                case "a":
                {
                        Console.WriteLine("You slay the zombies on the way making sure that you have a clear path to the bunker");
                        Console.WriteLine("You make it to the bunker but it seems to be locked...");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Find a way in!");
                        Console.ReadLine();
                        Console.Clear();
                        fourth();
                        break;

                }
                case "b":
                {
                        Console.WriteLine("You run towards the bunker, avoiding zombies as you head over.");
                        Console.WriteLine("You accidently trip and drop your weapon...");
                        Console.WriteLine("Zombies start to surround you.");
                        Console.ReadLine();
                        Console.Clear();
                        gameOver();
                        break;
                }
            }
                
        }
        public static void fourth()
        {
            string choice;
            Console.WriteLine("You see a security booth to the right.");
            Console.WriteLine("To the left there's a storage room.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Where do you go?");
            Console.WriteLine("Press 'Enter' to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("A.Go to the security booth.");
            Console.WriteLine("B.Go to the storage room.");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "A":
                case "a":
                    {
                        Console.WriteLine("You walk up to the security booth");
                        Console.WriteLine("The door seems to be unlocked");
                        Console.WriteLine("You wander inside to look for the key to the bunker.");
                        Console.WriteLine("You stick your arm under the desk and something grabs you!");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("You feel the bite from a zombie...");
                        Console.ReadLine();
                        Console.Clear();
                        gameOver();
                        break;
                    }
                case "B":
                case "b":
                    {
                        Console.WriteLine("You walk to the storage room.");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("You find a security guard laying on the ground...");
                        Console.WriteLine("Seems to have died from a self inflicted wound..");
                        Console.WriteLine("You search his corpse.");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("You find a bunker key!!");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("You run back to the bunker");
                        Console.ReadLine();
                        Console.Clear();
                        youWin();
                        break;
                    }
            }
        }
        public static void gameOver()
        {
            Console.WriteLine("You were eaten by zombies...");
            Console.WriteLine("Better luck next time.");
            Console.WriteLine("Press 'Enter' to start over.");
            Console.ReadLine();
            Console.Clear();
            location();

           
        }
        public static void youWin()
        {
            Console.WriteLine("You unlock the door to the bunker.");
            Console.WriteLine("The first face you see is of your dear friend Martha!");
            Console.WriteLine("Martha gives you a hug and says 'Im so glad you made it Ted... I thought you were going to be a goner..");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Congratulations, You Win!!!");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
