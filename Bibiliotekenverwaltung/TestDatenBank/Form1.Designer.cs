namespace TestDatenBank
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.kundeButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vertragButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mediumButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.reservierungButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.kundeButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kunde";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Suche";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kundeButton
            // 
            this.kundeButton.Location = new System.Drawing.Point(46, 29);
            this.kundeButton.Name = "kundeButton";
            this.kundeButton.Size = new System.Drawing.Size(98, 23);
            this.kundeButton.TabIndex = 0;
            this.kundeButton.Text = "Kundenlist";
            this.kundeButton.UseVisualStyleBackColor = true;
            this.kundeButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.vertragButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vertrag";
            // 
            // vertragButton
            // 
            this.vertragButton.Location = new System.Drawing.Point(46, 46);
            this.vertragButton.Name = "vertragButton";
            this.vertragButton.Size = new System.Drawing.Size(98, 23);
            this.vertragButton.TabIndex = 0;
            this.vertragButton.Text = "Verträge";
            this.vertragButton.UseVisualStyleBackColor = true;
            this.vertragButton.Click += new System.EventHandler(this.vertragButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mediumButton);
            this.groupBox3.Location = new System.Drawing.Point(308, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Medium";
            // 
            // mediumButton
            // 
            this.mediumButton.Location = new System.Drawing.Point(53, 41);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(98, 23);
            this.mediumButton.TabIndex = 0;
            this.mediumButton.Text = "Mediumliste";
            this.mediumButton.UseVisualStyleBackColor = true;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.reservierungButton);
            this.groupBox4.Location = new System.Drawing.Point(308, 142);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Reservierung";
            // 
            // reservierungButton
            // 
            this.reservierungButton.Location = new System.Drawing.Point(53, 46);
            this.reservierungButton.Name = "reservierungButton";
            this.reservierungButton.Size = new System.Drawing.Size(98, 23);
            this.reservierungButton.TabIndex = 0;
            this.reservierungButton.Text = "Reservierungen";
            this.reservierungButton.UseVisualStyleBackColor = true;
            this.reservierungButton.Click += new System.EventHandler(this.reservierungButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 262);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button kundeButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button vertragButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button reservierungButton;
        private System.Windows.Forms.Button button1;
    }
}

