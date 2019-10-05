using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersize2
{
    class Person
    {
        protected string name;
        protected DateTime birthDate;
        protected Gender gender;

        public Person(string name, DateTime birthDate, Gender gender)
        {
            this.name = name;
            this.birthDate = birthDate;
            this.gender = gender;
        }

        public override string ToString()
        {
            return "Name: " + name + " Birth date: " + birthDate + " Gender: "+gender;
        }
    }
}
