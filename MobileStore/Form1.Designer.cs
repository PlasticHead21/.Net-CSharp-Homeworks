namespace MobileStore
{
    partial class Form1
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
            this.lbx_ListOfPhones = new System.Windows.Forms.ListBox();
            this.gb_ListOfPhones = new System.Windows.Forms.GroupBox();
            this.btn_LoadFromFile = new System.Windows.Forms.Button();
            this.btn_SaveInFile = new System.Windows.Forms.Button();
            this.btn_ClearList = new System.Windows.Forms.Button();
            this.btn_DelPhone = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_InfoAboutPhone = new System.Windows.Forms.TabPage();
            this.gbx_Options = new System.Windows.Forms.GroupBox();
            this.lbx_Options = new System.Windows.Forms.ListBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Processor = new System.Windows.Forms.Label();
            this.lbl_OS = new System.Windows.Forms.Label();
            this.lbl_Model = new System.Windows.Forms.Label();
            this.tbx_OS = new System.Windows.Forms.TextBox();
            this.tbx_Price = new System.Windows.Forms.TextBox();
            this.tbx_Processor = new System.Windows.Forms.TextBox();
            this.tbx_Model = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tp_InfoRedact = new System.Windows.Forms.TabPage();
            this.gbx_redact = new System.Windows.Forms.GroupBox();
            this.btn_AddNewPhone = new System.Windows.Forms.Button();
            this.btn_ClearField = new System.Windows.Forms.Button();
            this.btn_DeleteOption = new System.Windows.Forms.Button();
            this.btn_AddOption = new System.Windows.Forms.Button();
            this.lbl_NameOfOption = new System.Windows.Forms.Label();
            this.tbx_NameOfOption = new System.Windows.Forms.TextBox();
            this.btn_SaveChanges = new System.Windows.Forms.Button();
            this.chLbx = new System.Windows.Forms.CheckedListBox();
            this.lbl_Picture = new System.Windows.Forms.Label();
            this.tbx_Picture = new System.Windows.Forms.TextBox();
            this.lbl_PriceR = new System.Windows.Forms.Label();
            this.lbl_ProcessorR = new System.Windows.Forms.Label();
            this.lbl_OSR = new System.Windows.Forms.Label();
            this.lbl_ModelR = new System.Windows.Forms.Label();
            this.tbx_OSR = new System.Windows.Forms.TextBox();
            this.tbx_PriceR = new System.Windows.Forms.TextBox();
            this.tbx_ProcessorR = new System.Windows.Forms.TextBox();
            this.tbx_ModelR = new System.Windows.Forms.TextBox();
            this.gb_ListOfPhones.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tp_InfoAboutPhone.SuspendLayout();
            this.gbx_Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tp_InfoRedact.SuspendLayout();
            this.gbx_redact.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbx_ListOfPhones
            // 
            this.lbx_ListOfPhones.FormattingEnabled = true;
            this.lbx_ListOfPhones.ItemHeight = 16;
            this.lbx_ListOfPhones.Location = new System.Drawing.Point(6, 21);
            this.lbx_ListOfPhones.Name = "lbx_ListOfPhones";
            this.lbx_ListOfPhones.Size = new System.Drawing.Size(257, 292);
            this.lbx_ListOfPhones.TabIndex = 0;
            this.lbx_ListOfPhones.SelectedIndexChanged += new System.EventHandler(this.lbx_ListOfPhones_SelectedIndexChanged);
            // 
            // gb_ListOfPhones
            // 
            this.gb_ListOfPhones.Controls.Add(this.btn_LoadFromFile);
            this.gb_ListOfPhones.Controls.Add(this.btn_SaveInFile);
            this.gb_ListOfPhones.Controls.Add(this.btn_ClearList);
            this.gb_ListOfPhones.Controls.Add(this.lbx_ListOfPhones);
            this.gb_ListOfPhones.Controls.Add(this.btn_DelPhone);
            this.gb_ListOfPhones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_ListOfPhones.Location = new System.Drawing.Point(12, 12);
            this.gb_ListOfPhones.Name = "gb_ListOfPhones";
            this.gb_ListOfPhones.Size = new System.Drawing.Size(269, 599);
            this.gb_ListOfPhones.TabIndex = 1;
            this.gb_ListOfPhones.TabStop = false;
            this.gb_ListOfPhones.Text = "Список телефонов";
            // 
            // btn_LoadFromFile
            // 
            this.btn_LoadFromFile.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_LoadFromFile.Location = new System.Drawing.Point(139, 382);
            this.btn_LoadFromFile.Name = "btn_LoadFromFile";
            this.btn_LoadFromFile.Size = new System.Drawing.Size(130, 57);
            this.btn_LoadFromFile.TabIndex = 4;
            this.btn_LoadFromFile.Text = "Загрузить из файла";
            this.btn_LoadFromFile.UseVisualStyleBackColor = true;
            this.btn_LoadFromFile.Click += new System.EventHandler(this.btn_LoadFromFile_Click);
            // 
            // btn_SaveInFile
            // 
            this.btn_SaveInFile.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_SaveInFile.Location = new System.Drawing.Point(6, 382);
            this.btn_SaveInFile.Name = "btn_SaveInFile";
            this.btn_SaveInFile.Size = new System.Drawing.Size(130, 57);
            this.btn_SaveInFile.TabIndex = 3;
            this.btn_SaveInFile.Text = "Сохранить в файл";
            this.btn_SaveInFile.UseVisualStyleBackColor = true;
            this.btn_SaveInFile.Click += new System.EventHandler(this.btn_SaveInFile_Click);
            // 
            // btn_ClearList
            // 
            this.btn_ClearList.Location = new System.Drawing.Point(139, 319);
            this.btn_ClearList.Name = "btn_ClearList";
            this.btn_ClearList.Size = new System.Drawing.Size(130, 57);
            this.btn_ClearList.TabIndex = 3;
            this.btn_ClearList.Text = "Очистить список";
            this.btn_ClearList.UseVisualStyleBackColor = true;
            this.btn_ClearList.Click += new System.EventHandler(this.btn_ClearList_Click);
            // 
            // btn_DelPhone
            // 
            this.btn_DelPhone.Location = new System.Drawing.Point(6, 319);
            this.btn_DelPhone.Name = "btn_DelPhone";
            this.btn_DelPhone.Size = new System.Drawing.Size(130, 57);
            this.btn_DelPhone.TabIndex = 2;
            this.btn_DelPhone.Text = "Удалить телефон ";
            this.btn_DelPhone.UseVisualStyleBackColor = true;
            this.btn_DelPhone.Click += new System.EventHandler(this.btn_DelPhone_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_InfoAboutPhone);
            this.tabControl1.Controls.Add(this.tp_InfoRedact);
            this.tabControl1.Location = new System.Drawing.Point(287, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(449, 599);
            this.tabControl1.TabIndex = 2;
            // 
            // tp_InfoAboutPhone
            // 
            this.tp_InfoAboutPhone.Controls.Add(this.gbx_Options);
            this.tp_InfoAboutPhone.Controls.Add(this.lbl_Price);
            this.tp_InfoAboutPhone.Controls.Add(this.lbl_Processor);
            this.tp_InfoAboutPhone.Controls.Add(this.lbl_OS);
            this.tp_InfoAboutPhone.Controls.Add(this.lbl_Model);
            this.tp_InfoAboutPhone.Controls.Add(this.tbx_OS);
            this.tp_InfoAboutPhone.Controls.Add(this.tbx_Price);
            this.tp_InfoAboutPhone.Controls.Add(this.tbx_Processor);
            this.tp_InfoAboutPhone.Controls.Add(this.tbx_Model);
            this.tp_InfoAboutPhone.Controls.Add(this.pictureBox1);
            this.tp_InfoAboutPhone.Location = new System.Drawing.Point(4, 25);
            this.tp_InfoAboutPhone.Name = "tp_InfoAboutPhone";
            this.tp_InfoAboutPhone.Padding = new System.Windows.Forms.Padding(3);
            this.tp_InfoAboutPhone.Size = new System.Drawing.Size(441, 570);
            this.tp_InfoAboutPhone.TabIndex = 0;
            this.tp_InfoAboutPhone.Text = "Информация о телефоне";
            this.tp_InfoAboutPhone.UseVisualStyleBackColor = true;
            // 
            // gbx_Options
            // 
            this.gbx_Options.Controls.Add(this.lbx_Options);
            this.gbx_Options.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbx_Options.Location = new System.Drawing.Point(6, 448);
            this.gbx_Options.Name = "gbx_Options";
            this.gbx_Options.Size = new System.Drawing.Size(379, 114);
            this.gbx_Options.TabIndex = 15;
            this.gbx_Options.TabStop = false;
            this.gbx_Options.Text = "Опции:";
            // 
            // lbx_Options
            // 
            this.lbx_Options.FormattingEnabled = true;
            this.lbx_Options.ItemHeight = 16;
            this.lbx_Options.Location = new System.Drawing.Point(6, 16);
            this.lbx_Options.Name = "lbx_Options";
            this.lbx_Options.Size = new System.Drawing.Size(367, 84);
            this.lbx_Options.TabIndex = 0;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.ForeColor = System.Drawing.Color.Red;
            this.lbl_Price.Location = new System.Drawing.Point(7, 405);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(47, 17);
            this.lbl_Price.TabIndex = 14;
            this.lbl_Price.Text = "Цена:";
            // 
            // lbl_Processor
            // 
            this.lbl_Processor.AutoSize = true;
            this.lbl_Processor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Processor.Location = new System.Drawing.Point(7, 379);
            this.lbl_Processor.Name = "lbl_Processor";
            this.lbl_Processor.Size = new System.Drawing.Size(84, 17);
            this.lbl_Processor.TabIndex = 13;
            this.lbl_Processor.Text = "Процессор:";
            // 
            // lbl_OS
            // 
            this.lbl_OS.AutoSize = true;
            this.lbl_OS.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_OS.Location = new System.Drawing.Point(7, 351);
            this.lbl_OS.Name = "lbl_OS";
            this.lbl_OS.Size = new System.Drawing.Size(32, 17);
            this.lbl_OS.TabIndex = 12;
            this.lbl_OS.Text = "ОС:";
            // 
            // lbl_Model
            // 
            this.lbl_Model.AutoSize = true;
            this.lbl_Model.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Model.Location = new System.Drawing.Point(7, 318);
            this.lbl_Model.Name = "lbl_Model";
            this.lbl_Model.Size = new System.Drawing.Size(62, 17);
            this.lbl_Model.TabIndex = 11;
            this.lbl_Model.Text = "Модель:";
            // 
            // tbx_OS
            // 
            this.tbx_OS.Location = new System.Drawing.Point(189, 346);
            this.tbx_OS.Name = "tbx_OS";
            this.tbx_OS.ReadOnly = true;
            this.tbx_OS.Size = new System.Drawing.Size(196, 22);
            this.tbx_OS.TabIndex = 10;
            // 
            // tbx_Price
            // 
            this.tbx_Price.Location = new System.Drawing.Point(189, 402);
            this.tbx_Price.Name = "tbx_Price";
            this.tbx_Price.ReadOnly = true;
            this.tbx_Price.Size = new System.Drawing.Size(196, 22);
            this.tbx_Price.TabIndex = 9;
            // 
            // tbx_Processor
            // 
            this.tbx_Processor.Location = new System.Drawing.Point(189, 374);
            this.tbx_Processor.Name = "tbx_Processor";
            this.tbx_Processor.ReadOnly = true;
            this.tbx_Processor.Size = new System.Drawing.Size(196, 22);
            this.tbx_Processor.TabIndex = 8;
            // 
            // tbx_Model
            // 
            this.tbx_Model.Location = new System.Drawing.Point(189, 318);
            this.tbx_Model.Name = "tbx_Model";
            this.tbx_Model.ReadOnly = true;
            this.tbx_Model.Size = new System.Drawing.Size(196, 22);
            this.tbx_Model.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // tp_InfoRedact
            // 
            this.tp_InfoRedact.Controls.Add(this.gbx_redact);
            this.tp_InfoRedact.Controls.Add(this.lbl_Picture);
            this.tp_InfoRedact.Controls.Add(this.tbx_Picture);
            this.tp_InfoRedact.Controls.Add(this.lbl_PriceR);
            this.tp_InfoRedact.Controls.Add(this.lbl_ProcessorR);
            this.tp_InfoRedact.Controls.Add(this.lbl_OSR);
            this.tp_InfoRedact.Controls.Add(this.lbl_ModelR);
            this.tp_InfoRedact.Controls.Add(this.tbx_OSR);
            this.tp_InfoRedact.Controls.Add(this.tbx_PriceR);
            this.tp_InfoRedact.Controls.Add(this.tbx_ProcessorR);
            this.tp_InfoRedact.Controls.Add(this.tbx_ModelR);
            this.tp_InfoRedact.Location = new System.Drawing.Point(4, 25);
            this.tp_InfoRedact.Name = "tp_InfoRedact";
            this.tp_InfoRedact.Padding = new System.Windows.Forms.Padding(3);
            this.tp_InfoRedact.Size = new System.Drawing.Size(441, 570);
            this.tp_InfoRedact.TabIndex = 1;
            this.tp_InfoRedact.Text = "Редактирование информации";
            this.tp_InfoRedact.UseVisualStyleBackColor = true;
            // 
            // gbx_redact
            // 
            this.gbx_redact.Controls.Add(this.btn_AddNewPhone);
            this.gbx_redact.Controls.Add(this.btn_ClearField);
            this.gbx_redact.Controls.Add(this.btn_DeleteOption);
            this.gbx_redact.Controls.Add(this.btn_AddOption);
            this.gbx_redact.Controls.Add(this.lbl_NameOfOption);
            this.gbx_redact.Controls.Add(this.tbx_NameOfOption);
            this.gbx_redact.Controls.Add(this.btn_SaveChanges);
            this.gbx_redact.Controls.Add(this.chLbx);
            this.gbx_redact.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbx_redact.Location = new System.Drawing.Point(6, 154);
            this.gbx_redact.Name = "gbx_redact";
            this.gbx_redact.Size = new System.Drawing.Size(411, 307);
            this.gbx_redact.TabIndex = 25;
            this.gbx_redact.TabStop = false;
            // 
            // btn_AddNewPhone
            // 
            this.btn_AddNewPhone.ForeColor = System.Drawing.Color.Red;
            this.btn_AddNewPhone.Location = new System.Drawing.Point(204, 237);
            this.btn_AddNewPhone.Name = "btn_AddNewPhone";
            this.btn_AddNewPhone.Size = new System.Drawing.Size(190, 64);
            this.btn_AddNewPhone.TabIndex = 7;
            this.btn_AddNewPhone.Text = "Добавить новый\r\n телефон";
            this.btn_AddNewPhone.UseVisualStyleBackColor = true;
            this.btn_AddNewPhone.Click += new System.EventHandler(this.btn_AddNewPhone_Click);
            // 
            // btn_ClearField
            // 
            this.btn_ClearField.ForeColor = System.Drawing.Color.Red;
            this.btn_ClearField.Location = new System.Drawing.Point(9, 236);
            this.btn_ClearField.Name = "btn_ClearField";
            this.btn_ClearField.Size = new System.Drawing.Size(155, 65);
            this.btn_ClearField.TabIndex = 6;
            this.btn_ClearField.Text = "Очистить поля";
            this.btn_ClearField.UseVisualStyleBackColor = true;
            this.btn_ClearField.Click += new System.EventHandler(this.btn_ClearField_Click);
            // 
            // btn_DeleteOption
            // 
            this.btn_DeleteOption.Location = new System.Drawing.Point(204, 207);
            this.btn_DeleteOption.Name = "btn_DeleteOption";
            this.btn_DeleteOption.Size = new System.Drawing.Size(190, 23);
            this.btn_DeleteOption.TabIndex = 5;
            this.btn_DeleteOption.Text = "Удалить опцию";
            this.btn_DeleteOption.UseVisualStyleBackColor = true;
            this.btn_DeleteOption.Click += new System.EventHandler(this.btn_DeleteOption_Click);
            // 
            // btn_AddOption
            // 
            this.btn_AddOption.Location = new System.Drawing.Point(9, 207);
            this.btn_AddOption.Name = "btn_AddOption";
            this.btn_AddOption.Size = new System.Drawing.Size(155, 23);
            this.btn_AddOption.TabIndex = 4;
            this.btn_AddOption.Text = "Добавить опцию";
            this.btn_AddOption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddOption.UseVisualStyleBackColor = true;
            this.btn_AddOption.Click += new System.EventHandler(this.btn_AddOption_Click);
            // 
            // lbl_NameOfOption
            // 
            this.lbl_NameOfOption.AutoSize = true;
            this.lbl_NameOfOption.ForeColor = System.Drawing.Color.Red;
            this.lbl_NameOfOption.Location = new System.Drawing.Point(6, 187);
            this.lbl_NameOfOption.Name = "lbl_NameOfOption";
            this.lbl_NameOfOption.Size = new System.Drawing.Size(120, 17);
            this.lbl_NameOfOption.TabIndex = 3;
            this.lbl_NameOfOption.Text = "Название опции:";
            // 
            // tbx_NameOfOption
            // 
            this.tbx_NameOfOption.Location = new System.Drawing.Point(204, 182);
            this.tbx_NameOfOption.Name = "tbx_NameOfOption";
            this.tbx_NameOfOption.Size = new System.Drawing.Size(190, 22);
            this.tbx_NameOfOption.TabIndex = 2;
            // 
            // btn_SaveChanges
            // 
            this.btn_SaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_SaveChanges.Location = new System.Drawing.Point(6, 151);
            this.btn_SaveChanges.Name = "btn_SaveChanges";
            this.btn_SaveChanges.Size = new System.Drawing.Size(388, 25);
            this.btn_SaveChanges.TabIndex = 1;
            this.btn_SaveChanges.Text = "Cохранить изменения";
            this.btn_SaveChanges.UseVisualStyleBackColor = true;
            this.btn_SaveChanges.Click += new System.EventHandler(this.btn_SaveChanges_Click);
            // 
            // chLbx
            // 
            this.chLbx.FormattingEnabled = true;
            this.chLbx.Location = new System.Drawing.Point(6, 21);
            this.chLbx.Name = "chLbx";
            this.chLbx.Size = new System.Drawing.Size(388, 123);
            this.chLbx.TabIndex = 0;
            // 
            // lbl_Picture
            // 
            this.lbl_Picture.AutoSize = true;
            this.lbl_Picture.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Picture.Location = new System.Drawing.Point(3, 102);
            this.lbl_Picture.Name = "lbl_Picture";
            this.lbl_Picture.Size = new System.Drawing.Size(75, 17);
            this.lbl_Picture.TabIndex = 24;
            this.lbl_Picture.Text = "Картинка:";
            // 
            // tbx_Picture
            // 
            this.tbx_Picture.Location = new System.Drawing.Point(185, 97);
            this.tbx_Picture.Name = "tbx_Picture";
            this.tbx_Picture.Size = new System.Drawing.Size(196, 22);
            this.tbx_Picture.TabIndex = 23;
            // 
            // lbl_PriceR
            // 
            this.lbl_PriceR.AutoSize = true;
            this.lbl_PriceR.ForeColor = System.Drawing.Color.Red;
            this.lbl_PriceR.Location = new System.Drawing.Point(3, 129);
            this.lbl_PriceR.Name = "lbl_PriceR";
            this.lbl_PriceR.Size = new System.Drawing.Size(47, 17);
            this.lbl_PriceR.TabIndex = 22;
            this.lbl_PriceR.Text = "Цена:";
            // 
            // lbl_ProcessorR
            // 
            this.lbl_ProcessorR.AutoSize = true;
            this.lbl_ProcessorR.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_ProcessorR.Location = new System.Drawing.Point(3, 76);
            this.lbl_ProcessorR.Name = "lbl_ProcessorR";
            this.lbl_ProcessorR.Size = new System.Drawing.Size(84, 17);
            this.lbl_ProcessorR.TabIndex = 21;
            this.lbl_ProcessorR.Text = "Процессор:";
            // 
            // lbl_OSR
            // 
            this.lbl_OSR.AutoSize = true;
            this.lbl_OSR.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_OSR.Location = new System.Drawing.Point(3, 48);
            this.lbl_OSR.Name = "lbl_OSR";
            this.lbl_OSR.Size = new System.Drawing.Size(32, 17);
            this.lbl_OSR.TabIndex = 20;
            this.lbl_OSR.Text = "ОС:";
            // 
            // lbl_ModelR
            // 
            this.lbl_ModelR.AutoSize = true;
            this.lbl_ModelR.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_ModelR.Location = new System.Drawing.Point(3, 15);
            this.lbl_ModelR.Name = "lbl_ModelR";
            this.lbl_ModelR.Size = new System.Drawing.Size(62, 17);
            this.lbl_ModelR.TabIndex = 19;
            this.lbl_ModelR.Text = "Модель:";
            // 
            // tbx_OSR
            // 
            this.tbx_OSR.Location = new System.Drawing.Point(185, 43);
            this.tbx_OSR.Name = "tbx_OSR";
            this.tbx_OSR.Size = new System.Drawing.Size(196, 22);
            this.tbx_OSR.TabIndex = 18;
            // 
            // tbx_PriceR
            // 
            this.tbx_PriceR.Location = new System.Drawing.Point(185, 126);
            this.tbx_PriceR.Name = "tbx_PriceR";
            this.tbx_PriceR.Size = new System.Drawing.Size(196, 22);
            this.tbx_PriceR.TabIndex = 17;
            // 
            // tbx_ProcessorR
            // 
            this.tbx_ProcessorR.Location = new System.Drawing.Point(185, 71);
            this.tbx_ProcessorR.Name = "tbx_ProcessorR";
            this.tbx_ProcessorR.Size = new System.Drawing.Size(196, 22);
            this.tbx_ProcessorR.TabIndex = 16;
            // 
            // tbx_ModelR
            // 
            this.tbx_ModelR.Location = new System.Drawing.Point(185, 15);
            this.tbx_ModelR.Name = "tbx_ModelR";
            this.tbx_ModelR.Size = new System.Drawing.Size(196, 22);
            this.tbx_ModelR.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 673);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gb_ListOfPhones);
            this.Name = "Form1";
            this.Text = "Mobile Phone shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_ListOfPhones.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tp_InfoAboutPhone.ResumeLayout(false);
            this.tp_InfoAboutPhone.PerformLayout();
            this.gbx_Options.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tp_InfoRedact.ResumeLayout(false);
            this.tp_InfoRedact.PerformLayout();
            this.gbx_redact.ResumeLayout(false);
            this.gbx_redact.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_ListOfPhones;
        private System.Windows.Forms.GroupBox gb_ListOfPhones;
        private System.Windows.Forms.Button btn_LoadFromFile;
        private System.Windows.Forms.Button btn_SaveInFile;
        private System.Windows.Forms.Button btn_ClearList;
        private System.Windows.Forms.Button btn_DelPhone;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_InfoAboutPhone;
        private System.Windows.Forms.Label lbl_OS;
        private System.Windows.Forms.Label lbl_Model;
        private System.Windows.Forms.TextBox tbx_OS;
        private System.Windows.Forms.TextBox tbx_Price;
        private System.Windows.Forms.TextBox tbx_Processor;
        private System.Windows.Forms.TextBox tbx_Model;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tp_InfoRedact;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Processor;
        private System.Windows.Forms.GroupBox gbx_Options;
        private System.Windows.Forms.ListBox lbx_Options;
        private System.Windows.Forms.Label lbl_Picture;
        private System.Windows.Forms.TextBox tbx_Picture;
        private System.Windows.Forms.Label lbl_PriceR;
        private System.Windows.Forms.Label lbl_ProcessorR;
        private System.Windows.Forms.Label lbl_OSR;
        private System.Windows.Forms.Label lbl_ModelR;
        private System.Windows.Forms.TextBox tbx_OSR;
        private System.Windows.Forms.TextBox tbx_PriceR;
        private System.Windows.Forms.TextBox tbx_ProcessorR;
        private System.Windows.Forms.TextBox tbx_ModelR;
        private System.Windows.Forms.GroupBox gbx_redact;
        private System.Windows.Forms.Button btn_SaveChanges;
        private System.Windows.Forms.CheckedListBox chLbx;
        private System.Windows.Forms.Button btn_AddNewPhone;
        private System.Windows.Forms.Button btn_ClearField;
        private System.Windows.Forms.Button btn_DeleteOption;
        private System.Windows.Forms.Button btn_AddOption;
        private System.Windows.Forms.Label lbl_NameOfOption;
        private System.Windows.Forms.TextBox tbx_NameOfOption;
    }
}

