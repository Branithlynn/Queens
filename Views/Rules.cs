using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Queens.Views
{
    public partial class Rules : Form
    {
        public Rules()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartUp index = new StartUp();
            this.Hide();
            index.Show();
        }
    }
}
