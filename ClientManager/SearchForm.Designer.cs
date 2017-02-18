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
            this.listBox_results = new System.Windows.Forms.ListBox();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_results = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // listBox_results
            // 
            this.listBox_results.FormattingEnabled = true;
            this.listBox_results.Location = new System.Drawing.Point(420, 26);
            this.listBox_results.Name = "listBox_results";
            this.listBox_results.Size = new System.Drawing.Size(75, 43);
            this.listBox_results.TabIndex = 7;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(488, 420);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(97, 23);
            this.button_search.TabIndex = 6;
            this.button_search.Text = "Търси";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Visible = false;
            // 
            // textBox_search_name
            // 
            this.textBox_search_name.Location = new System.Drawing.Point(220, 161);
            this.textBox_search_name.Name = "textBox_search_name";
            this.textBox_search_name.Size = new System.Drawing.Size(198, 20);
            this.textBox_search_name.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Въведете име и фамилия ";
            // 
            // label_results
            // 
            this.label_results.AutoSize = true;
            this.label_results.Location = new System.Drawing.Point(145, 104);
            this.label_results.Name = "label_results";
            this.label_results.Size = new System.Drawing.Size(140, 13);
            this.label_results.TabIndex = 8;
            this.label_results.Text = "Въведете име и фамилия ";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(437, 161);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(97, 23);
            this.metroButton1.TabIndex = 9;
            this.metroButton1.Text = "Търси";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(76, 203);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(458, 173);
            this.metroPanel1.TabIndex = 11;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 466);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.label_results);
            this.Controls.Add(this.listBox_results);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_search_name);
            this.Controls.Add(this.label1);
            this.Name = "SearchForm";
            this.Text = "Търсене на клиенти";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_results;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_results;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}