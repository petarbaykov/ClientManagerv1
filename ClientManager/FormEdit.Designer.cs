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
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_egn = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(172, 449);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(256, 23);
            this.button_edit.TabIndex = 41;
            this.button_edit.Text = "Редактиране";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Visible = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click_1);
            // 
            // textBox_mail
            // 
            this.textBox_mail.Location = new System.Drawing.Point(118, 352);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(142, 20);
            this.textBox_mail.TabIndex = 39;
            // 
            // textBox_number
            // 
            this.textBox_number.Location = new System.Drawing.Point(318, 216);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(142, 20);
            this.textBox_number.TabIndex = 38;
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(118, 294);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(342, 20);
            this.textBox_address.TabIndex = 36;
            // 
            // textBox_egn
            // 
            this.textBox_egn.Location = new System.Drawing.Point(118, 216);
            this.textBox_egn.Name = "textBox_egn";
            this.textBox_egn.Size = new System.Drawing.Size(142, 20);
            this.textBox_egn.TabIndex = 34;
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(318, 133);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(142, 20);
            this.textBox_surname.TabIndex = 32;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(118, 133);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(142, 20);
            this.textBox_name.TabIndex = 30;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(118, 100);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(112, 19);
            this.metroLabel1.TabIndex = 42;
            this.metroLabel1.Text = "Име на клиент";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(318, 99);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(129, 19);
            this.metroLabel2.TabIndex = 43;
            this.metroLabel2.Text = "Фамилия на клиент";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(118, 179);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(34, 19);
            this.metroLabel3.TabIndex = 44;
            this.metroLabel3.Text = "ЕГН";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(318, 179);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(69, 19);
            this.metroLabel4.TabIndex = 45;
            this.metroLabel4.Text = "Телефон";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(118, 260);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(52, 19);
            this.metroLabel5.TabIndex = 46;
            this.metroLabel5.Text = "Адрес";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(118, 321);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(56, 19);
            this.metroLabel6.TabIndex = 47;
            this.metroLabel6.Text = "Имейл";
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(172, 401);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(256, 42);
            this.metroButton1.TabIndex = 48;
            this.metroButton1.Text = "РЕДАКТИРАНЕ";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 473);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.textBox_mail);
            this.Controls.Add(this.textBox_number);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.textBox_egn);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.textBox_name);
            this.Name = "FormEdit";
            this.Text = "Редактиране на клиент";
            this.Load += new System.EventHandler(this.FormEdit_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_egn;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.TextBox textBox_name;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}