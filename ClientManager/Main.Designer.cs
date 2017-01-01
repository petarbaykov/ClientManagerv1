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
            this.функцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.клиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.търсенеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изстриванеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.извличанеНаИнформацяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_add = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.функцииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // функцииToolStripMenuItem
            // 
            this.функцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_menu,
            this.клиToolStripMenuItem,
            this.търсенеToolStripMenuItem,
            this.изстриванеToolStripMenuItem,
            this.извличанеНаИнформацяToolStripMenuItem});
            this.функцииToolStripMenuItem.Name = "функцииToolStripMenuItem";
            this.функцииToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.функцииToolStripMenuItem.Text = "Клиенти";
            this.функцииToolStripMenuItem.Click += new System.EventHandler(this.функцииToolStripMenuItem_Click);
            // 
            // add_menu
            // 
            this.add_menu.Name = "add_menu";
            this.add_menu.Size = new System.Drawing.Size(218, 22);
            this.add_menu.Text = "Добаване";
            this.add_menu.Click += new System.EventHandler(this.add_menu_Click);
            // 
            // клиToolStripMenuItem
            // 
            this.клиToolStripMenuItem.Name = "клиToolStripMenuItem";
            this.клиToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.клиToolStripMenuItem.Text = "Редактиране";
            // 
            // търсенеToolStripMenuItem
            // 
            this.търсенеToolStripMenuItem.Name = "търсенеToolStripMenuItem";
            this.търсенеToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.търсенеToolStripMenuItem.Text = "Търсене";
            // 
            // изстриванеToolStripMenuItem
            // 
            this.изстриванеToolStripMenuItem.Name = "изстриванеToolStripMenuItem";
            this.изстриванеToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.изстриванеToolStripMenuItem.Text = "Изтриване";
            // 
            // извличанеНаИнформацяToolStripMenuItem
            // 
            this.извличанеНаИнформацяToolStripMenuItem.Name = "извличанеНаИнформацяToolStripMenuItem";
            this.извличанеНаИнформацяToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.извличанеНаИнформацяToolStripMenuItem.Text = "Извличане на информаця";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(66, 27);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(157, 45);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Добавяне на нов клиент";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
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
        private System.Windows.Forms.ToolStripMenuItem функцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add_menu;
        private System.Windows.Forms.ToolStripMenuItem клиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem търсенеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изстриванеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem извличанеНаИнформацяToolStripMenuItem;
        private System.Windows.Forms.Button button_add;
    }
}

