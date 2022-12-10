/**
 * 
 * 
 * Caesar Cipher
By 6 a.m. on Sunday, your team’s project is nearly finished. The Object of Your Affection (the name’s a work in progress) is getting attention from other teams in the hackathon. With one day left, they’re getting desperate. To steal your project idea, your competitors have been reading your team’s emails!

As the team’s C# expert, you have been asked to write a cipher: a tool to encrypt text, making it unreadable to other teams. You’ve decided to implement the Caesar Cipher, which was used by the Roman Empire to encode military secrets.

To use the cipher, draw the alphabet in a circle like so:

Alphabet with letters arranged in a circle
Take every letter of your message and shift it three places to the right. For example, A becomes D, B becomes E, C becomes F, and “attack” becomes “dwwdfn”.

Shift 3 places to turn A to D
Your teammates can decrypt your message by reversing the process: shift each letter three places to the left.
 * 
 * 
 * 
 * 
 * */



using System;

namespace CaesarCipher
{
    class Program
    {
        /*
        ** Launch the program
        */
        static void Main(string[] args)
        {
            // VARIABLES :
            
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 
                                            'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' }; // Array of char containing the letter of the alphabet
            char[] charMessage; // This variable will contain the encrypted message as char

            // ACTIONS 
            
            Console.WriteLine("message please ?"); // Ask the user to enter the message he wants to encrypt
            string secretMessage = Console.ReadLine();
             
            charMessage = convertToChar(secretMessage);

            
            Console.WriteLine("Your message encrypté est " + encryptMessage(charMessage, alphabet)); // Call encryption method and write the message


        }

        /*
        ** Fonction that transforms a string Char[]
        */
        static char[] convertToChar(string secretMessage)
        {
            return secretMessage.ToCharArray();
        }


        /* 
        ** Function encrypMessage
        ** Encrypt a char [] by modifing the char using a displacement value names encryptValue;
        ** Parameters : 
        ** secretMessage = array of char containing the message to encrypt
        ** alphabet = array of char containing the alphabet letters
        */
        static string encryptMessage(char[] secretMessage, char[] alphabet)
        {
            char[] encryptedMessage = new char[secretMessage.Length]; // New array of char which is going to contain the encrypted message. Initialise with the same size than char[] secretMessage
            
            int encryptValue = 3; // displacement value
            
            int index = 0; // value of the index in the alphabet array
            
            int encryptedIndex = 0; // Value of index + encryptValue
            
            char encryptedChar; // Value of the encrypted char
            
            string finalMessage = ""; // returned string

            
            for (int i = 0; i < secretMessage.Length; i++) // Loop on the char[] containing the message to encrypt 
            {

                
                index = Array.IndexOf(alphabet, secretMessage[i]); // Get the letter that have the corresponding index in the alphabet[]
                
                encryptedIndex = index + encryptValue; // Create the encrypted index by adding the encryptValue

                // Recuperation of the encrypted letter corresponding to the new index encryptedIndex
                if (encryptedIndex > 25) // Condition to deal with the last alphabet letters to avoid that index exceed 25
                {
                    
                    encryptedIndex -= 25; // If index is > 25 we get back to index 

                    encryptedChar = alphabet[encryptedIndex]; // get the encrypted char in alphabet[]
                }
                else // no need to do anything 
                {

                    encryptedChar = alphabet[encryptedIndex]; // get the encrypted char in alphabet[]

                }

                
                encryptedMessage[i] = encryptedChar; // Add the encrypted char in encryptedMessage[] at the index i

            }

            finalMessage = String.Join("", encryptedMessage); // Join the char of encryptedMessage[] and turn it into a string.

            return finalMessage;
        }

    }
}