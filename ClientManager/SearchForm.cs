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
using ClientManager.Properties;

namespace ClientManager
{
    public partial class SearchForm : MetroForm
    {
        public SearchForm()
        {
            InitializeComponent();
        }
        private static string[] data;
        private static string[] sub_data;
        private static string name;
        private static int count_results = 0;
        private static int countTimer = 0;
        public void showResults(Dictionary<int, Dictionary<string, string>> dict)
        {
            var top = 0;
            var left = 0;
            listBox_results.Items.Clear();
            Image image = Resources._1487446389_arrow_right_circle;
            for (int i = 0; i < dict.Count; i++)
            {
                if (name == dict[i]["name"] + " " + dict[i]["surname"] ||
                    name == dict[i]["name"] || name == dict[i]["surname"])
                {
                    listBox_results.Items.Add(dict[i]["name"] + " - " + dict[i]["surname"]);
                    MetroFramework.Controls.MetroTile tile = new MetroFramework.Controls.MetroTile();
                    tile.Text = dict[i]["name"] + " " + dict[i]["surname"];
                    tile.Left = left;
                    tile.Top = top;
                    tile.Width = metroPanel1.Width / 2 + 50;
                    tile.Image = image;
                    metroPanel1.Controls.Add(tile);
                    top += tile.Height + 2;
                    count_results++;
                }
            }
        }
        private void button_search_Click(object sender, EventArgs e)
        {
            count_results = 0;
            name = textBox_search_name.Text.Trim(new Char[] { ',', ' ', '-' });
            using (FileStream stream = new FileStream(Main.filename, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string f_name = string.Empty;
                    string l_name = string.Empty;
                    List<string> clients = new List<string>();
                    while (!reader.EndOfStream)
                    {
                        clients.Add(reader.ReadLine());
                    }
                    data = clients.ToArray();
                }
            }
            Dictionary<int, Dictionary<string, string>> allClients = new Dictionary<int, Dictionary<string, string>>();
            for (int i = 0; i < data.Length; i++)
            {
                string sub_d = data[i];
                sub_data = sub_d.Split(',');
                allClients.Add(i, new Dictionary<string, string>());
                allClients[i].Add("id", sub_data[0]);
                allClients[i].Add("name", sub_data[1]);
                allClients[i].Add("surname", sub_data[2]);
                allClients[i].Add("egn", sub_data[3]);
                allClients[i].Add("address", sub_data[4]);
                allClients[i].Add("number", sub_data[5]);
                allClients[i].Add("mail", sub_data[6]);
            }

            showResults(allClients);
            label_results.Text = "Намерени резултати:" + count_results.ToString();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroPanel1.Controls.Clear();
            timer1.Stop();
            listBox_results.Text = "";
            metroProgressSpinner1.Visible = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            metroProgressSpinner1.Visible = true;
            countTimer++;
            if(countTimer == 5)
            {
                timer1.Stop();
                metroProgressSpinner1.Visible = false;
                button_search_Click(sender, e);
                countTimer = 0;
            }
        }
    }
}
