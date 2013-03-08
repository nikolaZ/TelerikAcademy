using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    abstract class  Human:IComparable
    {
        public string firstName;
        private string surname;

        public Human(string firstName, string surname)
        {
            if (string.IsNullOrWhiteSpace(firstName) ||
                (string.IsNullOrWhiteSpace(surname)))
            {
                throw new ArgumentNullException();
            }

            this.firstName = firstName;
            this.surname = surname;
        }

        public string Surname
        {
            get
            {
                return this.surname;
            }
            private set
            {
                this.surname = value;
            }
        }


        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                this.firstName = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", this.firstName, this.surname);
        }

        public int CompareTo(Object human)
        {
            Human otherHuman = human as Human;
            if (this.FirstName.CompareTo(otherHuman.FirstName) == 0)
            {
                return this.Surname.CompareTo(otherHuman.Surname);
            }
            else
            {
                return this.FirstName.CompareTo(otherHuman.FirstName);
            }
        }
    }

    

