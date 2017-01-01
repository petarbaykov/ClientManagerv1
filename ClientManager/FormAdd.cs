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

namespace ClientManager
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }
        string filename = "data.txt";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            using (FileStream stream = new FileStream(filename, FileMode.Append))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    string name = textBox_name.Text.Trim();
                    string surname = textBox_surname.Text;
                    string egn = textBox_egn.Text;
                    string address = textBox_address.Text;
                    string number = textBox_number.Text;
                    string mail = textBox_mail.Text;
                    if (String.IsNullOrEmpty(name))
                    {
                        MessageBox.Show("Полето име трябва да е попълнено");
                        return;
                    }
                    writer.Write(name + ",");
                    writer.Write(surname + ",");
                    writer.Write(egn + ",");
                    writer.Write(address + ",");
                    writer.Write( number+ ",");
                    writer.Write(mail);
                    writer.WriteLine();
                }
            }
        }
    }
}
