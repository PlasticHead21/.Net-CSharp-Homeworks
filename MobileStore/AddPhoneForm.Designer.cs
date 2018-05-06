namespace MobileStore
{
    partial class AddPhoneForm
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
            this.tbx_NewModel = new System.Windows.Forms.TextBox();
            this.tbx_NewOs = new System.Windows.Forms.TextBox();
            this.tbx_NewPrice = new System.Windows.Forms.TextBox();
            this.tbx_NewProcessor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_AddPhone = new System.Windows.Forms.Button();
            this.tbx_Picture = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbx_NewModel
            // 
            this.tbx_NewModel.Location = new System.Drawing.Point(262, 67);
            this.tbx_NewModel.Name = "tbx_NewModel";
            this.tbx_NewModel.Size = new System.Drawing.Size(189, 22);
            this.tbx_NewModel.TabIndex = 0;
            // 
            // tbx_NewOs
            // 
            this.tbx_NewOs.Location = new System.Drawing.Point(262, 106);
            this.tbx_NewOs.Name = "tbx_NewOs";
            this.tbx_NewOs.Size = new System.Drawing.Size(189, 22);
            this.tbx_NewOs.TabIndex = 1;
            // 
            // tbx_NewPrice
            // 
            this.tbx_NewPrice.Location = new System.Drawing.Point(262, 187);
            this.tbx_NewPrice.Name = "tbx_NewPrice";
            this.tbx_NewPrice.Size = new System.Drawing.Size(189, 22);
            this.tbx_NewPrice.TabIndex = 2;
            // 
            // tbx_NewProcessor
            // 
            this.tbx_NewProcessor.Location = new System.Drawing.Point(262, 148);
            this.tbx_NewProcessor.Name = "tbx_NewProcessor";
            this.tbx_NewProcessor.Size = new System.Drawing.Size(189, 22);
            this.tbx_NewProcessor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ведите модель телефона:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ведите ОС телефона:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ведите процессор телефона:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ведите цену телефона:";
            // 
            // btn_AddPhone
            // 
            this.btn_AddPhone.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_AddPhone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddPhone.ForeColor = System.Drawing.Color.Red;
            this.btn_AddPhone.Location = new System.Drawing.Point(155, 273);
            this.btn_AddPhone.Name = "btn_AddPhone";
            this.btn_AddPhone.Size = new System.Drawing.Size(109, 41);
            this.btn_AddPhone.TabIndex = 8;
            this.btn_AddPhone.Text = "Добавить";
            this.btn_AddPhone.UseVisualStyleBackColor = true;
            this.btn_AddPhone.Click += new System.EventHandler(this.btn_AddPhone_Click);
            // 
            // tbx_Picture
            // 
            this.tbx_Picture.Location = new System.Drawing.Point(262, 227);
            this.tbx_Picture.Name = "tbx_Picture";
            this.tbx_Picture.Size = new System.Drawing.Size(189, 22);
            this.tbx_Picture.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(12, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Картинка:";
            // 
            // AddPhoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 342);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_Picture);
            this.Controls.Add(this.btn_AddPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_NewProcessor);
            this.Controls.Add(this.tbx_NewPrice);
            this.Controls.Add(this.tbx_NewOs);
            this.Controls.Add(this.tbx_NewModel);
            this.Name = "AddPhoneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление нового телефона ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_NewModel;
        private System.Windows.Forms.TextBox tbx_NewOs;
        private System.Windows.Forms.TextBox tbx_NewPrice;
        private System.Windows.Forms.TextBox tbx_NewProcessor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_AddPhone;
        private System.Windows.Forms.TextBox tbx_Picture;
        private System.Windows.Forms.Label label5;
    }
}