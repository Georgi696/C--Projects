namespace Spielerei
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxLinie = new System.Windows.Forms.GroupBox();
            this.buttonLinieFarbe = new System.Windows.Forms.Button();
            this.panelLinieColor = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownLinieStaerke = new System.Windows.Forms.NumericUpDown();
            this.listBoxLinieStil = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBoxHintergrund = new System.Windows.Forms.GroupBox();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAufrufe = new System.Windows.Forms.NumericUpDown();
            this.buttonHintergrundFarbe = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panelHintergrundFarbe = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxHintergrundStil = new System.Windows.Forms.ListBox();
            this.radioButtonHintergrundMuster = new System.Windows.Forms.RadioButton();
            this.radioButtonHintergrundFarbe = new System.Windows.Forms.RadioButton();
            this.radioButtonHintergrundOhne = new System.Windows.Forms.RadioButton();
            this.groupBoxFigur = new System.Windows.Forms.GroupBox();
            this.radioButtonLinie = new System.Windows.Forms.RadioButton();
            this.radioButtonRechteck = new System.Windows.Forms.RadioButton();
            this.radioButtonKreis = new System.Windows.Forms.RadioButton();
            this.buttonLos = new System.Windows.Forms.Button();
            this.buttonLoeschen = new System.Windows.Forms.Button();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.trackBarGroesse = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.panelMuster = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxLinie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLinieStaerke)).BeginInit();
            this.groupBoxHintergrund.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAufrufe)).BeginInit();
            this.groupBoxFigur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGroesse)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxLinie
            // 
            this.groupBoxLinie.Controls.Add(this.buttonLinieFarbe);
            this.groupBoxLinie.Controls.Add(this.panelLinieColor);
            this.groupBoxLinie.Controls.Add(this.label3);
            this.groupBoxLinie.Controls.Add(this.label2);
            this.groupBoxLinie.Controls.Add(this.label1);
            this.groupBoxLinie.Controls.Add(this.numericUpDownLinieStaerke);
            this.groupBoxLinie.Controls.Add(this.listBoxLinieStil);
            this.groupBoxLinie.Controls.Add(this.comboBox1);
            this.groupBoxLinie.Location = new System.Drawing.Point(320, 12);
            this.groupBoxLinie.Name = "groupBoxLinie";
            this.groupBoxLinie.Size = new System.Drawing.Size(252, 127);
            this.groupBoxLinie.TabIndex = 0;
            this.groupBoxLinie.TabStop = false;
            this.groupBoxLinie.Text = "Linie";
            // 
            // buttonLinieFarbe
            // 
            this.buttonLinieFarbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLinieFarbe.Location = new System.Drawing.Point(110, 12);
            this.buttonLinieFarbe.Name = "buttonLinieFarbe";
            this.buttonLinieFarbe.Size = new System.Drawing.Size(34, 28);
            this.buttonLinieFarbe.TabIndex = 6;
            this.buttonLinieFarbe.Text = "...";
            this.buttonLinieFarbe.UseVisualStyleBackColor = true;
            this.buttonLinieFarbe.Click += new System.EventHandler(this.buttonLinieFarbe_Click);
            // 
            // panelLinieColor
            // 
            this.panelLinieColor.BackColor = System.Drawing.Color.Black;
            this.panelLinieColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLinieColor.Location = new System.Drawing.Point(76, 12);
            this.panelLinieColor.Name = "panelLinieColor";
            this.panelLinieColor.Size = new System.Drawing.Size(28, 28);
            this.panelLinieColor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stärke";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Farbe";
            // 
            // numericUpDownLinieStaerke
            // 
            this.numericUpDownLinieStaerke.Location = new System.Drawing.Point(76, 94);
            this.numericUpDownLinieStaerke.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownLinieStaerke.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLinieStaerke.Name = "numericUpDownLinieStaerke";
            this.numericUpDownLinieStaerke.Size = new System.Drawing.Size(173, 20);
            this.numericUpDownLinieStaerke.TabIndex = 2;
            this.numericUpDownLinieStaerke.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // listBoxLinieStil
            // 
            this.listBoxLinieStil.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxLinieStil.FormattingEnabled = true;
            this.listBoxLinieStil.Location = new System.Drawing.Point(76, 43);
            this.listBoxLinieStil.Name = "listBoxLinieStil";
            this.listBoxLinieStil.Size = new System.Drawing.Size(170, 43);
            this.listBoxLinieStil.TabIndex = 1;
            this.listBoxLinieStil.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxLinieStil_DrawItem);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(-156, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBoxHintergrund
            // 
            this.groupBoxHintergrund.Controls.Add(this.numericUpDownSpeed);
            this.groupBoxHintergrund.Controls.Add(this.numericUpDownAufrufe);
            this.groupBoxHintergrund.Controls.Add(this.buttonHintergrundFarbe);
            this.groupBoxHintergrund.Controls.Add(this.label5);
            this.groupBoxHintergrund.Controls.Add(this.panelHintergrundFarbe);
            this.groupBoxHintergrund.Controls.Add(this.label7);
            this.groupBoxHintergrund.Controls.Add(this.label6);
            this.groupBoxHintergrund.Controls.Add(this.label4);
            this.groupBoxHintergrund.Controls.Add(this.listBoxHintergrundStil);
            this.groupBoxHintergrund.Controls.Add(this.radioButtonHintergrundMuster);
            this.groupBoxHintergrund.Controls.Add(this.radioButtonHintergrundFarbe);
            this.groupBoxHintergrund.Controls.Add(this.radioButtonHintergrundOhne);
            this.groupBoxHintergrund.Location = new System.Drawing.Point(320, 145);
            this.groupBoxHintergrund.Name = "groupBoxHintergrund";
            this.groupBoxHintergrund.Size = new System.Drawing.Size(252, 135);
            this.groupBoxHintergrund.TabIndex = 0;
            this.groupBoxHintergrund.TabStop = false;
            this.groupBoxHintergrund.Text = "Hintergrund";
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(192, 64);
            this.numericUpDownSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(54, 20);
            this.numericUpDownSpeed.TabIndex = 7;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownAufrufe
            // 
            this.numericUpDownAufrufe.Location = new System.Drawing.Point(192, 38);
            this.numericUpDownAufrufe.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownAufrufe.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAufrufe.Name = "numericUpDownAufrufe";
            this.numericUpDownAufrufe.Size = new System.Drawing.Size(54, 20);
            this.numericUpDownAufrufe.TabIndex = 7;
            this.numericUpDownAufrufe.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonHintergrundFarbe
            // 
            this.buttonHintergrundFarbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHintergrundFarbe.Location = new System.Drawing.Point(110, 45);
            this.buttonHintergrundFarbe.Name = "buttonHintergrundFarbe";
            this.buttonHintergrundFarbe.Size = new System.Drawing.Size(34, 28);
            this.buttonHintergrundFarbe.TabIndex = 6;
            this.buttonHintergrundFarbe.Text = "...";
            this.buttonHintergrundFarbe.UseVisualStyleBackColor = true;
            this.buttonHintergrundFarbe.Click += new System.EventHandler(this.buttonHintergrundFarbe_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stil";
            // 
            // panelHintergrundFarbe
            // 
            this.panelHintergrundFarbe.BackColor = System.Drawing.Color.Black;
            this.panelHintergrundFarbe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHintergrundFarbe.Location = new System.Drawing.Point(76, 45);
            this.panelHintergrundFarbe.Name = "panelHintergrundFarbe";
            this.panelHintergrundFarbe.Size = new System.Drawing.Size(28, 28);
            this.panelHintergrundFarbe.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Speed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Aufrufe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Farbe";
            // 
            // listBoxHintergrundStil
            // 
            this.listBoxHintergrundStil.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxHintergrundStil.FormattingEnabled = true;
            this.listBoxHintergrundStil.Location = new System.Drawing.Point(76, 92);
            this.listBoxHintergrundStil.Name = "listBoxHintergrundStil";
            this.listBoxHintergrundStil.Size = new System.Drawing.Size(170, 30);
            this.listBoxHintergrundStil.TabIndex = 2;
            this.listBoxHintergrundStil.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxHintergrundStil_DrawItem);
            // 
            // radioButtonHintergrundMuster
            // 
            this.radioButtonHintergrundMuster.AutoSize = true;
            this.radioButtonHintergrundMuster.Location = new System.Drawing.Point(147, 13);
            this.radioButtonHintergrundMuster.Name = "radioButtonHintergrundMuster";
            this.radioButtonHintergrundMuster.Size = new System.Drawing.Size(57, 17);
            this.radioButtonHintergrundMuster.TabIndex = 0;
            this.radioButtonHintergrundMuster.Text = "Muster";
            this.radioButtonHintergrundMuster.UseVisualStyleBackColor = true;
            // 
            // radioButtonHintergrundFarbe
            // 
            this.radioButtonHintergrundFarbe.AutoSize = true;
            this.radioButtonHintergrundFarbe.Location = new System.Drawing.Point(76, 13);
            this.radioButtonHintergrundFarbe.Name = "radioButtonHintergrundFarbe";
            this.radioButtonHintergrundFarbe.Size = new System.Drawing.Size(52, 17);
            this.radioButtonHintergrundFarbe.TabIndex = 0;
            this.radioButtonHintergrundFarbe.Text = "Farbe";
            this.radioButtonHintergrundFarbe.UseVisualStyleBackColor = true;
            // 
            // radioButtonHintergrundOhne
            // 
            this.radioButtonHintergrundOhne.AutoSize = true;
            this.radioButtonHintergrundOhne.Checked = true;
            this.radioButtonHintergrundOhne.Location = new System.Drawing.Point(6, 13);
            this.radioButtonHintergrundOhne.Name = "radioButtonHintergrundOhne";
            this.radioButtonHintergrundOhne.Size = new System.Drawing.Size(51, 17);
            this.radioButtonHintergrundOhne.TabIndex = 0;
            this.radioButtonHintergrundOhne.TabStop = true;
            this.radioButtonHintergrundOhne.Text = "Ohne";
            this.radioButtonHintergrundOhne.UseVisualStyleBackColor = true;
            // 
            // groupBoxFigur
            // 
            this.groupBoxFigur.Controls.Add(this.radioButtonLinie);
            this.groupBoxFigur.Controls.Add(this.radioButtonRechteck);
            this.groupBoxFigur.Controls.Add(this.radioButtonKreis);
            this.groupBoxFigur.Location = new System.Drawing.Point(320, 286);
            this.groupBoxFigur.Name = "groupBoxFigur";
            this.groupBoxFigur.Size = new System.Drawing.Size(252, 48);
            this.groupBoxFigur.TabIndex = 0;
            this.groupBoxFigur.TabStop = false;
            this.groupBoxFigur.Text = "Figur";
            // 
            // radioButtonLinie
            // 
            this.radioButtonLinie.AutoSize = true;
            this.radioButtonLinie.Location = new System.Drawing.Point(189, 23);
            this.radioButtonLinie.Name = "radioButtonLinie";
            this.radioButtonLinie.Size = new System.Drawing.Size(47, 17);
            this.radioButtonLinie.TabIndex = 0;
            this.radioButtonLinie.Text = "Linie";
            this.radioButtonLinie.UseVisualStyleBackColor = true;
            // 
            // radioButtonRechteck
            // 
            this.radioButtonRechteck.AutoSize = true;
            this.radioButtonRechteck.Location = new System.Drawing.Point(93, 23);
            this.radioButtonRechteck.Name = "radioButtonRechteck";
            this.radioButtonRechteck.Size = new System.Drawing.Size(72, 17);
            this.radioButtonRechteck.TabIndex = 0;
            this.radioButtonRechteck.Text = "Rechteck";
            this.radioButtonRechteck.UseVisualStyleBackColor = true;
            // 
            // radioButtonKreis
            // 
            this.radioButtonKreis.AutoSize = true;
            this.radioButtonKreis.Checked = true;
            this.radioButtonKreis.Location = new System.Drawing.Point(21, 23);
            this.radioButtonKreis.Name = "radioButtonKreis";
            this.radioButtonKreis.Size = new System.Drawing.Size(48, 17);
            this.radioButtonKreis.TabIndex = 0;
            this.radioButtonKreis.TabStop = true;
            this.radioButtonKreis.Text = "Kreis";
            this.radioButtonKreis.UseVisualStyleBackColor = true;
            // 
            // buttonLos
            // 
            this.buttonLos.Location = new System.Drawing.Point(320, 346);
            this.buttonLos.Name = "buttonLos";
            this.buttonLos.Size = new System.Drawing.Size(75, 23);
            this.buttonLos.TabIndex = 1;
            this.buttonLos.Text = "Los get´s";
            this.buttonLos.UseVisualStyleBackColor = true;
            this.buttonLos.Click += new System.EventHandler(this.buttonLos_Click);
            // 
            // buttonLoeschen
            // 
            this.buttonLoeschen.Location = new System.Drawing.Point(410, 346);
            this.buttonLoeschen.Name = "buttonLoeschen";
            this.buttonLoeschen.Size = new System.Drawing.Size(75, 23);
            this.buttonLoeschen.TabIndex = 1;
            this.buttonLoeschen.Text = "Löschen";
            this.buttonLoeschen.UseVisualStyleBackColor = true;
            this.buttonLoeschen.Click += new System.EventHandler(this.buttonLoeschen_Click);
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Location = new System.Drawing.Point(497, 346);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(75, 23);
            this.buttonBeenden.TabIndex = 1;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // trackBarGroesse
            // 
            this.trackBarGroesse.Location = new System.Drawing.Point(12, 334);
            this.trackBarGroesse.Maximum = 3;
            this.trackBarGroesse.Minimum = 1;
            this.trackBarGroesse.Name = "trackBarGroesse";
            this.trackBarGroesse.Size = new System.Drawing.Size(293, 45);
            this.trackBarGroesse.TabIndex = 3;
            this.trackBarGroesse.Value = 1;
            // 
            // colorDialog1
            // 
            this.colorDialog1.Tag = "0";
            // 
            // panelMuster
            // 
            this.panelMuster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMuster.BackColor = System.Drawing.Color.White;
            this.panelMuster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMuster.Location = new System.Drawing.Point(12, 12);
            this.panelMuster.Name = "panelMuster";
            this.panelMuster.Size = new System.Drawing.Size(300, 300);
            this.panelMuster.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonLos;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonBeenden;
            this.ClientSize = new System.Drawing.Size(584, 381);
            this.Controls.Add(this.panelMuster);
            this.Controls.Add(this.trackBarGroesse);
            this.Controls.Add(this.buttonBeenden);
            this.Controls.Add(this.buttonLoeschen);
            this.Controls.Add(this.buttonLos);
            this.Controls.Add(this.groupBoxFigur);
            this.Controls.Add(this.groupBoxHintergrund);
            this.Controls.Add(this.groupBoxLinie);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spielerei";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxLinie.ResumeLayout(false);
            this.groupBoxLinie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLinieStaerke)).EndInit();
            this.groupBoxHintergrund.ResumeLayout(false);
            this.groupBoxHintergrund.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAufrufe)).EndInit();
            this.groupBoxFigur.ResumeLayout(false);
            this.groupBoxFigur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGroesse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLinie;
        private System.Windows.Forms.NumericUpDown numericUpDownLinieStaerke;
        private System.Windows.Forms.ListBox listBoxLinieStil;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBoxHintergrund;
        private System.Windows.Forms.GroupBox groupBoxFigur;
        private System.Windows.Forms.Button buttonLos;
        private System.Windows.Forms.Button buttonLoeschen;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxHintergrundStil;
        private System.Windows.Forms.RadioButton radioButtonHintergrundMuster;
        private System.Windows.Forms.RadioButton radioButtonHintergrundFarbe;
        private System.Windows.Forms.RadioButton radioButtonHintergrundOhne;
        private System.Windows.Forms.RadioButton radioButtonLinie;
        private System.Windows.Forms.RadioButton radioButtonRechteck;
        private System.Windows.Forms.RadioButton radioButtonKreis;
        private System.Windows.Forms.TrackBar trackBarGroesse;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Panel panelMuster;
        private System.Windows.Forms.Button buttonLinieFarbe;
        private System.Windows.Forms.Panel panelLinieColor;
        private System.Windows.Forms.Button buttonHintergrundFarbe;
        private System.Windows.Forms.Panel panelHintergrundFarbe;
        private System.Windows.Forms.NumericUpDown numericUpDownAufrufe;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

