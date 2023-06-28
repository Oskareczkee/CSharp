using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Klasy
{
    public partial class PersonDataWindow : Form
    {
        PersonEntry Person;

        public PersonDataWindow(PersonEntry person)
        {
            InitializeComponent();
            Person = person;
        }

        private void PersonDataWindow_Load(object sender, EventArgs e)
        {

            Name.Text = Person.Name;
            Surname.Text = Person.Surname;
            Email.Text = Person.Email;
            TelNumber.Text = Person.TelNumber;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
