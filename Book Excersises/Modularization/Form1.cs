using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modularyzacja
{
    public partial class Form1 : Form
    {

        double TotalCost = 0;

        const double TAX = 0.06; // 6%

        public Form1()
        {
            InitializeComponent();
        }

        //Methods

        private void OilLube()
        {
            if (Oil.Checked)
                TotalCost += 26;
            if (Lubrication.Checked)
                TotalCost += 18;
        }

        private void FlushCharges()
        {
            if (CoolerCheck.Checked)
                TotalCost += 30;
            if (GearboxCheck.Checked)
                TotalCost += 30;
        }

        private void MiscCharges()
        {
            if (VehicleInspection.Checked)
                TotalCost += 15;
            if (MufflerReplacement.Checked)
                TotalCost += 100;
            if (WheelBalance.Checked)
                TotalCost += 20;
        }

        private double OtherCharges()
        {
            try
            {
                TotalCost+=int.Parse(SpareParts.Text);
                TotalCost += int.Parse(WorkTime.Text) * 20;
                return int.Parse(WorkTime.Text) * 20;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

                SpareParts.Text = string.Empty;
                WorkTime.Text = string.Empty;
                return 0;
            }
        }

        private double TaxCharges()
        {
            int SparePartsCost;

            if (int.TryParse(SpareParts.Text, out SparePartsCost))
            {
                TotalCost += SparePartsCost * TAX;
                return SparePartsCost * TAX;
            }
            else
            {
                MessageBox.Show("Nieprawidlowy format !");
                SpareParts.Text = String.Empty;
                return 0;
            }
        }

        private void ClearControls()
        {
            Oil.Checked = false;
            Lubrication.Checked = false;
            CoolerCheck.Checked = false;
            GearboxCheck.Checked = false;
            VehicleInspection.Checked = false;
            MufflerReplacement.Checked = false;
            WheelBalance.Checked = false;
            SpareParts.Clear();
            WorkTime.Clear();
            ServicesAndLabor.Clear();
            SparePartsSum.Clear();
            SparePartsTax.Clear();
            Total.Clear();
        }

        //Methods



        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            OilLube();
            FlushCharges();
            MiscCharges();
            ServicesAndLabor.Text = OtherCharges().ToString();
            SparePartsTax.Text = TaxCharges().ToString() ;

            double SparePartsSumm =0 ;
            try
            {
            double.TryParse(SpareParts.Text, out SparePartsSumm);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            SparePartsSum.Text = SparePartsSumm.ToString();
            Total.Text = TotalCost.ToString();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

