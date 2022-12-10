// Archmage.cs
using System;

namespace MagicalInheritance
{
    // Archmage Inherit Mage Class
    class Archmage : Mage
    {

        public Archmage(string title) : base(title)
        {

        }

        public override Storm CastRainStorm()
        {
            Storm storm = new Storm("rain storm", true, Title);
            return storm;
        }

        public Storm CastLightningStorm()
        {
            Storm storm = new Storm("lightning storm", true, Title);
            return storm;
        }
    }

}
