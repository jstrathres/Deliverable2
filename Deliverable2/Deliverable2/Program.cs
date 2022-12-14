using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hi. Welcome to our Buffet. All you can eat for $9.99! We only charge extra for coffee. How many people are in your group? Please, parties of 6 or lower.");
        string userInput = Console.ReadLine();
        int totalParty = int.Parse(userInput);

        if (totalParty <= 6)
        {
            Console.WriteLine("A table for " + totalParty + "! Please follow me and take a seat.");
            Console.WriteLine("Let's get everyone started with some drinks. We've got water or coffee.");
            int totalWater = 0;
            int totalCoffee = 0;

            for (int i = 1; i <= totalParty; i++)
            {
                Console.WriteLine("Alright, person " + i + ", water or coffee?");
                string drink = Console.ReadLine();
                if (drink == "water")
                {
                    totalWater++;
                    Console.WriteLine("Water, good choice!");
                }
                else if (drink == "coffee")
                {
                    totalCoffee++;
                    Console.WriteLine("Coffee, good choice!");
                }
                else
                {
                    Console.WriteLine("We don't have that. No drink for you!");
                }
            }

            Console.WriteLine("Okay, so that's " + totalWater + " waters and " + totalCoffee + " coffees. I'll be right back. Feel free to grab your food!");

            double totalBill = (totalParty * 9.99) + (totalCoffee * 2);
            Console.WriteLine("Here's your bill! Total price: $" + totalBill);
        }
        else
        {
            Console.WriteLine("Oh sorry, we can only seat parties of 6. Have a nice day.");
        }
    }
}


