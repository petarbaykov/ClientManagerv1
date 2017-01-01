namespace ClientManager
{
    partial class FormAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_add = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_surname = new System.Windows.Forms.Label();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.label_egn = new System.Windows.Forms.Label();
            this.textBox_egn = new System.Windows.Forms.TextBox();
            this.label_address = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label_number = new System.Windows.Forms.Label();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.label_mail = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_add
            // 
            this.label_add.AutoSize = true;
            this.label_add.Location = new System.Drawing.Point(69, 22);
            this.label_add.Name = "label_add";
            this.label_add.Size = new System.Drawing.Size(132, 13);
            this.label_add.TabIndex = 0;
            this.label_add.Text = "Добавяне на нов клиент";
            this.label_add.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_add.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(12, 58);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(82, 13);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Име на клиент";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(130, 55);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(142, 20);
            this.textBox_name.TabIndex = 2;
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Location = new System.Drawing.Point(12, 86);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(109, 13);
            this.label_surname.TabIndex = 3;
            this.label_surname.Text = "Фамилия на клиент";
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(130, 83);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(142, 20);
            this.textBox_surname.TabIndex = 4;
            // 
            // label_egn
            // 
            this.label_egn.AutoSize = true;
            this.label_egn.Location = new System.Drawing.Point(12, 112);
            this.label_egn.Name = "label_egn";
            this.label_egn.Size = new System.Drawing.Size(28, 13);
            this.label_egn.TabIndex = 5;
            this.label_egn.Text = "ЕГН";
            // 
            // textBox_egn
            // 
            this.textBox_egn.Location = new System.Drawing.Point(130, 112);
            this.textBox_egn.Name = "textBox_egn";
            this.textBox_egn.Size = new System.Drawing.Size(142, 20);
            this.textBox_egn.TabIndex = 6;
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(13, 138);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(38, 13);
            this.label_address.TabIndex = 7;
            this.label_address.Text = "Адрес";
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(130, 139);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(142, 20);
            this.textBox_address.TabIndex = 8;
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Location = new System.Drawing.Point(13, 166);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(52, 13);
            this.label_number.TabIndex = 9;
            this.label_number.Text = "Телефон";
            // 
            // textBox_number
            // 
            this.textBox_number.Location = new System.Drawing.Point(130, 166);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(142, 20);
            this.textBox_number.TabIndex = 10;
            // 
            // textBox_mail
            // 
            this.textBox_mail.Location = new System.Drawing.Point(130, 193);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(142, 20);
            this.textBox_mail.TabIndex = 11;
            // 
            // label_mail
            // 
            this.label_mail.AutoSize = true;
            this.label_mail.Location = new System.Drawing.Point(13, 193);
            this.label_mail.Name = "label_mail";
            this.label_mail.Size = new System.Drawing.Size(41, 13);
            this.label_mail.TabIndex = 12;
            this.label_mail.Text = "Имейл";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(16, 226);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(256, 23);
            this.button_add.TabIndex = 13;
            this.button_add.Text = "Добавяне";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label_mail);
            this.Controls.Add(this.textBox_mail);
            this.Controls.Add(this.textBox_number);
            this.Controls.Add(this.label_number);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.textBox_egn);
            this.Controls.Add(this.label_egn);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.label_surname);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_add);
            this.Name = "Add";
            this.Text = "Добавяне на нов клиент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_add;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.Label label_egn;
        private System.Windows.Forms.TextBox textBox_egn;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.Label label_mail;
        private System.Windows.Forms.Button button_add;
    }
}