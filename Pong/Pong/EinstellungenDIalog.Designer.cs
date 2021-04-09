namespace Pong
{
    partial class EinstellungenDIalog
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxGroesse = new System.Windows.Forms.GroupBox();
            this.radioButtonGroesse1 = new System.Windows.Forms.RadioButton();
            this.radioButtonMax = new System.Windows.Forms.RadioButton();
            this.radioButtonGroesse3 = new System.Windows.Forms.RadioButton();
            this.radioButtonGroesse2 = new System.Windows.Forms.RadioButton();
            this.groupBoxFarben = new System.Windows.Forms.GroupBox();
            this.buttonSpielfeldColor = new System.Windows.Forms.Button();
            this.buttonRahmenColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialogRahmen = new System.Windows.Forms.ColorDialog();
            this.colorDialogSpielfeld = new System.Windows.Forms.ColorDialog();
            this.panelVorschau = new System.Windows.Forms.Panel();
            this.ball = new System.Windows.Forms.Panel();
            this.schlaeger = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxGroesse.SuspendLayout();
            this.groupBoxFarben.SuspendLayout();
            this.panelVorschau.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(12, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Übernehmen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.button2.Location = new System.Drawing.Point(208, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Abbrechen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBoxGroesse
            // 
            this.groupBoxGroesse.Controls.Add(this.radioButtonGroesse1);
            this.groupBoxGroesse.Controls.Add(this.radioButtonMax);
            this.groupBoxGroesse.Controls.Add(this.radioButtonGroesse3);
            this.groupBoxGroesse.Controls.Add(this.radioButtonGroesse2);
            this.groupBoxGroesse.Location = new System.Drawing.Point(12, 12);
            this.groupBoxGroesse.Name = "groupBoxGroesse";
            this.groupBoxGroesse.Size = new System.Drawing.Size(327, 90);
            this.groupBoxGroesse.TabIndex = 2;
            this.groupBoxGroesse.TabStop = false;
            this.groupBoxGroesse.Text = "Größe";
            // 
            // radioButtonGroesse1
            // 
            this.radioButtonGroesse1.AutoSize = true;
            this.radioButtonGroesse1.Checked = true;
            this.radioButtonGroesse1.Location = new System.Drawing.Point(17, 39);
            this.radioButtonGroesse1.Name = "radioButtonGroesse1";
            this.radioButtonGroesse1.Size = new System.Drawing.Size(71, 17);
            this.radioButtonGroesse1.TabIndex = 0;
            this.radioButtonGroesse1.TabStop = true;
            this.radioButtonGroesse1.Text = "320 * 200";
            this.radioButtonGroesse1.UseVisualStyleBackColor = true;
            // 
            // radioButtonMax
            // 
            this.radioButtonMax.AutoSize = true;
            this.radioButtonMax.Location = new System.Drawing.Point(248, 39);
            this.radioButtonMax.Name = "radioButtonMax";
            this.radioButtonMax.Size = new System.Drawing.Size(63, 17);
            this.radioButtonMax.TabIndex = 0;
            this.radioButtonMax.Text = "Maximal";
            this.radioButtonMax.UseVisualStyleBackColor = true;
            // 
            // radioButtonGroesse3
            // 
            this.radioButtonGroesse3.AutoSize = true;
            this.radioButtonGroesse3.Location = new System.Drawing.Point(167, 39);
            this.radioButtonGroesse3.Name = "radioButtonGroesse3";
            this.radioButtonGroesse3.Size = new System.Drawing.Size(77, 17);
            this.radioButtonGroesse3.TabIndex = 0;
            this.radioButtonGroesse3.Text = "1020 * 748";
            this.radioButtonGroesse3.UseVisualStyleBackColor = true;
            // 
            // radioButtonGroesse2
            // 
            this.radioButtonGroesse2.AutoSize = true;
            this.radioButtonGroesse2.Location = new System.Drawing.Point(92, 39);
            this.radioButtonGroesse2.Name = "radioButtonGroesse2";
            this.radioButtonGroesse2.Size = new System.Drawing.Size(71, 17);
            this.radioButtonGroesse2.TabIndex = 0;
            this.radioButtonGroesse2.Text = "640 * 420";
            this.radioButtonGroesse2.UseVisualStyleBackColor = true;
            // 
            // groupBoxFarben
            // 
            this.groupBoxFarben.Controls.Add(this.buttonSpielfeldColor);
            this.groupBoxFarben.Controls.Add(this.buttonRahmenColor);
            this.groupBoxFarben.Controls.Add(this.label2);
            this.groupBoxFarben.Controls.Add(this.label1);
            this.groupBoxFarben.Location = new System.Drawing.Point(12, 108);
            this.groupBoxFarben.Name = "groupBoxFarben";
            this.groupBoxFarben.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxFarben.Size = new System.Drawing.Size(327, 90);
            this.groupBoxFarben.TabIndex = 2;
            this.groupBoxFarben.TabStop = false;
            this.groupBoxFarben.Text = "Farbe";
            // 
            // buttonSpielfeldColor
            // 
            this.buttonSpielfeldColor.Location = new System.Drawing.Point(70, 56);
            this.buttonSpielfeldColor.Name = "buttonSpielfeldColor";
            this.buttonSpielfeldColor.Size = new System.Drawing.Size(30, 23);
            this.buttonSpielfeldColor.TabIndex = 1;
            this.buttonSpielfeldColor.Text = "...";
            this.buttonSpielfeldColor.UseVisualStyleBackColor = true;
            this.buttonSpielfeldColor.Click += new System.EventHandler(this.buttonSpielfeldColor_Click);
            // 
            // buttonRahmenColor
            // 
            this.buttonRahmenColor.Location = new System.Drawing.Point(70, 19);
            this.buttonRahmenColor.Name = "buttonRahmenColor";
            this.buttonRahmenColor.Size = new System.Drawing.Size(30, 23);
            this.buttonRahmenColor.TabIndex = 1;
            this.buttonRahmenColor.Text = "...";
            this.buttonRahmenColor.UseVisualStyleBackColor = true;
            this.buttonRahmenColor.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Spielfeld:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rahmen:";
            // 
            // colorDialogRahmen
            // 
            this.colorDialogRahmen.Color = System.Drawing.Color.Transparent;
            // 
            // panelVorschau
            // 
            this.panelVorschau.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelVorschau.Controls.Add(this.ball);
            this.panelVorschau.Controls.Add(this.schlaeger);
            this.panelVorschau.Location = new System.Drawing.Point(12, 222);
            this.panelVorschau.Name = "panelVorschau";
            this.panelVorschau.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panelVorschau.Size = new System.Drawing.Size(326, 121);
            this.panelVorschau.TabIndex = 3;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ball.Location = new System.Drawing.Point(53, 39);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(8, 8);
            this.ball.TabIndex = 0;
            // 
            // schlaeger
            // 
            this.schlaeger.BackColor = System.Drawing.SystemColors.ControlLight;
            this.schlaeger.Location = new System.Drawing.Point(3, 61);
            this.schlaeger.Name = "schlaeger";
            this.schlaeger.Size = new System.Drawing.Size(10, 35);
            this.schlaeger.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Vorschau:";
            // 
            // EinstellungenDIalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 410);
            this.ControlBox = false;
            this.Controls.Add(this.panelVorschau);
            this.Controls.Add(this.groupBoxFarben);
            this.Controls.Add(this.groupBoxGroesse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EinstellungenDIalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spielfeld";
            this.groupBoxGroesse.ResumeLayout(false);
            this.groupBoxGroesse.PerformLayout();
            this.groupBoxFarben.ResumeLayout(false);
            this.groupBoxFarben.PerformLayout();
            this.panelVorschau.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBoxGroesse;
        private System.Windows.Forms.RadioButton radioButtonGroesse1;
        private System.Windows.Forms.RadioButton radioButtonGroesse3;
        private System.Windows.Forms.RadioButton radioButtonGroesse2;
        private System.Windows.Forms.RadioButton radioButtonMax;
        private System.Windows.Forms.GroupBox groupBoxFarben;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSpielfeldColor;
        private System.Windows.Forms.Button buttonRahmenColor;
        private System.Windows.Forms.ColorDialog colorDialogRahmen;
        private System.Windows.Forms.ColorDialog colorDialogSpielfeld;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel ball;
        private System.Windows.Forms.Panel schlaeger;
        private System.Windows.Forms.Panel panelVorschau;
    }
}