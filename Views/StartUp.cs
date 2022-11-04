using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Queens.Views
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rules rules = new Rules();
            this.Hide();
            rules.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModeSelectionView modeSelectionView = new ModeSelectionView();
            this.Hide();
            modeSelectionView.Show();
        }
    }
}
