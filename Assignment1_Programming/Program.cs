using System;

class Program
{
    static void Main(string[] args)
    { 
        //pet type selection

        Console.WriteLine("Choose a pet type: \n 1.Cat \n 2.Rabbit \n 3.Dog ");
        Console.WriteLine();


        int petChoice;

        do
        {
            //requesting user to select a type of pet and check the input
            Console.Write("User Input: ");
            petChoice = Convert.ToInt32(Console.ReadLine());

            if (petChoice < 1 || petChoice > 3)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid Input, Choose a valid input");
            }
        }
        while (petChoice < 1 || petChoice > 3);

          //Determine the pet type using switch case 
        string petType = "";

        switch (petChoice)
        {
            case 1:
                petType = "Cat";
                break;
            case 2:
                petType = "Rabbit";
                break;
            case 3:
                petType = "Dog";
                break;
                
        }
        //asking pet name from user
        Console.WriteLine();
        Console.Write($"You have chose a {petType}, Enter a name for your pet: ");
        string petName = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"Welcome {petName}!, lets take good care of him");

        // setting up default pet status
        int hunger = 4;
        int happiness = 5;
        int health = 6;

        // while loop for pet care actions and viewing status
        bool exitReq = true;//setting true to enter the loop

        while (exitReq)
        {
            //display main menu options
            Console.WriteLine("\nMain menu:");
            Console.WriteLine("-----------");
            Console.WriteLine($"1. Feed {petName}");
            Console.WriteLine($"2. Play with {petName}");
            Console.WriteLine($"3. Let {petName} rest");
            Console.WriteLine($"4. Check {petName} Status");
            Console.WriteLine("5.Exit");
            Console.WriteLine();

            Console.Write("User input: ");
            int menuChoice = Convert.ToInt32(Console.ReadLine());

            switch (menuChoice)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine($"You fed {petName}, his hunger decreases and health increased slightly ");
                    hunger = Math.Max(1, hunger - 1);
                    health = Math.Min(10, health + 1) ;
                    break;

                case 2:
                    Console.WriteLine();
                    if (hunger >= 10)
                    {
                        Console.WriteLine($"{petName} is too hungry so he can't play now, please feed him");
                    }
                    else
                    {
                        Console.WriteLine($"You played with {petName}, his hunger slightly increased and happiness increased a lot too ");
                        hunger = Math.Min(10, hunger + 1);
                        happiness = Math.Min(10, happiness + 1);
                    }
                    break;

                case 3:
                    Console.WriteLine();
                    if (happiness <= 1)
                    {
                        Console.WriteLine($"{petName} is too unhappy to rest now , so play with him first");
                    }
                    else
                    {
                        Console.WriteLine($"You let {petName} rest, health increased but happiness decreased slightly");
                        health = Math.Min(10, health + 1);
                        happiness = Math.Max(1, happiness - 1);
                    }
                    break;

                case 4:
                    Console.WriteLine();
                    Console.WriteLine($"{petName}'s status");
                    Console.WriteLine("-------------------");
                    Console.WriteLine($"- Hunger: {hunger}");
                    Console.WriteLine($"- Happiness: {happiness}");
                    Console.WriteLine($"- Health: {health}");

                    //status check with warning for critical stages
                    Console.WriteLine(hunger <= 2 ? $"Warning :{petName}'s is not that hungry now!" : hunger >= 9 ? $"Warning: {petName}'s Hunger is critically high now!" : "");
                    Console.WriteLine(happiness <= 2 ? $"Warning: {petName}'s Happiness is critically low now!" : happiness >= 9 ? $"Warning: {petName}'s Happiness is too good now!" : "");
                    Console.WriteLine(health <= 2 ? $"Warning: {petName}'s Health is critically low now!" : health >= 9 ? $"Warning:{petName}'s Health is too good now!" : "");
                    break;

                case 5:
                    exitReq = false;// set exitReq to false to exit loop
                    Console.WriteLine($"bye, Thanks for being with {petName} :)");
                    break; 

                default:
                    Console.WriteLine();
                    Console.WriteLine("Invalid input. Please valid input");
                    break;
               

            }
            // negleted caase
            if(hunger >= 9 || happiness <= 2)
            {
                Console.WriteLine();
                Console.WriteLine($"{petName} seems negleted, it's healthis getting deteriorated, so he is getting unhappy too");
                health= Math.Max(1,health - 1);
                happiness= Math.Max(1,happiness - 1);
            }

        }




    }
}
