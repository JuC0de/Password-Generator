using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PasswordGenerator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tb_Output_Characters.Text = tb_Output_Characters.Text + Options.smallLetter + Options.bigLetters + Options.numbers;
        }

        private void Generate_Click(object sender, RoutedEventArgs e)
        {
            // Clean previous generated passwords from the memory
            GC.Collect();

            // The Lenght of the Generated Password
            if ((cb_Password_Length.IsChecked is true) || (cb_Password_Length.IsChecked is false))
            {
                var check = int.TryParse(tb_Password_Length.Text, out var outputLenght);
                if (check)
                {
                    // Set Value for the Lenght of the Generated Password
                    Options.Laenge = outputLenght;
                    // Final Generated Password
                    tb_Generated_Password.Text = Options.CharGenerator(tb_Output_Characters.Text);
                }
                else
                    MessageBox.Show("Value should be a Number.");
            }

            //Save To File CheckBox definition
            if (cb_Save_To_File.IsChecked is true)
            {
                if (cb_Email.IsChecked is true & cb_Username.IsChecked is true)
                    Options.AppendToAFile(Options.Pfad, tb_Generated_Password.Text + " " + tb_Username.Text + " " + tb_Email.Text);
                else if (cb_Username.IsChecked is true)
                    Options.AppendToAFile(Options.Pfad, tb_Generated_Password.Text + " " + tb_Username.Text + " " + null);
                else if (cb_Email.IsChecked is true)
                    Options.AppendToAFile(Options.Pfad, tb_Generated_Password.Text + " " + null + " " + tb_Email.Text);
                else
                    Options.AppendToAFile(Options.Pfad, tb_Generated_Password.Text + " " + null + " " + null);
            }
        }

        private void cb_Save_To_File_Checked(object sender, RoutedEventArgs e)
        {
            if (cb_Save_To_File.IsChecked is true)
            {
                cb_Username.IsEnabled = true;
                cb_Email.IsEnabled = true;
            }
            else
            {
                cb_Username.IsEnabled = false;
                cb_Email.IsEnabled = false;
            }
        }

        private void cb_Email_Checked(object sender, RoutedEventArgs e)
        {
            if (cb_Email.IsChecked is true)
                tb_Email.IsEnabled = true;
            else
                tb_Email.IsEnabled = false;
        }

        private void cb_Username_Checked(object sender, RoutedEventArgs e)
        {
            if (cb_Username.IsChecked is true)
                tb_Username.IsEnabled = true;
            else
                tb_Username.IsEnabled = false;
        }

        private void tb_Username_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tb_Email_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Password_View_Click(object sender, RoutedEventArgs e)
        {
            // var view = new PasswordViewer();
            if (File.Exists(Options.Pfad))
            {
                // view.toolStripStatusLabel1.Text = Options.Pfad.ToString();
                // view.Show();
            }
            else MessageBox.Show("You need to check 'Save to a File' box\nand generate some passwords before\nyou can view anything.");

        }

        private void cb_Password_Length_Checked(object sender, RoutedEventArgs e)
        {
            if (cb_Password_Length.IsChecked is true)
                tb_Password_Length.IsEnabled = true;
            else
                tb_Password_Length.IsEnabled = false;
        }

        private void tb_Password_Length_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tb_Generated_Password_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cb_Small_Letters_Checked(object sender, RoutedEventArgs e)
        {
            if (cb_Small_Letters.IsLoaded is true)
            {
                if (cb_Small_Letters.IsChecked is true)
                    tb_Output_Characters.Text = tb_Output_Characters.Text + Options.smallLetter;
                else
                    tb_Output_Characters.Text = tb_Output_Characters.Text.Replace(Options.smallLetter, "");
            }
        }

        private void cb_Big_Letters_Checked(object sender, RoutedEventArgs e)
        {
            if (cb_Big_Letters.IsLoaded is true)
            { 
                if (cb_Big_Letters.IsChecked is true)
                tb_Output_Characters.Text = tb_Output_Characters.Text + Options.bigLetters;
            else
                tb_Output_Characters.Text = tb_Output_Characters.Text.Replace(Options.bigLetters, "");
            }
        }

        private void cb_Numbers_Checked(object sender, RoutedEventArgs e)
        {
            if (cb_Numbers.IsLoaded is true)
            {
                if (cb_Numbers.IsChecked is true)
                    tb_Output_Characters.Text = tb_Output_Characters.Text + Options.numbers;
                else
                    tb_Output_Characters.Text = tb_Output_Characters.Text.Replace(Options.numbers, "");
            }
        }

        private void cb_Symbols_Checked(object sender, RoutedEventArgs e)
        {
            if (cb_Symbols.IsLoaded is true)
            {
                if (cb_Symbols.IsChecked is true)
                    tb_Output_Characters.Text = tb_Output_Characters.Text + Options.symbols;
                else
                    tb_Output_Characters.Text = tb_Output_Characters.Text.Replace(Options.symbols, "");
            }
        }

        private void tb_Output_Characters_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
