// Storm.cs
using System;

namespace MagicalInheritance
{

    // Class creating the announce of spell in function of the type of characters
    class Storm
    {
        public string Essence { get; private set; }
        public bool IsStrong { get; private set; }
        public string Caster { get; private set; }


        public Storm(string essence, bool isStrong, string caster)
        {
            this.Essence = essence;
            this.IsStrong = isStrong;
            this.Caster = caster;
        }

        public string Announce()
        {
            string isStrongStr;
            if (IsStrong == true) isStrongStr = "strong";
            else isStrongStr = "weak";

            return $" {Caster} cast a {isStrongStr} {Essence}!";
        }

    }
}
