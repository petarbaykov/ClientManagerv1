using System;
using System.Collections;
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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }
        private static string[] data;
        private static string[] sub_data;
        private void button_search_Click(object sender, EventArgs e)
        {
            string name = textBox_search_name.Text.Trim(new Char[] { ',',' ','-'});
            using (FileStream stream = new FileStream(Main.filename,FileMode.OpenOrCreate))
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
            Dictionary<int,Dictionary<string,string>> allClients = new Dictionary<int, Dictionary<string, string>>();
            for (int i = 0; i < data.Length; i++)
            {
                string sub_d = data[i];
                sub_data = sub_d.Split(',');
                allClients.Add(i, new Dictionary<string, string>());
                allClients[i].Add("id",sub_data[0]);
                allClients[i].Add("name", sub_data[1]);
                allClients[i].Add("surname", sub_data[2]);
                allClients[i].Add("egn", sub_data[3]);
                allClients[i].Add("address", sub_data[4]);
                allClients[i].Add("number", sub_data[5]);
                allClients[i].Add("mail", sub_data[6]);
            }

            for (int i = 0; i < allClients.Count; i++)
            {
                if(name == allClients[i]["name"] +" " +  allClients[i]["surname"])
                {
                    MessageBox.Show("Match");
                }
            }
        }
    }
}
