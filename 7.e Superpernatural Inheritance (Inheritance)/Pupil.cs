// Pupil.cs
using System;

namespace MagicalInheritance
{
    class Pupil
    {
        public string Title { get; private set; }

        public Pupil(string pupil)
        {
            this.Title = pupil;
        }

        public Storm CastWindStorm()
        {
            Storm storm = new Storm("wind storm", false, Title);
            return storm;
        }
    }
}
