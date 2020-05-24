using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Munchies
{
    public partial class AdminLogin : Form
    {
        XmlSerializer xs;
        List<AdminClass> la;

        public AdminLogin()
        {
            InitializeComponent();
            xs = new XmlSerializer(typeof(List<AdminClass>));
            la = new List < AdminClass>() ;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string name = "";
            string password = "";

            name = this.textBoxName.Text;
            password = this.textBoxPassWord.Text;


            FileStream fs = new FileStream("E:\\junaid\\Munchies\\Passwords.Xml", FileMode.Open, FileAccess.Read);
            la = (List<AdminClass>)xs.Deserialize(fs);
            dataGridView.DataSource=la;

            fs.Close();

            if (Validate() == true)
            {

                   SignUp su = new SignUp();
                if ((su.txtName.Text == name) && (su.txtPassword.Text == password))
                {

                    AdminMenu op = new AdminMenu();
                    op.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("USERNAME & PASSWORD do not match!");

                      
                }




            }
        }

        private void bttnClear_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxPassWord.Text = "";
            errorProvider.Clear();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Option op = new Option();
            op.Show();
            this.Hide();
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }
        }
            public Boolean Validate()
            {

                bool isValid = true;

                if (textBoxName.Text == "")
                {
                    isValid = false;
                    errorProvider.SetError(textBoxName, "Enter your username");

                }
                if (textBoxPassWord.Text == "")
                {
                    isValid = false;
                    errorProvider.SetError(textBoxPassWord, "Enter your password");

                     }



                return isValid;

            }
        }
    }

