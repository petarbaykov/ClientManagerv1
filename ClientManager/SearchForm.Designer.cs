namespace ClientManager
{
    partial class SearchForm
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
            this.components = new System.ComponentModel.Container();
            this.listBox_results = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_results = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.textBox_search_name = new MetroFramework.Controls.MetroTextBox();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_results
            // 
            this.listBox_results.FormattingEnabled = true;
            this.listBox_results.Location = new System.Drawing.Point(420, 26);
            this.listBox_results.Name = "listBox_results";
            this.listBox_results.Size = new System.Drawing.Size(10, 4);
            this.listBox_results.TabIndex = 7;
            this.listBox_results.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Въведете име и фамилия ";
            this.label1.Visible = false;
            // 
            // label_results
            // 
            this.label_results.AutoSize = true;
            this.label_results.Location = new System.Drawing.Point(331, 45);
            this.label_results.Name = "label_results";
            this.label_results.Size = new System.Drawing.Size(0, 13);
            this.label_results.TabIndex = 8;
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Location = new System.Drawing.Point(15, 83);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(213, 36);
            this.metroButton1.TabIndex = 9;
            this.metroButton1.Text = "ТЪРСИ";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.AutoScroll = true;
            this.metroPanel1.HorizontalScrollbar = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(334, 72);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(219, 223);
            this.metroPanel1.TabIndex = 11;
            this.metroPanel1.VerticalScrollbar = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.textBox_search_name);
            this.metroPanel2.Controls.Add(this.metroButton1);
            this.metroPanel2.Controls.Add(this.label1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(23, 63);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(257, 141);
            this.metroPanel2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroPanel2.TabIndex = 12;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(15, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(164, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Въведете име и фамилия";
            // 
            // textBox_search_name
            // 
            this.textBox_search_name.Icon = global::ClientManager.Properties.Resources._1487445882_icon_111_search;
            this.textBox_search_name.Lines = new string[0];
            this.textBox_search_name.Location = new System.Drawing.Point(15, 54);
            this.textBox_search_name.MaxLength = 32767;
            this.textBox_search_name.Name = "textBox_search_name";
            this.textBox_search_name.PasswordChar = '\0';
            this.textBox_search_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_search_name.SelectedText = "";
            this.textBox_search_name.Size = new System.Drawing.Size(213, 23);
            this.textBox_search_name.TabIndex = 10;
            this.textBox_search_name.UseSelectable = true;
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(420, 195);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(49, 45);
            this.metroProgressSpinner1.TabIndex = 13;
            this.metroProgressSpinner1.UseSelectable = true;
            this.metroProgressSpinner1.Value = 40;
            this.metroProgressSpinner1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 466);
            this.Controls.Add(this.metroProgressSpinner1);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.listBox_results);
            this.Controls.Add(this.label_results);
            this.Name = "SearchForm";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Търсене на клиенти";
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_results;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_results;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroTextBox textBox_search_name;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}