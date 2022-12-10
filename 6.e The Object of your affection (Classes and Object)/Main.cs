

/**
 * 
 * The Object of Your Affection
Your friend is building a new match-making service: The Object of Your Affection or OOYA for short (don’t worry, you still have time to convince them to change the name).


With your new understanding of C# objects and classes, your friend thought you could build a pretty well-organized system of dating profiles.

Your first step? Build a Profile class that allows users to generate profile objects.

The Profile should store the following information:

User’s name
User’s age
User’s city
User’s country
User’s pronouns
User’s hobbies
And this is how users should be able to interact with their own profiles:

Create a new profile with some information
Add hobbies
View profile
Let’s get started!
 * 
 * 
 * 
 * 
 * 
 */



using System;

namespace DatingProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class profile and create a new object called sam
            Profile sam = new Profile("Sam Drakkila", 16, "New York", "USA", "treee");

            Console.WriteLine(sam.ViewProfile());
            // Add hobbies to sam's profile
            sam.SetHobbies(new string[] { "listening to audiobooks and podcasts", "playing rec sports like bowling and kickball", "writing a speculative fiction novel", "reading advice columns" });

            Console.WriteLine(sam.ViewProfile());

        }
    }
}
