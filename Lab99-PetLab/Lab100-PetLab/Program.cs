using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab100_PetLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog(PET_TYPE.Dog, (PET_COLOR.Black | PET_COLOR.White), "Bowser");
            Cat myCat = new Cat(PET_TYPE.Cat, PET_COLOR.White, "Kitty");
            Bird myBird = new Bird(PET_TYPE.Bird, PET_COLOR.Red, "Big Bird");
            Amphibian myFrog = new Amphibian(PET_TYPE.Amphibian, PET_COLOR.Green, "Froggy");

            /*
             * Pet is the base class. Dog, Cat etc. ate derived classes.
             * Derived class references can be assigned to the base class variables.
             * A Dog object can be assigned to Pet variable.
             * Base class reference cannot be assigned to derived class
             * variables.
             * For examples, you cannont do the following:
             * Dog myDog1 = new Pet(PET_TYPE.Dog, PET_COLOR.White, "Ranger");
             * 
             * Pet cannot be (only) dof
             * you will get a syntax error - Derived class variable, receiving base class reference.
             * Pet is also an abstract class and you cannot make objexts from abstrance class.
             */

            Pet dog2 = new Dog(PET_TYPE.Dog, (PET_COLOR.Black), "King");
            Console.WriteLine(dog2);

            Pet[] myPets = new Pet[8];
            myPets[0] = myDog;
            myPets[1] = myCat;
            myPets[2] = myBird;
            myPets[3] = myFrog;
            myPets[4] = new Reptile(PET_TYPE.Reptile, PET_COLOR.Brown, "");
            myPets[5] = new Dog(PET_TYPE.Dog, (PET_COLOR.Black | PET_COLOR.White), "Tipsy", "Boxer");
            myPets[6] = new Dog(PET_TYPE.Dog, PET_COLOR.Brown, "Gypsy", "Mutt");
            //myPets[7] = null;

            foreach (Pet myPet in myPets)
            {
                if (myPet != (Pet)null)
                    Console.WriteLine(myPet);
                else
                    Console.WriteLine("I am not yet a pet.");
            }
            Console.WriteLine(); Console.WriteLine();
            char[] delimiterChars = { '.' };
            foreach (Pet myPet in myPets)
            {
                //At run time, you can check to see what type of object it is
                if (myPet is Dog)
                {
                    //this is an example of downcasting. Base class object is converted to derived class object
                    Dog thisDog = (Dog)myPet;
                    if (thisDog.DogsBreed == "Mutt")
                        Console.WriteLine($"\nSorry, we don't allow ({thisDog.DogsBreed})");
                }
                else if (myPet != (object)null)
                {
                    string sTypeWithClassInfo = myPet.GetType().ToString(); // for example PetExample1.dog
                    string[] strArray = sTypeWithClassInfo.Split(delimiterChars);
                    Console.WriteLine("\nDisplay Type Information (namespace.classname)");
                    Console.WriteLine($"Namespace:{strArray[0]}, Classname:{strArray[1]}");
                    string sType = sTypeWithClassInfo.Split(delimiterChars)[1]; // split PetrExample1.Dog into two and use only Dog.
                    Console.WriteLine($"{sType}s are OK.");
                }

            }


        }
    }
}
