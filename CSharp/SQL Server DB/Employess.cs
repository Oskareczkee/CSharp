using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Server_DB
{
    public partial class Employess : Form
    {
        public Employess()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeeDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'employeeDataSet.Employee' . Możesz go przenieść lub usunąć.
            this.employeeTableAdapter.Fill(this.employeeDataSet.Employee);
        }

        private void ShowDetailsButton_Click(object sender, EventArgs e)
        {
            EmplyeeDetails DetailsWindow = new EmplyeeDetails();

            DetailsWindow.ShowDialog();

            this.employeeTableAdapter.Fill(this.employeeDataSet.Employee);
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SortByHourlyRateAscending_CheckedChanged(object sender, EventArgs e)
        {
            this.employeeTableAdapter.FillByHourlyRateAsc(this.employeeDataSet.Employee);
        }

        private void SortByHourlyRateDescending_CheckedChanged(object sender, EventArgs e)
        {
            this.employeeTableAdapter.FillByHourlyRateDesc(this.employeeDataSet.Employee);
        }

        private void EmployeeName_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            this.employeeTableAdapter.FindByName(this.employeeDataSet.Employee, tb.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Max = (int)this.employeeTableAdapter.FindMaxHourlyRate();
            MessageBox.Show("The Highest pay per hour is: "+Max);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Min = (int)this.employeeTableAdapter.FindMinHourlyRate();
            MessageBox.Show("The Lowest pay per hour is: " + Min);
        }
    }
}
