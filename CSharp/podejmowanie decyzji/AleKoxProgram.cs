using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podejmowanie_decyzji_i_jakieś_tam_chujostwo
{
    public partial class AleKoxProgram : Form
    {
        public class Workshops
        {
            public int Length;
            public int Cost;
            public Workshops(int length, int cost){ Length = length; Cost = cost; }
        }

        Workshops[] workshops = {new Workshops(3,1000), new Workshops(3, 800), new Workshops(3, 1500), new Workshops(5, 1300), new Workshops(1, 500) };
        int[] AccomodationCost = { 150, 225, 175, 300, 175, 150 };

        public AleKoxProgram()
        {
        InitializeComponent();
        }

        private void Cost_Click(object sender, EventArgs e)
        {

        }

        private void DaysLabel_Click(object sender, EventArgs e)
        {

        }

        private int CalculateTotalCost()
        {
            if (WorkshopsList.SelectedIndex != -1 && AccomodationList.SelectedIndex != -1)
                return (AccomodationCost[AccomodationList.SelectedIndex] * workshops[WorkshopsList.SelectedIndex].Length) + workshops[WorkshopsList.SelectedIndex].Cost;
            return 0;
        }

        private void WorkshopsList_SelectedIndexChanged(object sender, EventArgs e)
        {
             if(WorkshopsList.SelectedIndex!=-1)
             {
                DaysLabel.Text = workshops[WorkshopsList.SelectedIndex].Length.ToString();
                Cost.Text = workshops[WorkshopsList.SelectedIndex].Cost.ToString("c");
                TotalCost.Text = CalculateTotalCost().ToString("c");
             }

        }

        private void AccomodationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(AccomodationList.SelectedIndex!=-1)
            AccomodationPerDayCost.Text = AccomodationCost[AccomodationList.SelectedIndex].ToString("C");

            if(AccomodationList.SelectedIndex!=-1 && WorkshopsList.SelectedIndex!=-1)
            {
            AccomodationTotalCost.Text = (AccomodationCost[AccomodationList.SelectedIndex] * workshops[WorkshopsList.SelectedIndex].Length).ToString("C");
                TotalCost.Text = CalculateTotalCost().ToString("c");
            }
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
