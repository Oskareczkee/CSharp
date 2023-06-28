using System;
using System.Collections.Generic;
using System.Text;

namespace Klasy
{
    public class PersonEntry
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string TelNumber { get; set; }

        public override string ToString()
        {
            string data = Name + " " + Surname + " " + Email + " " + TelNumber;
            return data;
        }


        static public PersonEntry ConvertFromString(string[] data)
        {
            if (data.Length != 4)
                return null;
            PersonEntry newPerson = new PersonEntry();

            newPerson.Name = data[0];
            newPerson.Surname = data[1];
            newPerson.Email = data[2];
            newPerson.TelNumber = data[3];

            return newPerson;
        }

        public PersonEntry(string name, string surname, string email, string telnumber)
        {
            Name = name;
            Surname = surname;
            Email = email;
            TelNumber = telnumber;
        }
        public PersonEntry() { }
    }
}
