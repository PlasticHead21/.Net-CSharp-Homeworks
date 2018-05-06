namespace LinqQuery
{
    partial class DataViewForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CDGrid = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfAllArtistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllCountriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showListOfAlbumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTotalCostOfAlbumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showListOfCompaniesAndCountOfAlbumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTheMostTalantedProducerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCountOfSongsInPeriodOf1988To1990ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.producerThatGetBonusLastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.producersGrid = new System.Windows.Forms.DataGridView();
            this.queryGrid = new System.Windows.Forms.DataGridView();
            this.showTheCheapestAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showSortedInfoAboutAllAlbumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.CDGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.producersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CDGrid
            // 
            this.CDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CDGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.CDGrid.Location = new System.Drawing.Point(0, 28);
            this.CDGrid.Margin = new System.Windows.Forms.Padding(4);
            this.CDGrid.Name = "CDGrid";
            this.CDGrid.Size = new System.Drawing.Size(1145, 185);
            this.CDGrid.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.queriesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1145, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemOpen,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Name = "menuItemOpen";
            this.menuItemOpen.Size = new System.Drawing.Size(120, 26);
            this.menuItemOpen.Text = "Open";
            this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // queriesToolStripMenuItem
            // 
            this.queriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfAllArtistToolStripMenuItem,
            this.showAllCountriesToolStripMenuItem,
            this.showListOfAlbumsToolStripMenuItem,
            this.showTotalCostOfAlbumsToolStripMenuItem,
            this.showListOfCompaniesAndCountOfAlbumsToolStripMenuItem,
            this.showTheMostTalantedProducerToolStripMenuItem,
            this.showCountOfSongsInPeriodOf1988To1990ToolStripMenuItem,
            this.producerThatGetBonusLastToolStripMenuItem,
            this.showTheCheapestAlbumToolStripMenuItem,
            this.showSortedInfoAboutAllAlbumsToolStripMenuItem});
            this.queriesToolStripMenuItem.Name = "queriesToolStripMenuItem";
            this.queriesToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.queriesToolStripMenuItem.Text = "Queries";
            // 
            // listOfAllArtistToolStripMenuItem
            // 
            this.listOfAllArtistToolStripMenuItem.Name = "listOfAllArtistToolStripMenuItem";
            this.listOfAllArtistToolStripMenuItem.Size = new System.Drawing.Size(393, 26);
            this.listOfAllArtistToolStripMenuItem.Text = "List of all artist";
            this.listOfAllArtistToolStripMenuItem.Click += new System.EventHandler(this.listOfAllArtistToolStripMenuItem_Click);
            // 
            // showAllCountriesToolStripMenuItem
            // 
            this.showAllCountriesToolStripMenuItem.Name = "showAllCountriesToolStripMenuItem";
            this.showAllCountriesToolStripMenuItem.Size = new System.Drawing.Size(393, 26);
            this.showAllCountriesToolStripMenuItem.Text = "Show all countries";
            this.showAllCountriesToolStripMenuItem.Click += new System.EventHandler(this.showAllCountriesToolStripMenuItem_Click);
            // 
            // showListOfAlbumsToolStripMenuItem
            // 
            this.showListOfAlbumsToolStripMenuItem.Name = "showListOfAlbumsToolStripMenuItem";
            this.showListOfAlbumsToolStripMenuItem.Size = new System.Drawing.Size(393, 26);
            this.showListOfAlbumsToolStripMenuItem.Text = "Show list of albums";
            this.showListOfAlbumsToolStripMenuItem.Click += new System.EventHandler(this.showListOfAlbumsToolStripMenuItem_Click);
            // 
            // showTotalCostOfAlbumsToolStripMenuItem
            // 
            this.showTotalCostOfAlbumsToolStripMenuItem.Name = "showTotalCostOfAlbumsToolStripMenuItem";
            this.showTotalCostOfAlbumsToolStripMenuItem.Size = new System.Drawing.Size(393, 26);
            this.showTotalCostOfAlbumsToolStripMenuItem.Text = "Show total cost of albums";
            this.showTotalCostOfAlbumsToolStripMenuItem.Click += new System.EventHandler(this.showTotalCostOfAlbumsToolStripMenuItem_Click);
            // 
            // showListOfCompaniesAndCountOfAlbumsToolStripMenuItem
            // 
            this.showListOfCompaniesAndCountOfAlbumsToolStripMenuItem.Name = "showListOfCompaniesAndCountOfAlbumsToolStripMenuItem";
            this.showListOfCompaniesAndCountOfAlbumsToolStripMenuItem.Size = new System.Drawing.Size(393, 26);
            this.showListOfCompaniesAndCountOfAlbumsToolStripMenuItem.Text = "Show list of companies and count of albums";
            this.showListOfCompaniesAndCountOfAlbumsToolStripMenuItem.Click += new System.EventHandler(this.showListOfCompaniesAndCountOfAlbumsToolStripMenuItem_Click);
            // 
            // showTheMostTalantedProducerToolStripMenuItem
            // 
            this.showTheMostTalantedProducerToolStripMenuItem.Name = "showTheMostTalantedProducerToolStripMenuItem";
            this.showTheMostTalantedProducerToolStripMenuItem.Size = new System.Drawing.Size(393, 26);
            this.showTheMostTalantedProducerToolStripMenuItem.Text = "Show the most talanted producer";
            this.showTheMostTalantedProducerToolStripMenuItem.Click += new System.EventHandler(this.showTheMostTalantedProducerToolStripMenuItem_Click);
            // 
            // showCountOfSongsInPeriodOf1988To1990ToolStripMenuItem
            // 
            this.showCountOfSongsInPeriodOf1988To1990ToolStripMenuItem.Name = "showCountOfSongsInPeriodOf1988To1990ToolStripMenuItem";
            this.showCountOfSongsInPeriodOf1988To1990ToolStripMenuItem.Size = new System.Drawing.Size(393, 26);
            this.showCountOfSongsInPeriodOf1988To1990ToolStripMenuItem.Text = "Show count of songs in period of 1988 to 1990";
            this.showCountOfSongsInPeriodOf1988To1990ToolStripMenuItem.Click += new System.EventHandler(this.showCountOfSongsInPeriodOf1988To1990ToolStripMenuItem_Click);
            // 
            // producerThatGetBonusLastToolStripMenuItem
            // 
            this.producerThatGetBonusLastToolStripMenuItem.Name = "producerThatGetBonusLastToolStripMenuItem";
            this.producerThatGetBonusLastToolStripMenuItem.Size = new System.Drawing.Size(393, 26);
            this.producerThatGetBonusLastToolStripMenuItem.Text = "Producer that get bonus last";
            this.producerThatGetBonusLastToolStripMenuItem.Click += new System.EventHandler(this.producerThatGetBonusLastToolStripMenuItem_Click);
            // 
            // producersGrid
            // 
            this.producersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.producersGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.producersGrid.Location = new System.Drawing.Point(0, 213);
            this.producersGrid.Margin = new System.Windows.Forms.Padding(4);
            this.producersGrid.Name = "producersGrid";
            this.producersGrid.Size = new System.Drawing.Size(1145, 185);
            this.producersGrid.TabIndex = 2;
            // 
            // queryGrid
            // 
            this.queryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.queryGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.queryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queryGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.queryGrid.Location = new System.Drawing.Point(0, 398);
            this.queryGrid.Margin = new System.Windows.Forms.Padding(4);
            this.queryGrid.Name = "queryGrid";
            this.queryGrid.Size = new System.Drawing.Size(1145, 185);
            this.queryGrid.TabIndex = 3;
            // 
            // showTheCheapestAlbumToolStripMenuItem
            // 
            this.showTheCheapestAlbumToolStripMenuItem.Name = "showTheCheapestAlbumToolStripMenuItem";
            this.showTheCheapestAlbumToolStripMenuItem.Size = new System.Drawing.Size(393, 26);
            this.showTheCheapestAlbumToolStripMenuItem.Text = "Show the cheapest album";
            this.showTheCheapestAlbumToolStripMenuItem.Click += new System.EventHandler(this.showTheCheapestAlbumToolStripMenuItem_Click);
            // 
            // showSortedInfoAboutAllAlbumsToolStripMenuItem
            // 
            this.showSortedInfoAboutAllAlbumsToolStripMenuItem.Name = "showSortedInfoAboutAllAlbumsToolStripMenuItem";
            this.showSortedInfoAboutAllAlbumsToolStripMenuItem.Size = new System.Drawing.Size(393, 26);
            this.showSortedInfoAboutAllAlbumsToolStripMenuItem.Text = "Show sorted info about all albums";
            this.showSortedInfoAboutAllAlbumsToolStripMenuItem.Click += new System.EventHandler(this.showSortedInfoAboutAllAlbumsToolStripMenuItem_Click);
            // 
            // DataViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 580);
            this.Controls.Add(this.queryGrid);
            this.Controls.Add(this.producersGrid);
            this.Controls.Add(this.CDGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DataViewForm";
            this.Text = "LINQ Queries Window";
            ((System.ComponentModel.ISupportInitialize)(this.CDGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.producersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CDGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queriesToolStripMenuItem;
        private System.Windows.Forms.DataGridView producersGrid;
        private System.Windows.Forms.DataGridView queryGrid;
        private System.Windows.Forms.ToolStripMenuItem listOfAllArtistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllCountriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showListOfAlbumsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTotalCostOfAlbumsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showListOfCompaniesAndCountOfAlbumsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTheMostTalantedProducerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCountOfSongsInPeriodOf1988To1990ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem producerThatGetBonusLastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTheCheapestAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showSortedInfoAboutAllAlbumsToolStripMenuItem;
    }
}

