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
    public partial class FormEdit : Form
    {
        string filename = "data.txt";
        private string name = string.Empty;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public FormEdit()
        {
            InitializeComponent();
        }
        public FormEdit(string updatedItem)
        {
            InitializeComponent();
            name = updatedItem;
        }
        private void textBox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            string[] data = name.Split('-');
            string edit_row = data[0];
            string[] edit = edit_row.Split(')');
            string edit_id = edit[0];
            using (FileStream stream = new FileStream(filename,FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] lineArr = line.Split(',');
                        string cur_id = lineArr[0];
                        MessageBox.Show(edit_id);
                        if (cur_id == edit_id)
                        {
                            textBox_name.Text = lineArr[1];
                            textBox_surname.Text = lineArr[2];
                            textBox_egn.Text = lineArr[3];
                            textBox_address.Text = lineArr[4];
                            textBox_mail.Text = lineArr[5];
                            
                        }
                       
                    }
                }
            }
        }
    }
}
