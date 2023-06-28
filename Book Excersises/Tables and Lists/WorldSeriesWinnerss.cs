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

namespace Tablice_i_listy
{
    public partial class WorldSeriesWinnerss : Form
    {
        const string TeamsPath = @"P:\Visual Studio Programy\CSharp\Tablice i listy\Teams.txt";
        const string WinnersPath = @"P:\Visual Studio Programy\CSharp\Tablice i listy\WorldSeriesWinners.txt";
        List<string> WorldSeriesWinners= new List<string>();

        public WorldSeriesWinnerss()
        {
            InitializeComponent();
        }

        private void load_teams()
        {

            if(!File.Exists(TeamsPath))
            {
                MessageBox.Show("Could't find Teams.txt file !\n Click OK to close program");
                this.Close();
            }
            StreamReader reader=File.OpenText(TeamsPath);
            while (!reader.EndOfStream)
                TeamsBox.Items.Add(reader.ReadLine());
        }

        private void load_winners()
        {
            if (!File.Exists(WinnersPath))
            {
                MessageBox.Show("Could't find WorldSeriesWinners.txt file !\n Click OK to close program");
                this.Close();
            }
            StreamReader reader = File.OpenText(WinnersPath);
            while (!reader.EndOfStream)
                WorldSeriesWinners.Add(reader.ReadLine());
        }

        private int GetWinsCount(string TeamName)
        {
            int WinsCount = 0;

            foreach(string team in WorldSeriesWinners)
            {
                if (team == TeamName)
                    WinsCount++;
            }
            return WinsCount;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load_teams();
            load_winners();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TeamsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TeamName.Text = TeamsBox.SelectedItem.ToString();
            TeamWins.Text = GetWinsCount(TeamName.Text).ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
