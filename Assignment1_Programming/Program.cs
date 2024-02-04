﻿using System;

class Program
{
    static void Main(string[] args)
    { 
        //pet type selection

        Console.WriteLine("Choose a pet type \n 1.Cat \n 2.Rabbit \n 3.Dog ");

        

        int petChoice;

        do
        {
            //requesting user to select a type of pet and check the input
            Console.Write("User Input: ");
            petChoice = Convert.ToInt32(Console.ReadLine());

            if (petChoice < 1 || petChoice > 3)
            {
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
        Console.WriteLine($"You have chose a {petType}, Enter a name for your pet: ");
        string petName = Console.ReadLine();

        Console.WriteLine($"Welcome {petName}!, lets take good care of him");

        // setting up default pet status
        int hunger = 3;
        int happiness = 5;
        int health = 7;

        // while loop for pet care actions and viewing status
        bool exitReq = true;//setting true to enter the loop

        while (exitReq)
        {
            //display main menu options
            Console.WriteLine("\nMain menu:");
            Console.WriteLine($"1. Feed {petName}");
            Console.WriteLine($"2. Play with {petName}");
            Console.WriteLine($"3. Let {petName} rest");
            Console.WriteLine($"4. Check {petName} Status");
            Console.WriteLine("5.Exit");

            Console.WriteLine("User input: ");
            int menuChoice = Convert.ToInt32(Console.ReadLine());

            switch (menuChoice)
            {
                case 1:
                    Console.WriteLine($"You fed {petName}, his hunger decreases and health increased ");
                    hunger = Math.Max(1, hunger - 1);
                    health = Math.Min(10, health + 1) ;
                    break;
                case 2:
                    Console.WriteLine($"You played with {petName}, his hunger increased and happiness increased too ");
                    hunger = Math.Min(10, hunger + 1);
                    happiness = Math.Min(10, happiness + 1);
                    break;
                case 3:
                    Console.WriteLine($"You let {petName} rest, health increased but happiness decreased slightly");
                    health = Math.Min(10, health + 1);
                    happiness = Math.Max(1,happiness - 1);
                    break;
                case 4:
                    Console.WriteLine($"{petName}'s status");
                    Console.WriteLine($"- Hunger: {hunger}");
                    Console.WriteLine($"- Happiness: {happiness}");
                    Console.WriteLine($"- Health: {health}");
                     break;
                case 5:
                    exitReq = false;// set exitReq to false to exit loop
                    Console.WriteLine("bye");
                    break; 
                default:
                    Console.WriteLine("Invalid input. Please valid input");
                    break;
               

            }

        }




    }
}
