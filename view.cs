using System;
using System.IO;
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
    public partial class PasswordViewer : Form
    {
        public PasswordViewer()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // Content Copy to the Clipboard
        }

        private void PasswordViewer_Load(object sender, EventArgs e)
        {
            string[] viewPassword = new string[] { string.Empty };
            viewPassword = File.ReadAllLines(Options.Pfad).ToArray();

            // Write strings from the file to the datatable
            foreach (var item in viewPassword)
            {
                string[] viewPasswordSplit = item.Split(' ');
                dataGridView1.Rows.Add(
                      string.IsNullOrEmpty(viewPasswordSplit[0]) ? " " : viewPasswordSplit[0],
                      string.IsNullOrEmpty(viewPasswordSplit[1]) ? " " : viewPasswordSplit[1],
                      string.IsNullOrEmpty(viewPasswordSplit[2]) ? " " : viewPasswordSplit[2]);
                viewPasswordSplit = new string[] { };
            }
        }

        public void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
        public void toolStripStatusLabel1_Click(object sender, EventArgs e) { }
    }
}
