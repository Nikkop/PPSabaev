namespace Tehnotair
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.panelCap = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelCap = new System.Windows.Forms.Label();
            this.dataGridViewZak = new System.Windows.Forms.DataGridView();
            this.panelCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZak)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCap
            // 
            this.panelCap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCap.Controls.Add(this.buttonExit);
            this.panelCap.Controls.Add(this.labelCap);
            this.panelCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCap.Location = new System.Drawing.Point(0, 0);
            this.panelCap.Name = "panelCap";
            this.panelCap.Size = new System.Drawing.Size(600, 79);
            this.panelCap.TabIndex = 8;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonExit.Location = new System.Drawing.Point(452, 17);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(109, 45);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelCap
            // 
            this.labelCap.AutoSize = true;
            this.labelCap.BackColor = System.Drawing.Color.Transparent;
            this.labelCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCap.ForeColor = System.Drawing.Color.White;
            this.labelCap.Location = new System.Drawing.Point(16, 21);
            this.labelCap.Name = "labelCap";
            this.labelCap.Size = new System.Drawing.Size(221, 31);
            this.labelCap.TabIndex = 0;
            this.labelCap.Text = "Кабинет админа";
            // 
            // dataGridViewZak
            // 
            this.dataGridViewZak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZak.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewZak.Location = new System.Drawing.Point(0, 79);
            this.dataGridViewZak.Name = "dataGridViewZak";
            this.dataGridViewZak.ReadOnly = true;
            this.dataGridViewZak.Size = new System.Drawing.Size(600, 371);
            this.dataGridViewZak.TabIndex = 9;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.panelCap);
            this.Controls.Add(this.dataGridViewZak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Технотайр";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.panelCap.ResumeLayout(false);
            this.panelCap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZak)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCap;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelCap;
        private System.Windows.Forms.DataGridView dataGridViewZak;
    }
}