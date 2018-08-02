using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab100_PetLab
{
    public abstract class Pet
    {
        private PET_TYPE petType;
        protected PET_TYPE PetType
        {
            get { return PetType; }
            set { petType = value; }
        }
        public PET_COLOR PetColor { get; set; }
        public string PetName { get; set; }

        public abstract string WhenHappy();
        public abstract string Sound();

        public Pet(PET_TYPE pType, PET_COLOR PColor, string n)
        {
            PetColor = PColor;
            petType = pType;
            PetName = String.IsNullOrEmpty(n) ? "'I got no name'" : n;
        }
        public virtual string MyWish() => "Live free or die in the woods of NH.";
        public override string ToString()
        {
            return string.Format($"{this.petType}. Name: {PetName}, Color: {PetColor.ToString()} Wish: {MyWish()}");
        }

    }
}
