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
namespace ClientManager
{
    public partial class StartForm : MetroForm
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }
        private void къмКлиентскаСистемаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
        }

        private void информацияToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
            this.Close();
            
        }

        private void къмКлиентскаСистемаToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
        }

        private void информацияToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show(); 
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            button1_Click_1(sender, e);
            
        }
    }
}
