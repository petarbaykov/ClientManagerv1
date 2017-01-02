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
        public static string filename = "data.txt";
        private string name = string.Empty;
        public static string edit_id;
        public static int edit_line;
        public static string[] rowData;
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
            edit_id = edit[0];
            using (FileStream stream = new FileStream(filename, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] lineArr = line.Split(',');
                        string cur_id = lineArr[0];
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

        private void button_edit_Click(object sender, EventArgs e)
        {
            findEditLine();
            try
            {
                string name = textBox_name.Text.Trim();
                string surname = textBox_surname.Text.Trim();
                long egn = long.Parse(textBox_egn.Text);
                string address = textBox_address.Text.Trim(new Char[] { ',', '.' });
                long number = long.Parse(textBox_number.Text);
                string mail = textBox_mail.Text.Trim();
                if (String.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Полето име трябва да е попълнено");
                    return;
                }
                if (String.IsNullOrEmpty(surname))
                {
                    MessageBox.Show("Моля попълнете фамилия!");
                    return;
                }
                if (String.IsNullOrEmpty(address))
                {
                    MessageBox.Show("Моля попълнете адрес");
                    return;
                }
                if (String.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Моля попълнете номер");
                    return;
                }
                if (String.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Моля попълнете имейл");
                    return;
                }
                if (egn.ToString().Length != 10)
                {
                    MessageBox.Show("ЕГН трябва да е 10 цифрено");
                    return;
                }
                if (!FormAdd.IsValidEmail(mail))
                {
                    MessageBox.Show("Въведете валиден имейл адрес");
                    return;
                }
                string input = edit_id + "," + name + "," + surname + "," + egn + "," + address + "," + number + "," + mail + "\n";

                /* writer.Write(FormAdd.count + ",");
                 writer.Write(name + ",");
                 writer.Write(surname + ",");
                 writer.Write(egn + ",");
                 writer.Write(address + ",");
                 writer.Write(number + ",");
                 writer.Write(mail);
                 writer.WriteLine();*/
                lineChanger(input, filename, edit_line);
                var success = MessageBox.Show("Успешно редактирахте клиент със следните данни \n Име: " + name + " " + surname + " \n ЕГН: " + egn + " \n Адрес: " + address + " \n Номер: " + number + " \n Имейл: " + mail);
               /* FormAdd.clearField(textBox_address);
                FormAdd.clearField(textBox_name);
                FormAdd.clearField(textBox_surname);
                FormAdd.clearField(textBox_egn);
                FormAdd.clearField(textBox_mail);
                FormAdd.clearField(textBox_number);*/
                FormAdd.count += 1;
            }
            catch (FormatException)
            {
                MessageBox.Show("Невалиден формат на информацията");
            }
        }
        public static void findEditLine()
        {
            using (FileStream stream = new FileStream(filename,FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string line = string.Empty;
                    edit_line = 1;
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        string[] lineArr = line.Split(',');
                        string cur_id = lineArr[0];
                        
                        if (edit_id != cur_id)
                        {
                            edit_line++;
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
        }
        public static void lineChanger(string newText, string filename, int line_to_edit)
        {
            using (FileStream stream = new FileStream(filename, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    /*string[] arrLine = File.ReadAllLines(filename);
                    arrLine[line_to_edit - 1] = newText;
                    File.WriteAllLines(filename, arrLine);*/
                    List<string> data = new List<string>();
                    while (!reader.EndOfStream)
                    {
                        data.Add(reader.ReadLine());
                    }
                    rowData = data.ToArray();
                    rowData[line_to_edit - 1] = newText;
                }
            }
            using (FileStream stream = new FileStream(filename, FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    foreach (string item in rowData)
                    {
                        writer.WriteLine(item);
                    }
                }
            }
        }
    }
}
