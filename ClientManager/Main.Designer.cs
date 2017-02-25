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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_clients = new System.Windows.Forms.ListBox();
            this.button_add = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изтриванеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.извличанеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(114, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Списък с клиенти";
            // 
            // listBox_clients
            // 
            this.listBox_clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_clients.FormattingEnabled = true;
            this.listBox_clients.ItemHeight = 20;
            this.listBox_clients.Location = new System.Drawing.Point(36, 166);
            this.listBox_clients.Name = "listBox_clients";
            this.listBox_clients.Size = new System.Drawing.Size(317, 244);
            this.listBox_clients.TabIndex = 6;
            this.listBox_clients.SelectedIndexChanged += new System.EventHandler(this.listBox_clients_SelectedIndexChanged);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(380, 365);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(157, 45);
            this.button_add.TabIndex = 5;
            this.button_add.Text = "Добавяне на нов клиент";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Visible = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.изтриванеToolStripMenuItem,
            this.извличанеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(572, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.AddToolStripMenuItem.Text = "Добавяне";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click_1);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.EditToolStripMenuItem.Text = "Редактиране";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click_1);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.searchToolStripMenuItem.Text = "Търсене";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click_1);
            // 
            // изтриванеToolStripMenuItem
            // 
            this.изтриванеToolStripMenuItem.Name = "изтриванеToolStripMenuItem";
            this.изтриванеToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.изтриванеToolStripMenuItem.Text = "Изтриване";
            this.изтриванеToolStripMenuItem.Click += new System.EventHandler(this.изтриванеToolStripMenuItem_Click);
            // 
            // извличанеToolStripMenuItem
            // 
            this.извличанеToolStripMenuItem.Name = "извличанеToolStripMenuItem";
            this.извличанеToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.извличанеToolStripMenuItem.Text = "Извличане";
            this.извличанеToolStripMenuItem.Click += new System.EventHandler(this.извличанеToolStripMenuItem_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(385, 124);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(168, 70);
            this.metroTile1.TabIndex = 8;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile1.TileImage = global::ClientManager.Properties.Resources._1487440201_photo;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.AutoScroll = true;
            this.metroPanel1.HorizontalScrollbar = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(385, 334);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(32, 25);
            this.metroPanel1.TabIndex = 9;
            this.metroPanel1.VerticalScrollbar = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 470);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.listBox_clients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.Text = "Контролен панел";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_clients;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изтриванеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem извличанеToolStripMenuItem;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}