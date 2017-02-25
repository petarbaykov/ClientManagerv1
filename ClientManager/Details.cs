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
    public partial class Details : MetroForm
    {
        private  int index = 0;
        public static string filename = "data.txt";
        public static string edit_id;
        public static string[] rowData;
        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }

        }
        public Details()
        {
            InitializeComponent();
        }
        public Details(int index)
        {
            this.index = index;
        }

        private void Details_Load(object sender, EventArgs e)
        {

            using (FileStream stream = new FileStream(filename, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] lineArr = line.Split(',');
                        string cur_id = lineArr[0];
                        if (int.Parse(cur_id) == index)
                        {
                            metroLabelname.Text = lineArr[1];
                            metroLabelsurname.Text = lineArr[2];
                            metroLabelegn.Text = lineArr[3];
                            metroLabeladdress.Text = lineArr[4];
                            metroLabelphone.Text = lineArr[5];
                            metroLabelmail.Text = lineArr[6];

                        }

                    }
                }
            }
        }
    }
}
