
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

    class Profile
    {
        ////////////////////////////////////////////////////////////////
        //VARIABLES/////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////
        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;

        ////////////////////////////////////////////////////////////////
        //PROPERTIES////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////
        public int Age
        {
            get { return age; }
            set // Setter Verify if the age enter if greater than 18/
            {
                if (Age >= 18) age = value;
                else
                {
                    Console.Write("Votre age n'est pas valide ! ");
                    age = 0;
                }
            }
        }

        ////////////////////////////////////////////////////////////////
        //CONSTRUCTORS//////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////
        public Profile(
        string name,
        int age,
        string city = "n/a",
        string country = "n/a",
        string pronouns = "he/him")
        {
            this.name = name;
            this.Age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
            this.hobbies = new string[0];

        }

        ////////////////////////////////////////////////////////////////
        //METHODS///////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////
        
        /**
        ** Method ViewProfile
        ** No parameters
        ** return a string presenting the profile of the person.
        */
        public string ViewProfile()
        {
            string bio = $"Name :\n- {name}\nAge : \n- {age}\nCity :\n- {city}\nCountry :\n- {country}\nPronouns :\n- {pronouns}";

            // Condition that check if hobbies have been declared by the user
            if (hobbies.Length > 0)
            {
                // add the string at the end of bio if there are hobbies in hobbies array 
                bio += "\nHobbies :\n";
                // for each hobby we add the hobby to the string
                foreach (string hobby in hobbies)
                {
                    bio += $"- {hobby}\n";
                }
            }
            return bio;
        }

        /**
        ** Method SetHobbies
        ** Take a parameter = array of string
        ** Allow the user to set his hobbies into array of string hobbies.
        */
        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }
    }
}
