using System;
using System.Windows.Forms;

namespace WinterLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Convert our input to numbers, multiply them and set the text.
            int num = Convert.ToInt32(txtNumber.Text);
            int num2 = Convert.ToInt32(txtMultiplier.Text);
            txtAnswer.Text = (num * num2).ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Blank out all text boxes
            txtNumber.Text = "";
            txtMultiplier.Text = "";
            txtAnswer.Text = "";
            // Refocus on first text box
            txtNumber.Focus();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            // Hide the label, show the image.
            picImage.Visible = true;
            lblDog.Visible = false;
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            // Hide the image, show the label.
            picImage.Visible = false;
            lblDog.Visible = true;
            lblDog.Text = "My topic is " + lblTopic.Text + ", Ace is my dog and I got him back in January when he was just under 2 months old.\n\nHe is a pug, and his best friend is our youngest dog Rusty the Golden Retriever that we just got back in July.\n\nAce is always with me when I'm home, and he always gets along well with other dogs and plays with them.\n\nThe other dogs we have at home are Poncho, Henry, Tank, Archie and Ellie.";
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            // Hide everything!
            picImage.Visible = false;
            lblDog.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the program
            Close();
        }

        private void picImage_Click(object sender, EventArgs e)
        {
            // More information about Ace
            MessageBox.Show("Ace loves to lay on big stuffed animals!", "Lyndsey Winter");
        }
    }
}
