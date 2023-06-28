using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klasy
{
    public partial class AccCalculator : Form
    {
        readonly int[] AccomodationCosts = {1500, 1600, 1800, 2500 };
        readonly int[] AlimentationCosts = { 600, 1200, 1700 };
        int AlimentationIndex=-1;

        public AccCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            if(AlimentationIndex==-1)
            {
                MessageBox.Show("Alimentation has not been chosen !");
                return;
            }
            if (AccomodationList.SelectedIndex == -1)
            {
                MessageBox.Show("Accomodation has not been chosen !");
                return;
            }

            int cost = AccomodationCosts[AccomodationList.SelectedIndex] + AlimentationCosts[AlimentationIndex];
            MessageBox.Show("Total Cost: " + cost);
        }

        private void Numero0_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            try
            {
            AlimentationIndex = int.Parse(rb.Tag.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
