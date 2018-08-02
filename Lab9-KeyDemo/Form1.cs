using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9_KeyDemo
{
    public partial class KeyDemo : Form
    {
        public KeyDemo()
        {
            InitializeComponent();
        }

        private void KeyDemo_KeyDown(object sender, KeyEventArgs e)
        {
            //Clear previous output
            rtxtKeyInfo.Text = string.Empty;

            rtxtKeyInfo.Text = $"Alt: {(e.Alt ? "Yes" : "No")}\n" +
                               $"Shift: {(e.Shift ? "Yes" : "No")}\n" +
                               $"Ctrl: {(e.Control ? "Yes" : "No")}\n" +
                               $"KeyCode: {e.KeyCode}\n" +
                               $"KeyData: {e.KeyData}\n" +
                               $"KeyValue: {e.KeyValue}\n";
        }

        private void KeyDemo_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblKeyPressed.Text = $"Key Pressed: {e.KeyChar}";
        }
    }
}
