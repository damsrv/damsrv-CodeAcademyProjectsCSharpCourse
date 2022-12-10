using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgrammingLanguages
{
    class Program
    {
        static void Main()
        {

            List<Language> languages = File.ReadAllLines("./languages.tsv") // Create a list of Langage objects
              .Skip(1)
              .Select(line => Language.FromTsv(line))
              .ToList();

            /* // ETAPE 1 : Console all the langages
             
                foreach (Language item in languages) 
                {
                //Console.WriteLine(item.Prettify());
                }
            */

            /* // ETAPE 2 : Console only certain fields of list language
             
                var basicInfos = languages.
                      Select( langage => $"{langage.Year} {langage.Name} {langage.ChiefDeveloper}"); 

                foreach ( var item in basicInfos)
                {
                  Console.WriteLine(item); 
                }
            */

            /* // ETAPE 3 : Console only langage where the name == c#
             
                var cSharp = languages
                      .Where(langage => langage.Name == "C#")
                      .Select( langage => langage.Prettify()); // ETAPE 2 : Console only object

                foreach ( var item in cSharp)
                {
                  Console.WriteLine(item); 
                }
            */


            /*
                // ETAPE 4 : Console only langage where the ChiefDeveloper == Microsoft
                var microsoft = languages
                      .Where(langage => langage.ChiefDeveloper  == "Microsoft")
                      .Select( langage => langage.Prettify());

                foreach ( var item in microsoft)
                {
                  Console.WriteLine(item); 
                }
            */

            /*
                // ETAPE 5 : Console only langage where the Predecessors contains Lisp
                var ancesters = languages
                      .Where(langage => langage.Predecessors.Contains("Lisp"))
                      .Select( langage => langage.Prettify());

                foreach ( var item in ancesters)
                {
                  Console.WriteLine(item); 
                }
            */

            /*
                // ETAPE 6 : Console only langage where the Name contains Script
                var script = languages
                      .Where(langage => langage.Name.Contains("Script"))
                      .Select( langage => langage.Prettify());

                foreach ( var item in script)
                {
                  Console.WriteLine(item); 
                }
            */

            /*
                // ETAPE 7 
                //Console.WriteLine(languages.Count());
            */

            /*
                // ETAPE 8 : Console only langage built between 1995 and 2005
                var age = languages
                      .Where(langage => langage.Year >= 1995 && langage.Year <= 2005)
                      .Select( langage => langage.Prettify());

                foreach ( var item in age)
                {
                  Console.WriteLine(item); 
                }
            */
            /*
                // ETAPE 9 : Console only langage built between 1995 and 2005 
                var age2 = languages
                  .Where(langage => langage.Year >= 1995 && langage.Year <= 2005)
                  .Select(langage => $"{langage.Name} was invented in {langage.Year}");
                
                foreach ( var item in age2)
                {
                Console.WriteLine(item); 
                }
           */

            /*
                // ETAPE 10 : Use the method PrettyPrintAll that avoid to do a foreach 
                var age3 = languages
                  .Where(langage => langage.Year >= 1995 && langage.Year <= 2005)
                  .Select( langage => langage);

                PrettyPrintAll(age3);
            */

            // ETAPE 11
            PrintAll(age2);



        }
        // ETAPE 10
        /*
         * Method to Console all the var above containing InEnumerable<Language>
         */
        public static void PrettyPrintAll(IEnumerable<Language> langages)
        {
            foreach (var item in langages)
            {
                Console.WriteLine(item.Prettify());
            }
        }

        // ETAPE 11
        /*
        * Method to Console all the var above containing IEnumerable<Object>
        */
        public static void PrintAll(IEnumerable<Object> objects)
        {
            foreach (var obj in objects)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
