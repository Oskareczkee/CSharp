using System;
using System.IO;
using System.Windows.Forms;

namespace Tablice_i_listy
{
    public partial class Siemanczek : Form
    {
        int[][] wyniki = initResultArray(3, new int[] { 12, 8, 10 });
        string[] data_pathes = {@"P:\Visual Studio Programy\CSharp\Tablice i listy\Section1.txt",
                                @"P:\Visual Studio Programy\CSharp\Tablice i listy\Section2.txt",
                                @"P:\Visual Studio Programy\CSharp\Tablice i listy\Section3.txt"};

        public static int[][] initResultArray(int rows, int[] cols)
        {
            int[][] Array = new int[rows][];
            for (int x = 0; x < rows; x++)
                Array[x] = new int[cols[x]];
            return Array;
        }

        private void load_data(ref int[][] Array, ref string[] path_to_data)
        {
            StreamReader reader;
            for (int x = 0; x < Array.Length; x++)
            {
                reader = File.OpenText(path_to_data[x]);
                for (int y = 0; y < Array[x].Length; y++)
                {
                    if (!int.TryParse(reader.ReadLine(), out Array[x][y]))
                    {
                        MessageBox.Show("Couldn't parse value in file:\n " + path_to_data[x] + "\nin column: " + y);
                    }
                }
            }
        }

        private void load_data_to_Listbox(ref ListBox listBox, ref int[] data)
        {
            for (int x = 0; x < data.Length; x++)
                listBox.Items.Add(data[x].ToString());
        }




        public Siemanczek()
        {
            InitializeComponent();
        }

        private void Siemanczek_Load(object sender, EventArgs e)
        {
            load_data(ref wyniki, ref data_pathes);
            load_data_to_Listbox(ref Section1, ref wyniki[0]);
            load_data_to_Listbox(ref Section2, ref wyniki[1]);
            load_data_to_Listbox(ref Section3, ref wyniki[2]);

            CalculateEveryting();
        }

        private float Calculate_average(int[] Scores)
        {
            float average = 0;

            for (int x = 0; x < Scores.Length; x++)
                average += Scores[x];
            average /= Scores.Length;
            return average;
        }

        private float Calculate_average(int[][] Scores)
        {
            float average = 0;

            int entries = 0;

            for (int x = 0; x < Scores.Length; x++)
            {
                entries += Scores[x].Length;
                for (int y = 0; y < Scores[x].Length; y++)
                {
                    average += Scores[x][y];
                }
            }
            average /= entries;
            return average;
        }

        private float Calculate_Highest(int[] Scores)
        {
            float highest = 0;

            for (int x = 0; x < Scores.Length; x++)
            {
                if (highest < Scores[x])
                    highest = Scores[x];
            }
            return highest;
        }

        private float Calculate_Highest(int[][] Scores)
        {
            float highest = 0;

            for (int x = 0; x < Scores.Length; x++)
            {
                for (int y = 0; y < Scores[x].Length; y++)
                {
                    if (highest < Scores[x][y])
                        highest = Scores[x][y];
                }
            }
            return highest;
        }

        private float Calculate_lowest(int[] Scores)
        {
            float lowest = 0;

            for (int x = 0; x < Scores.Length; x++)
            {
                if (lowest > Scores[x])
                    lowest = Scores[x];
            }
            return lowest;
        }

        private float Calculate_lowest(int[][] Scores)
        {
            float lowest = 2000;

            for (int x = 0; x < Scores.Length; x++)
            {
                for (int y = 0; y < Scores[x].Length; y++)
                {
                    if (lowest > Scores[x][y])
                        lowest = Scores[x][y];
                }
            }
            return lowest;
        }

        private void CalculateEveryting()
        {
            int section = 0;

            foreach (GroupBox gb in Controls)
            {
                if (gb.Name == "GeneralInformations")
                {
                    gb.Controls[2].Text = Calculate_average(wyniki).ToString();
                    gb.Controls[1].Text = Calculate_Highest(wyniki).ToString();
                    gb.Controls[0].Text = Calculate_lowest(wyniki).ToString();
                }

                //japierdole tak mi się nie chciało ręcznie tych kontrolek ustawiać, nie wiem dlaczego pętelką nie moglem tego zrobic, moze sie kiedys dowiem

            }
        }
    }
}
