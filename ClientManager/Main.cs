using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;

namespace ClientManager
{
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
           
        }

        private void Main_Load(object sender, EventArgs e)
        {
            getClients();
            metroTile1.Text = "Клиенти: \n" + countClients.ToString();
        }
        public static string filename = "data.txt";
        List<string> clients = new List<string>();
        List<string> data = new List<string>();
        public int countClients = 0;
        public void fillList(List<string> l)
        {
            listBox_clients.Items.Clear();
            foreach (string cl in l)
            {
                listBox_clients.Items.Add(cl);
                countClients += 1;
            }
        }
        public void getClients()
        {
            clients.Clear();
            using (FileStream stream = new FileStream(filename, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] data = line.Split(',');
                        string id = data[0];
                        string f_name = data[1];
                        string l_name = data[2];
                        clients.Add(id + ")" + f_name + "-" + l_name);
                    }
                }
            }
            fillList(clients);
        }
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_add_Click(sender, e);
        }

        private void add_menu_Click(object sender, EventArgs e)
        {
            FormAdd addform = new FormAdd();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            FormAdd addform = new FormAdd();
            addform.Show();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = listBox_clients.SelectedItem.ToString();
            int index = listBox_clients.SelectedIndex;
            FormEdit editform = new FormEdit(name);
            /* if(editform.ShowDialog() == DialogResult.OK)
             {
                 listBox_clients.Items.RemoveAt(index);
                 listBox_clients.Items.Insert(index, editform.Name);
             }*/
            editform.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm searchform = new SearchForm();
            searchform.Show();
        }

        private void listBox_clients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            button_add_Click(sender, e);
        }

        private void EditToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string name = listBox_clients.SelectedItem.ToString();
            int index = listBox_clients.SelectedIndex;
            FormEdit editform = new FormEdit(name);
           
            editform.Show();
        }

        private void searchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SearchForm searchform = new SearchForm();
            searchform.Show();
        }

        private void изтриванеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void извличанеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button_add_Click_1(object sender, EventArgs e)
        {
            FormAdd addform = new FormAdd();
            addform.Show();
        }
    }
}
