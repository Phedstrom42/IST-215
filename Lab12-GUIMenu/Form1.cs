using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12_GUIMenu
{
    public partial class MenuTest : Form
    {
        public MenuTest()
        {
            InitializeComponent();
            timer1.Start();
        }

        public void ClearColor()
        {
            blackToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            toolStripStatusLabel2.ForeColor = Color.Black;
            blackToolStripMenuItem.Checked = true;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            toolStripStatusLabel2.ForeColor = Color.Blue;
            blueToolStripMenuItem.Checked = true;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            toolStripStatusLabel2.ForeColor = Color.Red;
            redToolStripMenuItem.Checked = true;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            toolStripStatusLabel2.ForeColor = Color.Green;
            greenToolStripMenuItem.Checked = true;
        }

        private void ClearFont()
        {
            timesNewRomanToolStripMenuItem.Checked = false;
            courierToolStripMenuItem.Checked = false;
            comicSansToolStripMenuItem.Checked = false;
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            timesNewRomanToolStripMenuItem.Checked = true;
            toolStripStatusLabel2.Font = 
                new Font("Times New Roman", 14, toolStripStatusLabel2.Font.Style);
        }

        private void courierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            courierToolStripMenuItem.Checked = true;
            toolStripStatusLabel2.Font =
                new Font("Courier", 14, toolStripStatusLabel2.Font.Style);
        }

        private void comicSansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            comicSansToolStripMenuItem.Checked = true;
            toolStripStatusLabel2.Font =
                new Font("Comic Sans MS", 14, toolStripStatusLabel2.Font.Style);
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boldToolStripMenuItem.Checked = !boldToolStripMenuItem.Checked;
            toolStripStatusLabel2.Font =
                new Font(toolStripStatusLabel2.Font, toolStripStatusLabel2.Font.Style ^ FontStyle.Bold);

        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            italicToolStripMenuItem.Checked = !italicToolStripMenuItem.Checked;
            toolStripStatusLabel2.Font =
                new Font(toolStripStatusLabel2.Font, toolStripStatusLabel2.Font.Style ^ FontStyle.Italic);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dtpTodaysDate_ValueChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text =
                String.Format($"{dtpTodaysDate.Value.ToShortDateString()}  {DateTime.Now.ToLongTimeString()}");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTodaysDate.Text = DateTime.Now.ToString();
            toolStripStatusLabel1.Text = txtTodaysDate.Text;
            toolStripStatusLabel2.Text = txtTodaysDate.Text;
        }
    }
}
