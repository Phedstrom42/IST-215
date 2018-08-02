using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab14_AppWithTabs
{
    public partial class TabsWithCheckedListBoxes : Form
    {
        public TabsWithCheckedListBoxes()
        {
            InitializeComponent();
        }

        private void chkListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int index = chkListBox.SelectedIndex;

            switch(index)
            {
                case 0:
                    linkLabel1.Visible = !linkLabel1.Visible;
                    break;
                case 1:
                    linkLabel2.Visible = !linkLabel2.Visible;
                    break;
                case 2:
                    linkLabel3.Visible = !linkLabel3.Visible;
                    break;
                case 3:
                    linkLabel4.Visible = !linkLabel4.Visible;
                    break;
                case 4:
                    linkLabel5.Visible = !linkLabel5.Visible;
                    break;
                case 5:
                    linkLabel6.Visible = !linkLabel6.Visible;
                    break;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            Process.Start("IExplore", linkLabel1.Text);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true;
            Process.Start("IExplore", linkLabel2.Text);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel3.LinkVisited = true;
            Process.Start("IExplore", linkLabel3.Text);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel4.LinkVisited = true;
            Process.Start("IExplore", linkLabel4.Text);
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel5.LinkVisited = true;
            Process.Start("IExplore", linkLabel5.Text);
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel6.LinkVisited = true;
            Process.Start("IExplore", linkLabel6.Text);
        }

        private void btnURL1_Click(object sender, EventArgs e)
        {
            linksTabControl.SelectedTab = linksTab;

            linkLabel1.LinkVisited = false;
            linkLabel1.Text = txtURL1.Text;

        }

        private void btnURL2_Click(object sender, EventArgs e)
        {
            linksTabControl.SelectedTab = linksTab;

            linkLabel2.LinkVisited = false;
            linkLabel2.Text = txtURL2.Text;
        }

        private void btnURL3_Click(object sender, EventArgs e)
        {
            linksTabControl.SelectedTab = linksTab;

            linkLabel3.LinkVisited = false;
            linkLabel3.Text = txtURL3.Text;
        }

        private void btnURL4_Click(object sender, EventArgs e)
        {
            linksTabControl.SelectedTab = linksTab;

            linkLabel4.LinkVisited = false;
            linkLabel4.Text = txtURL4.Text;
        }

        private void btnURL5_Click(object sender, EventArgs e)
        {
            linksTabControl.SelectedTab = linksTab;

            linkLabel5.LinkVisited = false;
            linkLabel5.Text = txtURL5.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            linksTabControl.SelectedTab = linksTab;

            linkLabel6.LinkVisited = false;
            linkLabel6.Text = txtURL6.Text;
        }
    }
}
