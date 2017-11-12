using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (checkBox7.Checked)
                Options.Laenge = Convert.ToByte(tb_output_lenght.Text);
            else
                Options.Laenge = Convert.ToByte(tb_output_lenght.Text);


            // Final Generated Password
            tb_output.Text = Options.CharGenerator(tb_zeichen.Text);


            // The Statubs Bar
            toolStripLabel1.Text = Options.StatusBar();
        }
        #endregion
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Small Letter
        // Small Letter
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState.ToString() == "Checked")
                tb_zeichen.Text = tb_zeichen.Text + Options.smallLetter;
            else
                tb_zeichen.Text = tb_zeichen.Text.Replace(Options.smallLetter, "");
        }
        #endregion
        #region Numbers
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //Numbers
            if (checkBox3.CheckState.ToString() == "Checked")
                tb_zeichen.Text = tb_zeichen.Text + Options.numbers;
            else
                tb_zeichen.Text = tb_zeichen.Text.Replace(Options.numbers, "");
        }
        #endregion                
        #region Symbols
        // Symbols
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.CheckState.ToString() == "Checked")
                tb_zeichen.Text = tb_zeichen.Text + Options.symbols;
            else
                tb_zeichen.Text = tb_zeichen.Text.Replace(Options.symbols, "");
        }
        #endregion
        #region Big Letter
        //Big Letters
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState.ToString() == "Checked")
                tb_zeichen.Text = tb_zeichen.Text + Options.bigLetters;
            else
                tb_zeichen.Text = tb_zeichen.Text.Replace(Options.bigLetters, "");
        }
        #endregion
        #region Password Lenght
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.CheckState.ToString() == "Checked")
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
        #region Unused
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }
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
    }
}

