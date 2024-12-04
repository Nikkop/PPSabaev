namespace Tehnotair
{
    partial class FormZakaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZakaz));
            this.labelCap = new System.Windows.Forms.Label();
            this.panelCap = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxNaz = new System.Windows.Forms.TextBox();
            this.labelNaz = new System.Windows.Forms.Label();
            this.textBoxSod = new System.Windows.Forms.TextBox();
            this.labelSod = new System.Windows.Forms.Label();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.labelData = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.panelCap.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCap
            // 
            this.labelCap.AutoSize = true;
            this.labelCap.BackColor = System.Drawing.Color.Transparent;
            this.labelCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCap.ForeColor = System.Drawing.Color.White;
            this.labelCap.Location = new System.Drawing.Point(16, 21);
            this.labelCap.Name = "labelCap";
            this.labelCap.Size = new System.Drawing.Size(233, 31);
            this.labelCap.TabIndex = 0;
            this.labelCap.Text = "Создание заказа";
            // 
            // panelCap
            // 
            this.panelCap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCap.Controls.Add(this.button2);
            this.panelCap.Controls.Add(this.labelCap);
            this.panelCap.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCap.Location = new System.Drawing.Point(0, 0);
            this.panelCap.Name = "panelCap";
            this.panelCap.Size = new System.Drawing.Size(430, 80);
            this.panelCap.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Location = new System.Drawing.Point(452, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBoxNaz
            // 
            this.textBoxNaz.Location = new System.Drawing.Point(105, 112);
            this.textBoxNaz.MaxLength = 100;
            this.textBoxNaz.Name = "textBoxNaz";
            this.textBoxNaz.Size = new System.Drawing.Size(161, 20);
            this.textBoxNaz.TabIndex = 11;
            // 
            // labelNaz
            // 
            this.labelNaz.AutoSize = true;
            this.labelNaz.Location = new System.Drawing.Point(29, 115);
            this.labelNaz.Name = "labelNaz";
            this.labelNaz.Size = new System.Drawing.Size(57, 13);
            this.labelNaz.TabIndex = 10;
            this.labelNaz.Text = "Название";
            // 
            // textBoxSod
            // 
            this.textBoxSod.Location = new System.Drawing.Point(105, 155);
            this.textBoxSod.MaxLength = 500;
            this.textBoxSod.Multiline = true;
            this.textBoxSod.Name = "textBoxSod";
            this.textBoxSod.Size = new System.Drawing.Size(288, 93);
            this.textBoxSod.TabIndex = 13;
            // 
            // labelSod
            // 
            this.labelSod.AutoSize = true;
            this.labelSod.Location = new System.Drawing.Point(29, 158);
            this.labelSod.Name = "labelSod";
            this.labelSod.Size = new System.Drawing.Size(70, 13);
            this.labelSod.TabIndex = 12;
            this.labelSod.Text = "Содержание";
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerData.Location = new System.Drawing.Point(105, 268);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(196, 20);
            this.dateTimePickerData.TabIndex = 14;
            this.dateTimePickerData.Value = new System.DateTime(2024, 12, 4, 0, 0, 0, 0);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(29, 272);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(64, 13);
            this.labelData.TabIndex = 15;
            this.labelData.Text = "Срок сдачи";
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonCreate.Location = new System.Drawing.Point(105, 327);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(196, 45);
            this.buttonCreate.TabIndex = 16;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // FormZakaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 394);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.dateTimePickerData);
            this.Controls.Add(this.textBoxSod);
            this.Controls.Add(this.labelSod);
            this.Controls.Add(this.textBoxNaz);
            this.Controls.Add(this.labelNaz);
            this.Controls.Add(this.panelCap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormZakaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание заказа";
            this.panelCap.ResumeLayout(false);
            this.panelCap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCap;
        private System.Windows.Forms.Panel panelCap;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxNaz;
        private System.Windows.Forms.Label labelNaz;
        private System.Windows.Forms.TextBox textBoxSod;
        private System.Windows.Forms.Label labelSod;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Button buttonCreate;
    }
}