using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuClassWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an example of how to use Menu Items", "About", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearFont()
        {
            timesNewRomanToolStripMenuItem.Checked = false;
            
        }
        private void ClearColor()
        {
            blackToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            labelDisplay.ForeColor = Color.Black;
            blackToolStripMenuItem.Checked = true;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            labelDisplay.ForeColor = Color.Green;
            greenToolStripMenuItem.Checked = true;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            labelDisplay.ForeColor = Color.Red;
            redToolStripMenuItem.Checked = true;
            
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            timesNewRomanToolStripMenuItem.Checked = true;
            labelDisplay.Font = new Font("Times New Roman", 14, labelDisplay.Font.Style);
        }

        private void couriesrNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            couriesrNewToolStripMenuItem.Checked = true;
            labelDisplay.Font = new Font("Courier", 14, labelDisplay.Font.Style);
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            boldToolStripMenuItem.Checked = !boldToolStripMenuItem.Checked;
            labelDisplay.Font = new Font(labelDisplay.Font, labelDisplay.Font.Style ^ FontStyle.Bold);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            italicToolStripMenuItem.Checked = !italicToolStripMenuItem.Checked;
            labelDisplay.Font = new Font(labelDisplay.Font, labelDisplay.Font.Style ^ FontStyle.Italic);
        }
        
    }
}
