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
        int count;
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void clearField(TextBox t)
        {
            t.Clear();
        }
        public bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return mail.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            using (FileStream stream = new FileStream(filename, FileMode.Append))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    
                    try
                    {
                        string name = textBox_name.Text.Trim();
                        string surname = textBox_surname.Text.Trim();
                        long egn = long.Parse(textBox_egn.Text);
                        string address = textBox_address.Text.Trim();
                        long number =long.Parse(textBox_number.Text);
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
                        if (!IsValidEmail(mail))
                        {
                            MessageBox.Show("Въведете валиден имейл адрес");
                            return;
                        }
                        writer.Write(count + ",");
                        writer.Write(name + ",");
                        writer.Write(surname + ",");
                        writer.Write(egn + ",");
                        writer.Write(address + ",");
                        writer.Write(number + ",");
                        writer.Write(mail);
                        writer.WriteLine();
                        
                        var success = MessageBox.Show("Успешно добавихте клиент със следните данни \n Име: "+name+" "+surname+" \n ЕГН: "+egn+" \n Адрес: "+address+" \n Номер: "+number+" \n Имейл: "+mail);
                        clearField(textBox_address);
                        clearField(textBox_name);
                        clearField(textBox_surname);
                        clearField(textBox_egn);
                        clearField(textBox_mail);
                        clearField(textBox_number);
                        count += 1;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Невалиден формат на информацията");
                    }
                   
                }
            }
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            using (FileStream stream = new FileStream(filename,FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string lastRow = string.Empty;
                    while (!reader.EndOfStream)
                    {
                        lastRow = reader.ReadLine();
                    }
                    if (new FileInfo(filename).Length == 0)
                    {
                        count = 0;
                    }
                    else
                    {
                        string[] dataLastRow = lastRow.Split(',');
                        int index = int.Parse(dataLastRow[0]);
                        count = index + 1;
                    }
                }
            }
        }
    }
}
