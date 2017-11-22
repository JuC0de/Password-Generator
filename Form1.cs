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

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Generate Button
        private void button1_Click(object sender, EventArgs e)
        {
            // Clean previous generated Passwords
            GC.Collect();


            // The Lenght of the Generated Password
            if ((checkBox7.Checked) || (!checkBox7.Checked))
            {
                var check = int.TryParse(tb_output_lenght.Text, out var outputLenght);
                if (check)
                {
                    // Set Value for the Lenght of the Generated Password
                    Options.Laenge = outputLenght;
                    // Final Generated Password
                    tb_output.Text = Options.CharGenerator(tb_zeichen.Text);

                }
                else
                    MessageBox.Show("Value should be a Number.");
            }

            // Save To File CheckBox definition
            if (checkBox5.Checked)
            {
                if (cb_address.Checked & cb_username.Checked)
                    Options.AppendToAFile(Options.Pfad, tb_output.Text + " " + tb_username.Text + " " + tb_address.Text);
                else if (cb_username.Checked)
                    Options.AppendToAFile(Options.Pfad, tb_output.Text + " " + tb_username.Text + " " + null);
                else if (cb_address.Checked)
                    Options.AppendToAFile(Options.Pfad, tb_output.Text + " " + null + " " + tb_address.Text);
                else
                    Options.AppendToAFile(Options.Pfad, tb_output.Text + " " + null + " " + null);
            }
        }
        #endregion
        #region Close Button
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region Save to A File
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                cb_username.Enabled = true;
                cb_address.Enabled = true;
            }
            else
            {
                cb_username.Enabled = false;
                cb_address.Enabled = false;
            }
        }
        #endregion
        #region Small Letter
        // Small Letter
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                tb_zeichen.Text = tb_zeichen.Text + Options.smallLetter;
            else
                tb_zeichen.Text = tb_zeichen.Text.Replace(Options.smallLetter, "");
        }
        #endregion
        #region Numbers
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //Numbers
            if (checkBox3.Checked)
                tb_zeichen.Text = tb_zeichen.Text + Options.numbers;
            else
                tb_zeichen.Text = tb_zeichen.Text.Replace(Options.numbers, "");
        }
        #endregion                
        #region Symbols
        // Symbols
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
                tb_zeichen.Text = tb_zeichen.Text + Options.symbols;
            else
                tb_zeichen.Text = tb_zeichen.Text.Replace(Options.symbols, "");
        }
        #endregion
        #region Big Letter
        //Big Letters
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                tb_zeichen.Text = tb_zeichen.Text + Options.bigLetters;
            else
                tb_zeichen.Text = tb_zeichen.Text.Replace(Options.bigLetters, "");
        }
        #endregion
        #region Password Lenght
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
                tb_output_lenght.ReadOnly = false;
            else
                tb_output_lenght.ReadOnly = true;
        }
        #endregion
        #region About
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Made by Jurij Bzemovskij");
        }
        #endregion
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        #region CheckBox Username
        private void cb_username_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_username.Checked)
                tb_username.ReadOnly = false;
            else
                tb_username.ReadOnly = true;
        }
        #endregion
        #region CheckBox Address
        private void cb_address_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_address.Checked)
                tb_address.ReadOnly = false;
            else
                tb_address.ReadOnly = true;
        }
        #endregion
        #region Unused

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
        private void tb_zeichen_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region TextBox Address
        private void tb_address_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            var view = new PasswordViewer();
            if (File.Exists(Options.Pfad))
            {
                view.toolStripStatusLabel1.Text = Options.Pfad.ToString();
                view.Show();
            }
            else MessageBox.Show("You need to check 'Save to a File' box\nand generate some passwords before\nyou can view anything.");

        }
    }
}

