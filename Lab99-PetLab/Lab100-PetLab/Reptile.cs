using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab100_PetLab
{
    public class Reptile : Pet
    {
        public Reptile(PET_TYPE t, PET_COLOR c, string n) : base(t, c, n) { }
        public override string WhenHappy() => "raise my head";
        public override string Sound() => "hiss";
        public override string ToString() => $"{base.ToString()} I say {Sound()}, and when I am happy {WhenHappy()}";

    }
}
