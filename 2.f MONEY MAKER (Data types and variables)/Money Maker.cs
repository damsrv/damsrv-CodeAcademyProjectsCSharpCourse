using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
        // Value of coins in cents
        int bronze = 1;
        int silver = 5;
        int gold = 10;

      
        Console.WriteLine("Welcome to Money Maker!"); // Start of the programs

        Console.WriteLine("How much do you need to convert ? ");
      
        string Response = Console.ReadLine(); // Value of the amount entered by the user to convert in coins 
      
        double amount = Convert.ToDouble(Response); // Conversion String en Double


        // How many gold coin needed?

            double numberOfGoldCoins = Math.Floor(amount / gold); // Divide the amount by the number of gold coins and round down to the nearest integer
        
            Console.WriteLine("numberOfGoldCoins = " + numberOfGoldCoins);
        
            double reste = amount % gold; // Variable reste = remaining of the operations above

            Console.WriteLine("reste = " + reste);

        // How many silver coin needed?
        
            double numberOfSilverCoins = Math.Floor(reste / silver); // Divide reste by the number of silver coins and round down to the nearest integer
        
            Console.WriteLine("numberOfSilverCoins = " + numberOfSilverCoins);
        
            reste -= (numberOfSilverCoins * silver); // We delete the number of silver coin needed of reste
        
            Console.WriteLine("reste = " + reste);

        // How many bronze coin needed ?

            
            double numberOfBronzeCoins = Math.Floor(reste / bronze); // Divide reste by the number of bronze coins and round down to the nearest integer
            
            Console.WriteLine("numberOfBronzeCoins = " + numberOfBronzeCoins);

            reste -= (numberOfBronzeCoins * bronze); // We delete the number of bronze coin needed of reste
            
            Console.WriteLine("reste = " + reste); // reste must be equal 0 there

        }
  }
}
