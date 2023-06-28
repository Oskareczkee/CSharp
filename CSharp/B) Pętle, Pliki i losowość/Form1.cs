using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace B__Pętle__Pliki_i_losowość
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            int days=0;
            float Population=0;
            float dailyGrow=0;


            try
            {
                days = int.Parse(Days.Text);
                Population = int.Parse(INOO.Text);
                dailyGrow = float.Parse(DailyGrow.Text.Replace("%", ""))/100;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            for(int x=1;x<=days;x++)
            {
                Population *= 1 + dailyGrow;

                string[] data = { x.ToString(), Population.ToString() };
                Data.Rows.Add(data);
            }
        }

        private void DailyGrow_TextChanged(object sender, EventArgs e)
        {
            double siema;
            if (double.TryParse(DailyGrow.Text.Replace("%", ""), out siema))
            {
                siema /= 100;
                DailyGrow.Text = siema.ToString("p");
            }
            else
            {
                MessageBox.Show("Nieprawidołowy format wejściowy !");
                DailyGrow.Text = string.Empty;
            }

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;

            if (Data.Rows.Count==0)
            {
                MessageBox.Show("Nie ma danych do zapisania !");
                return;
            }

            if(saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                outputFile = File.CreateText(saveFileDialog.FileName);
                foreach(DataGridViewRow row in Data.Rows)
                {
                    string[] saveRow = { row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString() };
                    outputFile.Write(saveRow[0]+". Dzień: ");
                    outputFile.WriteLine(saveRow[1]);

                }
              outputFile.Close(); 
            }


        }
    }
}
