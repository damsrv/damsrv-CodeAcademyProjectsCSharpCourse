using System;

namespace ProgrammingLanguages
{
    public class Language
    {
        /**
         * Get the language in the tsv file and create an object Langage with it
         */
        public static Language FromTsv(string tsvLine)
        {
            string[] values = tsvLine.Split('\t');
            Language lang = new Language(
              Convert.ToInt32(values[0]),
              Convert.ToString(values[1]),
              Convert.ToString(values[2]),
              Convert.ToString(values[3]));
            return lang;
        }

        public int Year
        { get; set; }

        public string Name
        { get; set; }

        public string ChiefDeveloper
        { get; set; }

        public string Predecessors
        { get; set; }

        /* 
         * CONSTRUCTOR
         */
        public Language(int year, string name, string chiefDeveloper, string predecessors)
        {
            Year = year;
            Name = name;
            ChiefDeveloper = chiefDeveloper;
            Predecessors = predecessors;
        }
        /*
         * Method that prettify the rendering of the object
         */
        public string Prettify()
        {
            return $"Year is : {Year},\nName is :  {Name},\nChief Developer is : {ChiefDeveloper},\nPredecessors are : {Predecessors}\n\n";
        }




    }
}