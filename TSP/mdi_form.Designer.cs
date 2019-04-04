namespace Ocenka_mer_svyzei
{
    partial class mdi_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdi_form));
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.main_menu = new System.Windows.Forms.MenuStrip();
            this.File_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Exit_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.select_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точечнобисериальныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бисериальныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ранговобисериальныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тетрахорическийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.определитьПрименимыйМетодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.произведениеМоментовПирсонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Help_About_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.About_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.спирменаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.New_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Help_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_menu
            // 
            this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_MenuItem,
            this.select_MenuItem,
            this.Help_About_MenuItem});
            this.main_menu.Location = new System.Drawing.Point(0, 0);
            this.main_menu.Name = "main_menu";
            this.main_menu.Size = new System.Drawing.Size(1012, 24);
            this.main_menu.TabIndex = 9;
            this.main_menu.Text = "menuStrip1";
            // 
            // File_MenuItem
            // 
            this.File_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New_MenuItem,
            this.toolStripSeparator1,
            this.Exit_MenuItem});
            this.File_MenuItem.Name = "File_MenuItem";
            this.File_MenuItem.ShortcutKeyDisplayString = "";
            this.File_MenuItem.Size = new System.Drawing.Size(48, 20);
            this.File_MenuItem.Tag = "";
            this.File_MenuItem.Text = "Файл";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // Exit_MenuItem
            // 
            this.Exit_MenuItem.Name = "Exit_MenuItem";
            this.Exit_MenuItem.Size = new System.Drawing.Size(152, 22);
            this.Exit_MenuItem.Text = "Выход";
            this.Exit_MenuItem.Click += new System.EventHandler(this.Exit_MenuItem_Click);
            // 
            // select_MenuItem
            // 
            this.select_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.определитьПрименимыйМетодToolStripMenuItem,
            this.произведениеМоментовПирсонаToolStripMenuItem,
            this.спирменаToolStripMenuItem,
            this.точечнобисериальныToolStripMenuItem,
            this.бисериальныToolStripMenuItem,
            this.ранговобисериальныйToolStripMenuItem,
            this.тетрахорическийToolStripMenuItem});
            this.select_MenuItem.Name = "select_MenuItem";
            this.select_MenuItem.Size = new System.Drawing.Size(98, 20);
            this.select_MenuItem.Text = "Выбор метода";
            // 
            // точечнобисериальныToolStripMenuItem
            // 
            this.точечнобисериальныToolStripMenuItem.Name = "точечнобисериальныToolStripMenuItem";
            this.точечнобисериальныToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.точечнобисериальныToolStripMenuItem.Text = "Точечно-бисериальный";
            this.точечнобисериальныToolStripMenuItem.Click += new System.EventHandler(this.точечнобисериальныToolStripMenuItem_Click_1);
            // 
            // бисериальныToolStripMenuItem
            // 
            this.бисериальныToolStripMenuItem.Name = "бисериальныToolStripMenuItem";
            this.бисериальныToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.бисериальныToolStripMenuItem.Text = "Бисериальный";
            this.бисериальныToolStripMenuItem.Click += new System.EventHandler(this.бисериальныToolStripMenuItem_Click);
            // 
            // ранговобисериальныйToolStripMenuItem
            // 
            this.ранговобисериальныйToolStripMenuItem.Name = "ранговобисериальныйToolStripMenuItem";
            this.ранговобисериальныйToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.ранговобисериальныйToolStripMenuItem.Text = "Рангово-бисериальный";
            this.ранговобисериальныйToolStripMenuItem.Click += new System.EventHandler(this.ранговобисериальныйToolStripMenuItem_Click);
            // 
            // тетрахорическийToolStripMenuItem
            // 
            this.тетрахорическийToolStripMenuItem.Name = "тетрахорическийToolStripMenuItem";
            this.тетрахорическийToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.тетрахорическийToolStripMenuItem.Text = "Тетрахорический";
            this.тетрахорическийToolStripMenuItem.Click += new System.EventHandler(this.тетрахорическийToolStripMenuItem_Click);
            // 
            // определитьПрименимыйМетодToolStripMenuItem
            // 
            this.определитьПрименимыйМетодToolStripMenuItem.Name = "определитьПрименимыйМетодToolStripMenuItem";
            this.определитьПрименимыйМетодToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.определитьПрименимыйМетодToolStripMenuItem.Text = "Определить применимый метод";
            this.определитьПрименимыйМетодToolStripMenuItem.Click += new System.EventHandler(this.определитьПрименимыйМетодToolStripMenuItem_Click);
            // 
            // произведениеМоментовПирсонаToolStripMenuItem
            // 
            this.произведениеМоментовПирсонаToolStripMenuItem.Name = "произведениеМоментовПирсонаToolStripMenuItem";
            this.произведениеМоментовПирсонаToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.произведениеМоментовПирсонаToolStripMenuItem.Text = "Произведение моментов Пирсона";
            this.произведениеМоментовПирсонаToolStripMenuItem.Click += new System.EventHandler(this.произведениеМоментовПирсонаToolStripMenuItem_Click);
            // 
            // Help_About_MenuItem
            // 
            this.Help_About_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Help_MenuItem,
            this.About_MenuItem});
            this.Help_About_MenuItem.Name = "Help_About_MenuItem";
            this.Help_About_MenuItem.Size = new System.Drawing.Size(68, 20);
            this.Help_About_MenuItem.Text = "Помощь";
            // 
            // About_MenuItem
            // 
            this.About_MenuItem.Name = "About_MenuItem";
            this.About_MenuItem.Size = new System.Drawing.Size(158, 22);
            this.About_MenuItem.Text = "О программе...";
            this.About_MenuItem.Click += new System.EventHandler(this.About_MenuItem_Click);
            // 
            // спирменаToolStripMenuItem
            // 
            this.спирменаToolStripMenuItem.Name = "спирменаToolStripMenuItem";
            this.спирменаToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.спирменаToolStripMenuItem.Text = "Ранговая корреляция Спирмена";
            this.спирменаToolStripMenuItem.Click += new System.EventHandler(this.спирменаToolStripMenuItem_Click);
            // 
            // New_MenuItem
            // 
            this.New_MenuItem.Image = global::Ocenka_mer_svyzei.Properties.Resources.UtilityText;
            this.New_MenuItem.Name = "New_MenuItem";
            this.New_MenuItem.ShortcutKeyDisplayString = "";
            this.New_MenuItem.Size = new System.Drawing.Size(152, 22);
            this.New_MenuItem.Tag = "";
            this.New_MenuItem.Text = "Создать";
            this.New_MenuItem.Click += new System.EventHandler(this.New_MenuItem_Click);
            // 
            // Help_MenuItem
            // 
            this.Help_MenuItem.Image = global::Ocenka_mer_svyzei.Properties.Resources.help;
            this.Help_MenuItem.Name = "Help_MenuItem";
            this.Help_MenuItem.Size = new System.Drawing.Size(158, 22);
            this.Help_MenuItem.Text = "Справка";
            this.Help_MenuItem.Click += new System.EventHandler(this.Help_MenuItem_Click);
            // 
            // mdi_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 676);
            this.Controls.Add(this.main_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "mdi_form";
            this.Text = "Оценка мер связей числовых статистических данных различной природы";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.main_menu.ResumeLayout(false);
            this.main_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.SaveFileDialog saveFD;
        private System.Windows.Forms.MenuStrip main_menu;
        private System.Windows.Forms.ToolStripMenuItem File_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem New_MenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Exit_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem select_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem бисериальныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ранговобисериальныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тетрахорическийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Help_About_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Help_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem About_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem точечнобисериальныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem определитьПрименимыйМетодToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem произведениеМоментовПирсонаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem спирменаToolStripMenuItem;
    }
}

