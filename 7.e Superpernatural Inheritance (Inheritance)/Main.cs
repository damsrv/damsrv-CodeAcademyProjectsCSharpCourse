using System;

namespace MagicalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test method of Storm
            Storm storm = new Storm("bla", true, "oke");
            Console.WriteLine(storm.Announce());

            // Test class Pupil
            Pupil pupil = new Pupil("Mezil-kree");
            Storm ret1 = pupil.CastWindStorm();
            Console.WriteLine(ret.Announce());

            // Test class Mage
            Mage mage = new Mage("Gul’dan");
            Storm ret2 = mage.CastWindStorm();
            Console.WriteLine(ret2.Announce());
            Storm ret3 = mage.CastRainStorm();
            Console.WriteLine(ret3.Announce());

            // Test class Archmage
            Archmage archmage = new Archmage("Nielas Aran");
            Storm ret4 = archmage.CastWindStorm();
            Console.WriteLine(ret4.Announce());
            Storm ret5 = archmage.CastLightningStorm();
            Console.WriteLine(ret5.Announce());
           
        }
    }
}