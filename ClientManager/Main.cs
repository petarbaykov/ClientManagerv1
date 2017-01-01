using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void функцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
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
    }
}
