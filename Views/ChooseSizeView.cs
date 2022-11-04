using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queens.Views
{
    public partial class ChooseSizeView : Form
    {
        public ChooseSizeView()
        {
            InitializeComponent();
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            bool nInputed = false;
            bool mInputed = false;
            if (NInput.Text != "")
            {
                try
                {
                    int n = Convert.ToInt32(NInput.Text);
                    if (n >= 3 && n <= 30)
                    {
                        nInputed = true;
                        ErrorLabelN.Text = "";
                    }
                    else
                    {
                        ErrorLabelN.ForeColor = Color.Red;
                        ErrorLabelN.Text = "Input is out of bonds";
                        NInput.Text = "";
                    }
                }
                catch
                {
                    ErrorLabelN.ForeColor = Color.Red;
                    ErrorLabelN.Text = "Wrong input type";
                    NInput.Text = "";
                }
            }
            else
            {
                ErrorLabelN.ForeColor = Color.Red;
                ErrorLabelN.Text = "No Input";
            }

            if (MInput.Text != "")
            {
                try
                {
                    int m = Convert.ToInt32(MInput.Text);
                    if (m >= 3 && m <= 40)
                    {
                        mInputed = true;
                        ErrorLabelM.Text = "";
                    }
                    else
                    {
                        ErrorLabelM.ForeColor = Color.Red;
                        ErrorLabelM.Text = "Input is out of bonds";
                        MInput.Text = "";
                    }
                }
                catch
                {
                    ErrorLabelM.ForeColor = Color.Red;
                    ErrorLabelM.Text = "Wrong input type";
                    MInput.Text = "";
                }
            }
            else
            {
                ErrorLabelM.ForeColor = Color.Red;
                ErrorLabelM.Text = "No Input";
            }

            if (mInputed && nInputed)
            {
                MessageBox.Show("Have fun playing!");
                this.Hide();
                GameView gameView = new GameView();
                gameView.NLength = Convert.ToInt32(NInput.Text);
                gameView.MLength = Convert.ToInt32(MInput.Text);
                gameView.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartUp index = new StartUp();
            this.Hide();
            index.Show();
        }

        private void ChooseSizeView_Load(object sender, EventArgs e)
        {

        }
    }
}
