using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfizm_znowu
{
    abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string TelNum { get; set; }

        public Person() { Name = "";Surname = "";Address = "";TelNum = ""; }
        public Person(string _Name, string _Surname, string _Address, string _TelNum) { Name = _Name;Surname = _Surname;Address = _Address;TelNum = _TelNum; }
    }

    class Customer: Person
    {
        public int CustomerID { get; set; }
        public bool IsOnDistributionList { get; set; }

        public Customer() : base() { CustomerID = 0;IsOnDistributionList = false; }
        public Customer(string _Name, string _Surname, string _Address, string _TelNum, int _CustomerID, bool _IsOnDistributionList): base(_Name, _Surname, _Address, _TelNum) { CustomerID = _CustomerID;
            IsOnDistributionList = IsOnDistributionList; }
    }

    //Tutaj powinna być kolejna klasa, ale już nie chciało mi się jej implementować, nudne te zadania, moze kiedyś dokończe, zobaczymy
}
