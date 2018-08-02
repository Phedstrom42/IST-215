using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab100_PersonLINQ
{
    class Person : IComparable<Person>, IEquatable<Person>
    {
        public String LastName { get; set; }
        public String FirstName { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public int Zip { get; set; }

        public Person (String first, String last, String addr, String city, String state, int zip)
        {
            FirstName = first;
            LastName = last;
            Address = addr;
            City = city;
            State = state;
            Zip = zip;
        }

        public Person() : this (String.Empty, String.Empty, String.Empty, String.Empty, String.Empty, 0)
        {
        }

        public bool Equals (Person other)
        {
            if (other == null)
                return false;

            if (this == other)
                return false;

            if (other == null || this.GetType() != other.GetType())
                return false;

            if (this.FirstName == null && other.FirstName != null)
            {
                return false;
            }
            else if (!FirstName.Equals(other.FirstName))
            {
                return false;
            }

            if (this.LastName == null && other.LastName != null)
            {
                return false;
            }
            else if (!LastName.Equals(other.LastName))
            {
                return false;
            }

            return true;
        }

        public int CompareTo (Person other)
        {
            if (this.LastName.Equals(other.LastName))
            {
                return this.FirstName.CompareTo(other.LastName);
            }

            return this.LastName.CompareTo(other.LastName);
        }

        public override string ToString() => String.Format("{0,12} {1, -12} {2,-30} {3,-24} {4,-6} {5:d5}",
                                                            FirstName, LastName, Address, City, State, Zip);

    }
}
