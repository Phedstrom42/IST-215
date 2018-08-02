using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab100_PetLab
{
    public class Dog : Pet
    {
        public string DogsBreed { get; set; }

        public Dog(PET_TYPE t, PET_COLOR c, string n) : this(t, c, n, "Mutt") { }
        public Dog(PET_TYPE t, PET_COLOR c, string n, string dogsBreed) : base(t, c, n) { DogsBreed = dogsBreed; }
        public override string WhenHappy() => "I bark and wag my tail";
        public override string Sound() => "Woof Woof";
        public override string ToString() => $"{base.ToString()} I say {Sound()}, and when I am happy {WhenHappy()}.";
    }
}
