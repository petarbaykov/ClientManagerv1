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
        public string client;
        public int countClients = 0;
        public void fillList(List<string> l)
        {
            listBox_clients.Items.Clear();
            var top = 0;
            var left = 0;
            //var leftCenter = metroPanel1.Width / 2;
            foreach (string cl in l)
            {
                listBox_clients.Items.Add(cl);
               /* MetroFramework.Controls.MetroTile tile = new MetroFramework.Controls.MetroTile();
                tile.Text = cl;
                tile.Left = left;
                tile.Top = top;
                tile.Width = metroPanel1.Width / 2;
                metroPanel1.Controls.Add(tile);
                top += tile.Height + 2;*/
                countClients += 1;
            }
        }
        public void getClients()
        {
            clients.Clear();
            readClients();
            fillList(clients);
        }
        public void readClients()
        {
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
            try
            {
                string name = listBox_clients.SelectedItem.ToString();
                int index = listBox_clients.SelectedIndex;
                FormEdit editform = new FormEdit(name);
                editform.Show();
            }
            catch (Exception)
            {

                MetroFramework.MetroMessageBox.Show(this, "Трябва да изберете клиент", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
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
            try
            {
                string name = listBox_clients.SelectedItem.ToString();
                int index = listBox_clients.SelectedIndex;
                FormEdit editform = new FormEdit(name);
                editform.Show();
            }
            catch (Exception)
            {

                MetroFramework.MetroMessageBox.Show(this, "Трябва да изберете клиент","Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void searchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SearchForm searchform = new SearchForm();
            searchform.Show();
        }

        private void изтриванеToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            try
            {
                var index = listBox_clients.SelectedIndex;
                listBox_clients.Items.RemoveAt(index);
                /*clients.RemoveAt(index);
                clients.Clear();*/
                deleteRow(index);
                //fillList(clients);
            }
            catch (Exception)
            {

                MetroFramework.MetroMessageBox.Show(this, "Трябва да изберете клиент", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void извличанеToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            // FormEdit editform = new FormEdit(index);

            // editform.Show();
            try
            {
                string name = listBox_clients.SelectedItem.ToString();
                int index = listBox_clients.SelectedIndex;
                Details details = new Details();
                details.Show();
            }
            catch (Exception)
            {

                MetroFramework.MetroMessageBox.Show(this, "Трябва да изберете клиент", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_add_Click_1(object sender, EventArgs e)
        {
            FormAdd addform = new FormAdd();
            if (addform.DialogResult == DialogResult.OK)
            {
                clients.Add(client);
                fillList(clients);
                MessageBox.Show(client);
            }
            addform.Show();
        }
        private void deleteRow(int deleteLine)
        {
            List<string> linesList = File.ReadAllLines(filename).ToList();
            linesList.RemoveAt(deleteLine);
            File.WriteAllLines(filename, linesList.ToArray());


        }
    }
}
