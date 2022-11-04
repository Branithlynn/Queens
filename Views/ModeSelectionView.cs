using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Queens.Views
{
    public partial class ModeSelectionView : Form
    {
        public ModeSelectionView()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StartUp index = new StartUp();
            this.Hide();
            index.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChooseSizeView chooseSizeView = new ChooseSizeView();
            this.Hide();
            chooseSizeView.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BotSizeView chooseSizeView = new BotSizeView();
            this.Hide();
            chooseSizeView.Show();
        }
    }
}
