using System;

class Program
{
    static void Main(string[] args)
    { 

        Console.WriteLine("Choose a pet type \n 1.Cat \n 2.Rabbit \n 3.Dog ");

        

        int petChoice;

        do
        {
            Console.Write("User Input: ");
            petChoice = Convert.ToInt32(Console.ReadLine());

            if (petChoice < 1 || petChoice > 3)
            {
                Console.WriteLine("Invalid Input, Choose a valid input");
            }
        }
        while (petChoice < 1 || petChoice > 3);
          
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
       
        Console.WriteLine($"You have chose a {petType}, Enter a name for your pet: ");
        string petName = Console.ReadLine();

        Console.WriteLine($"Welcome {petName}!, lets take good care of him");

    }
}
