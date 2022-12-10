// Mage.cs
using System;

namespace MagicalInheritance
{

    // Inherit from the pupil class
    class Mage : Pupil
    {
        public Mage(string title) : base(title)
        {

        }

        public virtual Storm CastRainStorm()
        {
            Storm storm = new Storm("rain storm", false, Title);
            return storm;
        }

    }
}
