using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Munchies
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxChicken_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxChicken_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxPizza_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxPizza_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            AdminLogin al = new AdminLogin();
            al.Show();
            this.Hide();
        }

        private void textBoxPizza_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxChicken_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxBurger_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxQnty.Text = "";
            textBoxType.Text = "";
            errorProvider.Clear();

        }

        public Boolean Validate()
        {

            bool isValid = true;

            if (textBoxType.Text == "")
            {
                isValid = false;
                errorProvider.SetError(textBoxType, "Enter Food Type");

            }
            if (textBoxQnty.Text == "")
            {
                isValid = false;
                errorProvider.SetError(textBoxQnty, "Enter  Quantity");

            }






            return isValid;

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (Validate() == true)
            {
                AdminReceipt ar = new AdminReceipt();
                ar.Show();
                this.Hide();
            }
        }

        private void textBoxType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void textBoxQnty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (! Char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
