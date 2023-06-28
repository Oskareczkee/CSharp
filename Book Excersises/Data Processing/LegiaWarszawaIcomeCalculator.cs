using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przetwarzanie_danych
{
    public partial class LegiaWarszawaIncomeCalculator : Form
    {

        const int SITE_A_SEAT_PRICE = 15;
        const int SITE_B_SEAT_PRICE = 12;
        const int SITE_C_SEAT_PRICE = 9;

        public LegiaWarszawaIncomeCalculator()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void IncomeGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SiteBIncomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void CalculateIncomeButton_Click(object sender, EventArgs e)
        {
            try
            {

            int siteAIncome = int.Parse(StrefaAText.Text) * SITE_A_SEAT_PRICE;
            int siteBIncome = int.Parse(StrefaBText.Text) * SITE_B_SEAT_PRICE;
            int siteCIncome = int.Parse(StrefaCText.Text) * SITE_C_SEAT_PRICE;
            int TotalIncome = siteAIncome + siteBIncome + siteCIncome;

            SiteAIncomeLabel.Text = siteAIncome.ToString("c");
            SiteBIncomeLabel.Text = siteBIncome.ToString("c");
            SiteCIncomeLabel.Text = siteCIncome.ToString("c");
            TotalIncomeLabel.Text = TotalIncome.ToString("c");
            }
            catch
            {
                MessageBox.Show("Wprowadzono niepoprawny format !");

                Clear_Click(null, null);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            StrefaAText.Text = String.Empty;
            StrefaBText.Text = String.Empty;
            StrefaCText.Text = String.Empty;

            SiteAIncomeLabel.Text = String.Empty;
            SiteBIncomeLabel.Text = String.Empty;
            SiteCIncomeLabel.Text = String.Empty;
            TotalIncomeLabel.Text = String.Empty;
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
