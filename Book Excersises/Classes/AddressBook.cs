using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Klasy
{
    //MAIN PROGRAM

    public partial class AddressBook : Form
    {

        public static List<PersonEntry> People = new List<PersonEntry>();

        private void ClearAddPerson()
        {
            Name.Text = "";
            Surname.Text = "";
            Email.Text = "";
            TelNumber.Text = "";
        }

        private PersonEntry AddPerson()
        {
            PersonEntry newPerson = new PersonEntry();
            newPerson.Name = Name.Text;
            newPerson.Surname = Surname.Text;
            newPerson.Email = Email.Text;

            int number = 0;
            if(int.TryParse(TelNumber.Text, out number)&&TelNumber.Text.Length==9)
            {
            newPerson.TelNumber = TelNumber.Text;
                ClearAddPerson();
                return newPerson;
            }
            else
            {
                MessageBox.Show("Wrong format of Telephone Number !");
                TelNumber.Text = "";
                return null;
            }


        }

        private void SortList()
        {
            //Sorting by names
            People.Sort(delegate(PersonEntry p1, PersonEntry p2)
            {
                return p1.Name.CompareTo(p2.Name);
            });
        }
        //
        //</classes and methods>
        //


        /*
         * 
         * Controls
         * 
         */ 
        public AddressBook()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if(SaveDial.ShowDialog()==DialogResult.OK)
            {
                StreamWriter writer = File.CreateText(SaveDial.FileName);

                foreach (PersonEntry pe in People)
                    writer.WriteLine(pe.ToString());
                writer.Close();
            }
        }

        private void Load_Click(object sender, EventArgs e)
        {
            if(LoadDial.ShowDialog()==DialogResult.OK)
            {
                StreamReader reader = File.OpenText(LoadDial.FileName);
                while(!reader.EndOfStream)
                {
                    string[] data = reader.ReadLine().Split(" ");

                    //save new peron in memory
                    PersonEntry newPerson = new PersonEntry();
                    newPerson.Name = data[0];
                    newPerson.Surname = data[1];
                    newPerson.Email = data[2];
                    newPerson.TelNumber = data[3];

                    People.Add(newPerson);

                    //add name and surename to the lsit
                    PeopleList.Items.Add(data[0] + " " + data[1]);
                }
                reader.Close();
                SortList();
            }
        }

        private void PeopleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonDataWindow window = new PersonDataWindow(People[PeopleList.SelectedIndex]);
            window.ShowDialog();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            PersonEntry newPerson = AddPerson();
            if(newPerson!=null)
            {
                People.Add(newPerson);
                PeopleList.Items.Add(newPerson.Name + " " + newPerson.Surname);
            }
        }

        private void ClearAdd_Click(object sender, EventArgs e)
        {
            ClearAddPerson();
        }

        private void ClearList_Click(object sender, EventArgs e)
        {
            PeopleList.Items.Clear();
        }
    }
}


