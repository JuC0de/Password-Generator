using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    class Options
    {
        // The Lenght of the Generated Password set to Default
        private static int _laenge = 12;
        public static int Laenge
        {
            get => _laenge;
            set
            {
                if (value <= 0)
                    MessageBox.Show("Value should not be NULL.\nPrevious Value will be used.");
                else
                    _laenge = value;
            }
        }


        // The Statubs Bar
        private static short counter = 0;
        public static short Counter { get => counter; set => counter = value; }
        public static string StatusBar() => $"Passwort aus {_laenge} Zeichen {Counter++} mal generiert.";


        // Character Generator and Password output
        // Default Characters have been taken from TextBox
        public static string bigLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static string smallLetter = "abcdefghijklmnopqrstuvwxyz";
        public static string numbers = "0123456789";
        public static string symbols = "()`~!@#$%^&*-+=|{}[]:;\"\'<>,.?/";

        public static string CharGenerator(string Characters)
        {
            Form1 form1 = new Form1();
            // TextBox Text convert to String
            string chars = form1.tb_zeichen.Text;

            char[] stringChars = new char[Laenge];
            Random random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = Characters[random.Next(Characters.Length)];
            }
            string finalString = new String(stringChars);
            return finalString;
        }
    }
}

