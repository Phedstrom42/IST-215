using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab13_ComboAndListBoxes
{
    public partial class StatesForm : Form
    {
        private static bool IsItemSelected = false;
        private static string[] states;
        private static string[] img;

        public StatesForm()
        {
            InitializeComponent();

            states = new string[] {  "New Hampshire",
                                     "Massachusetts",
                                     "Vermont",
                                     "Connecticut",
                                     "Maine" };

            img = new string[] { "new-hampshire1-thumb",
                                 "massachusetts1-thumb",
                                 "vermont-thumb",
                                 "connecticut1-thumb",
                                 "maine1-thumb" };

            picBoxStateFlag.Image = null;

            statesComboBox.Items.AddRange(states);

            popupMenu.BackColor = Color.OrangeRed;
            popupMenu.ForeColor = Color.Black;
            popupMenu.Text = "States Menu";
            popupMenu.Font = new Font("Segoe UI", 12);
            popupMenu.Show();

        }

        private void statesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = statesComboBox.SelectedItem.ToString();
            lblState.Text = item;

            // add the selected item to the ListBox
            stateListBox.Items.Add(statesComboBox.SelectedItem);
            stateListBox.SelectedItem = item;

            // remove the selected item form the ComboBox.
            statesComboBox.Items.RemoveAt(statesComboBox.SelectedIndex);

            // check if ComboBox is now empty
            if (statesComboBox.Items.Count == 0)
            {
                MessageBox.Show("There are no more states in the " + "ComboBox.",
                                "Empty", MessageBoxButtons.OK);
            }
        }

        private void putBackToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idx = stateListBox.SelectedIndex;
            if (idx >= 0)
            {
                string item = stateListBox.SelectedItem.ToString();
                stateListBox.Items.Remove(item);
                statesComboBox.Items.Add(item);
            }
        }

        private void stateListBox_DoubleClick(object sender, EventArgs e)
        {
            int idx = stateListBox.SelectedIndex;
            string item = stateListBox.SelectedItem.ToString();
            stateListBox.Items.Remove(item);
            statesComboBox.Items.Add(item);
        }

        private void stateListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stateListBox.SelectedIndex >= 0)
            {
                IsItemSelected = true;
                putBackToolToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;

                string item = stateListBox.SelectedItem.ToString();
                lblState.Text = item;

                string tempStr = GetResourceString(item);
                picBoxStateFlag.Image = (Image)(Properties.Resources.ResourceManager.GetObject(tempStr));
            }
            else
            {
                IsItemSelected = false;
                putBackToolToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
                picBoxStateFlag.Image = null;
                lblState.Text = string.Empty;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idx = stateListBox.SelectedIndex;
            if (idx >= 0)
            {
                stateListBox.Items.RemoveAt(idx);
            }
        }

        private string GetResourceString(string name)
        {
            string newStr = name.Substring(5);
            foreach (var str in img)
            {
                if (str.Contains(newStr))
                    return str;
            }
            return null;
        }
    }
}
