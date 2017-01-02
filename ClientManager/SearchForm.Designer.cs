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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_search_name = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.listBox_results = new System.Windows.Forms.ListBox();
            this.label_results = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Въведете име и фамилия ";
            // 
            // textBox_search_name
            // 
            this.textBox_search_name.Location = new System.Drawing.Point(160, 13);
            this.textBox_search_name.Name = "textBox_search_name";
            this.textBox_search_name.Size = new System.Drawing.Size(198, 20);
            this.textBox_search_name.TabIndex = 1;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(364, 13);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(97, 23);
            this.button_search.TabIndex = 2;
            this.button_search.Text = "Търси";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // listBox_results
            // 
            this.listBox_results.FormattingEnabled = true;
            this.listBox_results.Location = new System.Drawing.Point(16, 62);
            this.listBox_results.Name = "listBox_results";
            this.listBox_results.Size = new System.Drawing.Size(445, 95);
            this.listBox_results.TabIndex = 3;
            // 
            // label_results
            // 
            this.label_results.AutoSize = true;
            this.label_results.Location = new System.Drawing.Point(16, 43);
            this.label_results.Name = "label_results";
            this.label_results.Size = new System.Drawing.Size(0, 13);
            this.label_results.TabIndex = 4;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 209);
            this.Controls.Add(this.label_results);
            this.Controls.Add(this.listBox_results);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_search_name);
            this.Controls.Add(this.label1);
            this.Name = "SearchForm";
            this.Text = "Търси";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_search_name;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.ListBox listBox_results;
        private System.Windows.Forms.Label label_results;
    }
}