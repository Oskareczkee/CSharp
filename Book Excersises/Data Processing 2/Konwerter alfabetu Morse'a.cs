using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przetwarzanie_danych_numero_dos
{
    public partial class Program2 : Form
    {

        private static Dictionary<char, string> _morseAlphabetDictionary;

        private void InitalizeDictionary()
        {
            _morseAlphabetDictionary = new Dictionary<char, string>()
                                   {
                                       {'a', ".-"},
                                       {'b', "-..."},
                                       {'c', "-.-."},
                                       {'d', "-.."},
                                       {'e', "."},
                                       {'f', "..-."},
                                       {'g', "--."},
                                       {'h', "...."},
                                       {'i', ".."},
                                       {'j', ".---"},
                                       {'k', "-.-"},
                                       {'l', ".-.."},
                                       {'m', "--"},
                                       {'n', "-."},
                                       {'o', "---"},
                                       {'p', ".--."},
                                       {'q', "--.-"},
                                       {'r', ".-."},
                                       {'s', "..."},
                                       {'t', "-"},
                                       {'u', "..-"},
                                       {'v', "...-"},
                                       {'w', ".--"},
                                       {'x', "-..-"},
                                       {'y', "-.--"},
                                       {'z', "--.."},
                                       {'0', "-----"},
                                       {'1', ".----"},
                                       {'2', "..---"},
                                       {'3', "...--"},
                                       {'4', "....-"},
                                       {'5', "....."},
                                       {'6', "-...."},
                                       {'7', "--..."},
                                       {'8', "---.."},
                                       {'9', "----."},
                                       {' ', " " }
                                   };
        }

        private bool TranslateToText = true;// otherwise translate to morse

        private string TextToMorse(string text)
        {
            string output = string.Empty;

            foreach (char character in text)
            {
                if (_morseAlphabetDictionary.ContainsKey(character))
                {
                    //output.Insert(output.Length, _morseAlphabetDictionary[character]);
                    output += _morseAlphabetDictionary[character];
                }
                else
                    MessageBox.Show("Character: " + character + "is not implemented in Morse alphabet !");
            }

            return output;
        }

        public static T KeyByValue<T, W>(Dictionary<T, W> dict, W val)
        {
            T key = default;
            foreach (KeyValuePair<T, W> pair in dict)
            {
                if (EqualityComparer<W>.Default.Equals(pair.Value, val))
                {
                    key = pair.Key;
                    break;
                }
            }
            return key;
        }

        private string MorseToText(string text)
        {
            char[] Separators = { ' ', '/' };

            string[] SeparatedWords=text.Split(Separators);

            string output=String.Empty;

            foreach(string s in SeparatedWords)
            {
                if(_morseAlphabetDictionary.ContainsValue(s))
                {
                    output += KeyByValue(_morseAlphabetDictionary, s);
                }
                else
                    MessageBox.Show("Character: " + s + "is not implemented in Text alphabet !");
            }
            return output;
        }

        public Program2()
        {
            InitializeComponent();
            InitalizeDictionary();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Translate_Click(object sender, EventArgs e)
        {
            if (!TranslateToText)
            {
                TranslatedText.Text = TextToMorse(TextToTranslate.Text);
            }
            else
                TranslatedText.Text = MorseToText(TextToTranslate.Text);

        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            if (TranslateToText)
            {
                TranslateToText = !TranslateToText;
                TranslationType.Text = "Text to Morse";
            }
            else
            {
                TranslateToText = true;
                TranslationType.Text = "Morse to Text";
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            TextToTranslate.Clear();
            TranslatedText.Clear();
        }
    }
}
