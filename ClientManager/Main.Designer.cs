namespace ClientManager
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.търсенеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изтриванеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.извличанеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_add = new System.Windows.Forms.Button();
            this.listBox_clients = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.търсенеToolStripMenuItem,
            this.изтриванеToolStripMenuItem,
            this.извличанеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(406, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.AddToolStripMenuItem.Text = "Добавяне";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.EditToolStripMenuItem.Text = "Редактиране";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // търсенеToolStripMenuItem
            // 
            this.търсенеToolStripMenuItem.Name = "търсенеToolStripMenuItem";
            this.търсенеToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.търсенеToolStripMenuItem.Text = "Търсене";
            // 
            // изтриванеToolStripMenuItem
            // 
            this.изтриванеToolStripMenuItem.Name = "изтриванеToolStripMenuItem";
            this.изтриванеToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.изтриванеToolStripMenuItem.Text = "Изтриване";
            // 
            // извличанеToolStripMenuItem
            // 
            this.извличанеToolStripMenuItem.Name = "извличанеToolStripMenuItem";
            this.извличанеToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.извличанеToolStripMenuItem.Text = "Извличане";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(110, 207);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(157, 45);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Добавяне на нов клиент";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Visible = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // listBox_clients
            // 
            this.listBox_clients.FormattingEnabled = true;
            this.listBox_clients.Location = new System.Drawing.Point(12, 37);
            this.listBox_clients.Name = "listBox_clients";
            this.listBox_clients.Size = new System.Drawing.Size(294, 160);
            this.listBox_clients.TabIndex = 2;
            this.listBox_clients.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 264);
            this.Controls.Add(this.listBox_clients);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem търсенеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изтриванеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem извличанеToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox_clients;
    }
}

