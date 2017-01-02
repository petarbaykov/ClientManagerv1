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
            this.textBox_search_name.Size = new System.Drawing.Size(182, 20);
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
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 68);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_search_name);
            this.Controls.Add(this.label1);
            this.Name = "SearchForm";
            this.Text = "Търси";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_search_name;
        private System.Windows.Forms.Button button_search;
    }
}