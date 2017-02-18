namespace ClientManager
{
    partial class FormEdit
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
            this.button_edit = new System.Windows.Forms.Button();
            this.label_mail = new System.Windows.Forms.Label();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.label_number = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label_address = new System.Windows.Forms.Label();
            this.textBox_egn = new System.Windows.Forms.TextBox();
            this.label_egn = new System.Windows.Forms.Label();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.label_surname = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_add = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(172, 327);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(256, 23);
            this.button_edit.TabIndex = 41;
            this.button_edit.Text = "Редактиране";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click_1);
            // 
            // label_mail
            // 
            this.label_mail.AutoSize = true;
            this.label_mail.Location = new System.Drawing.Point(169, 294);
            this.label_mail.Name = "label_mail";
            this.label_mail.Size = new System.Drawing.Size(41, 13);
            this.label_mail.TabIndex = 40;
            this.label_mail.Text = "Имейл";
            // 
            // textBox_mail
            // 
            this.textBox_mail.Location = new System.Drawing.Point(286, 294);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(142, 20);
            this.textBox_mail.TabIndex = 39;
            // 
            // textBox_number
            // 
            this.textBox_number.Location = new System.Drawing.Point(286, 267);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(142, 20);
            this.textBox_number.TabIndex = 38;
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Location = new System.Drawing.Point(169, 267);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(52, 13);
            this.label_number.TabIndex = 37;
            this.label_number.Text = "Телефон";
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(286, 240);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(142, 20);
            this.textBox_address.TabIndex = 36;
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(169, 239);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(38, 13);
            this.label_address.TabIndex = 35;
            this.label_address.Text = "Адрес";
            // 
            // textBox_egn
            // 
            this.textBox_egn.Location = new System.Drawing.Point(286, 213);
            this.textBox_egn.Name = "textBox_egn";
            this.textBox_egn.Size = new System.Drawing.Size(142, 20);
            this.textBox_egn.TabIndex = 34;
            // 
            // label_egn
            // 
            this.label_egn.AutoSize = true;
            this.label_egn.Location = new System.Drawing.Point(168, 213);
            this.label_egn.Name = "label_egn";
            this.label_egn.Size = new System.Drawing.Size(28, 13);
            this.label_egn.TabIndex = 33;
            this.label_egn.Text = "ЕГН";
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(286, 184);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(142, 20);
            this.textBox_surname.TabIndex = 32;
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Location = new System.Drawing.Point(168, 187);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(109, 13);
            this.label_surname.TabIndex = 31;
            this.label_surname.Text = "Фамилия на клиент";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(286, 156);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(142, 20);
            this.textBox_name.TabIndex = 30;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(168, 159);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(82, 13);
            this.label_name.TabIndex = 29;
            this.label_name.Text = "Име на клиент";
            // 
            // label_add
            // 
            this.label_add.AutoSize = true;
            this.label_add.Location = new System.Drawing.Point(225, 123);
            this.label_add.Name = "label_add";
            this.label_add.Size = new System.Drawing.Size(126, 13);
            this.label_add.TabIndex = 28;
            this.label_add.Text = "Редактиране на клиент";
            this.label_add.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 473);
            this.Controls.Add(this.button_edit);
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
            this.Name = "FormEdit";
            this.Text = "FormEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Label label_mail;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.TextBox textBox_egn;
        private System.Windows.Forms.Label label_egn;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_add;
    }
}