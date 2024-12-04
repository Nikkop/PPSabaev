namespace Tehnotair
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.labelCap = new System.Windows.Forms.Label();
            this.labelLog = new System.Windows.Forms.Label();
            this.labelPas = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.textBoxPas = new System.Windows.Forms.TextBox();
            this.panelCap = new System.Windows.Forms.Panel();
            this.buttonSign = new System.Windows.Forms.Button();
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
            this.labelCap.Size = new System.Drawing.Size(256, 31);
            this.labelCap.TabIndex = 0;
            this.labelCap.Text = "Вход в \"Технотайр\"";
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Location = new System.Drawing.Point(42, 120);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(38, 13);
            this.labelLog.TabIndex = 1;
            this.labelLog.Text = "Логин";
            // 
            // labelPas
            // 
            this.labelPas.AutoSize = true;
            this.labelPas.Location = new System.Drawing.Point(35, 167);
            this.labelPas.Name = "labelPas";
            this.labelPas.Size = new System.Drawing.Size(45, 13);
            this.labelPas.TabIndex = 2;
            this.labelPas.Text = "Пароль";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(101, 117);
            this.textBoxLog.MaxLength = 100;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(161, 20);
            this.textBoxLog.TabIndex = 3;
            // 
            // textBoxPas
            // 
            this.textBoxPas.Location = new System.Drawing.Point(101, 164);
            this.textBoxPas.MaxLength = 100;
            this.textBoxPas.Name = "textBoxPas";
            this.textBoxPas.Size = new System.Drawing.Size(161, 20);
            this.textBoxPas.TabIndex = 4;
            this.textBoxPas.UseSystemPasswordChar = true;
            // 
            // panelCap
            // 
            this.panelCap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCap.Controls.Add(this.labelCap);
            this.panelCap.Location = new System.Drawing.Point(12, 8);
            this.panelCap.Name = "panelCap";
            this.panelCap.Size = new System.Drawing.Size(488, 78);
            this.panelCap.TabIndex = 5;
            // 
            // buttonSign
            // 
            this.buttonSign.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonSign.Location = new System.Drawing.Point(290, 117);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(210, 67);
            this.buttonSign.TabIndex = 6;
            this.buttonSign.Text = "Войти";
            this.buttonSign.UseVisualStyleBackColor = false;
            this.buttonSign.Click += new System.EventHandler(this.buttonSign_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 222);
            this.Controls.Add(this.buttonSign);
            this.Controls.Add(this.panelCap);
            this.Controls.Add(this.textBoxPas);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.labelPas);
            this.Controls.Add(this.labelLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.panelCap.ResumeLayout(false);
            this.panelCap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCap;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Label labelPas;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.TextBox textBoxPas;
        private System.Windows.Forms.Panel panelCap;
        private System.Windows.Forms.Button buttonSign;
    }
}

