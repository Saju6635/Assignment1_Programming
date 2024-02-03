using System;

class Program
{
    static void Main(string[] args)
    { 

        Console.WriteLine("Choose a pet type \n 1.Cat \n 2.Rabbit \n 3.Dog ");

        Console.Write("User Input: ");

        int petChoice = Convert.ToInt32(Console.ReadLine());

        string petType;

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
            default:
                petType = "Unknown pet type";
                break;
                
        }
       
        Console.WriteLine($"You have chose a {petType}, Enter a name for your pet: ");
        string petName = Console.ReadLine();

        Console.WriteLine($"Welcome {petName}!, lets take good car of you"); // commenting for git push/....

    }
}
