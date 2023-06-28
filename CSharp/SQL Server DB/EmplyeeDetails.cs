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
    public partial class EmplyeeDetails : Form
    {
        public EmplyeeDetails()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeeDataSet);

        }

        private void EmplyeeDetails_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'employeeDataSet.Employee' . Możesz go przenieść lub usunąć.
            this.employeeTableAdapter.Fill(this.employeeDataSet.Employee);

        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            //save items if user forgot to do so
            employeeBindingNavigatorSaveItem_Click(null, null);

            this.Close();
        }
    }
}
