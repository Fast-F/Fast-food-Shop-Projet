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

namespace Munchies
{
    public partial class AdminReceipt : Form
    {
        string FolderName = @"E:\junaid2\Munchies";
        string FileName = "menus.xml";

        public AdminReceipt()
        {
            InitializeComponent();
        }

        

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.MenuItemsAdmin.Items.Add(this.NewItem.Text + "---------------" + this.newItemPrice.Text);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if(Validate())
            {
                string newitem = NewItem.Text.ToString(),
                    price = newItemPrice.Text.ToString();
                var mydoc = XDocument.Load(FolderName);
                var items = from item in mydoc.Descendants("munchies")
                            where item.Element("NewItem").Value == edititem
                            select items;
               

            }
          }

        private void btndelete_Click(object sender, EventArgs e)
        {
            var doc = XDocument.Load(FolderName);
            string deleteID = "3";
            doc.Descendants("student")
                .Where(x => (string)x.Element("id") == deleteID)
                .Remove();
            doc.Save(FolderName);
        }

        private void AdminReceipt_Load(object sender, EventArgs e)
        {
            FolderName = Path.Combine(FolderName, FileName);
            //string path = FolderName + "\\" + FileName ;
            if (File.Exists(FolderName))
                MessageBox.Show("The Folder Already exists!!!!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else

                File.Create(FolderName);
            MessageBox.Show("Folder is Created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<ComputerEngineering>" + "<course>" + "<courseCode>Cmpe214</courseCode>" + "<name>VisualProgramming</name>" + "<credit>3</credit>" + "</course>" +
                "<course>" + "<courseCode>Cmpe223</courseCode>" + "<name>Algorithm and Programming</name>" + "<credit>4</credit>" + "</course>" + "</ComputerEngineering>");




            if (File.Exists(FolderName))
            {
                using (XmlTextWriter records = new XmlTextWriter(FolderName, null))
                {
                    records.Formatting = Formatting.Indented;

                    doc.Save(records);


                    MessageBox.Show("File is successfully written");
                }
            }
            else
                MessageBox.Show("File not exists!!!!!!!");
        }
    }
}

