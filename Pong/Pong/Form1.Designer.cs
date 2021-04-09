namespace Pong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.spielfeld = new System.Windows.Forms.Panel();
            this.ball = new System.Windows.Forms.Panel();
            this.schlaeger = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.spielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesSpielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bestenListeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schwierigkeitsgradToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sehrEinfachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einfachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mittelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schwerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sehrSchwerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spielfeldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerBall = new System.Windows.Forms.Timer(this.components);
            this.timerSpiel = new System.Windows.Forms.Timer(this.components);
            this.timerSekunde = new System.Windows.Forms.Timer(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.druckenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.spielfeld.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spielfeld
            // 
            this.spielfeld.BackColor = System.Drawing.Color.Black;
            this.spielfeld.Controls.Add(this.ball);
            this.spielfeld.Controls.Add(this.schlaeger);
            this.spielfeld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spielfeld.Location = new System.Drawing.Point(0, 24);
            this.spielfeld.Name = "spielfeld";
            this.spielfeld.Size = new System.Drawing.Size(624, 417);
            this.spielfeld.TabIndex = 2;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.Control;
            this.ball.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ball.Location = new System.Drawing.Point(21, 174);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(10, 10);
            this.ball.TabIndex = 0;
            // 
            // schlaeger
            // 
            this.schlaeger.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.schlaeger.BackColor = System.Drawing.Color.White;
            this.schlaeger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.schlaeger.Location = new System.Drawing.Point(3, 154);
            this.schlaeger.Name = "schlaeger";
            this.schlaeger.Size = new System.Drawing.Size(13, 66);
            this.schlaeger.TabIndex = 1;
            this.schlaeger.MouseMove += new System.Windows.Forms.MouseEventHandler(this.schlaeger_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spielToolStripMenuItem,
            this.einstellungenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Paint += new System.Windows.Forms.PaintEventHandler(this.spielfeld_Paint);
            // 
            // spielToolStripMenuItem
            // 
            this.spielToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuesSpielToolStripMenuItem,
            this.toolStripSeparator2,
            this.pauseToolStripMenuItem,
            this.toolStripSeparator4,
            this.bestenListeToolStripMenuItem,
            this.toolStripSeparator1,
            this.beendenToolStripMenuItem,
            this.toolStripSeparator3,
            this.druckenToolStripMenuItem});
            this.spielToolStripMenuItem.Name = "spielToolStripMenuItem";
            this.spielToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.spielToolStripMenuItem.Text = "&Spiel";
            // 
            // neuesSpielToolStripMenuItem
            // 
            this.neuesSpielToolStripMenuItem.Name = "neuesSpielToolStripMenuItem";
            this.neuesSpielToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.neuesSpielToolStripMenuItem.Text = "&Neues Spiel";
            this.neuesSpielToolStripMenuItem.Click += new System.EventHandler(this.neuesSpielToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Enabled = false;
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pauseToolStripMenuItem.Text = "&Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // bestenListeToolStripMenuItem
            // 
            this.bestenListeToolStripMenuItem.Name = "bestenListeToolStripMenuItem";
            this.bestenListeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bestenListeToolStripMenuItem.Text = "Besten&Liste";
            this.bestenListeToolStripMenuItem.Click += new System.EventHandler(this.bestenListeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.beendenToolStripMenuItem.Text = "&Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schwierigkeitsgradToolStripMenuItem,
            this.spielfeldToolStripMenuItem});
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            // 
            // schwierigkeitsgradToolStripMenuItem
            // 
            this.schwierigkeitsgradToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sehrEinfachToolStripMenuItem,
            this.einfachToolStripMenuItem,
            this.mittelToolStripMenuItem,
            this.schwerToolStripMenuItem,
            this.sehrSchwerToolStripMenuItem});
            this.schwierigkeitsgradToolStripMenuItem.Name = "schwierigkeitsgradToolStripMenuItem";
            this.schwierigkeitsgradToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.schwierigkeitsgradToolStripMenuItem.Text = "Schwierigkeitsgrad";
            // 
            // sehrEinfachToolStripMenuItem
            // 
            this.sehrEinfachToolStripMenuItem.Checked = true;
            this.sehrEinfachToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sehrEinfachToolStripMenuItem.Name = "sehrEinfachToolStripMenuItem";
            this.sehrEinfachToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.sehrEinfachToolStripMenuItem.Text = "Sehr Einfach";
            this.sehrEinfachToolStripMenuItem.Click += new System.EventHandler(this.sehrEinfachToolStripMenuItem_Click);
            // 
            // einfachToolStripMenuItem
            // 
            this.einfachToolStripMenuItem.Name = "einfachToolStripMenuItem";
            this.einfachToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.einfachToolStripMenuItem.Text = "Einfach";
            this.einfachToolStripMenuItem.Click += new System.EventHandler(this.einfachToolStripMenuItem_Click);
            // 
            // mittelToolStripMenuItem
            // 
            this.mittelToolStripMenuItem.Name = "mittelToolStripMenuItem";
            this.mittelToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.mittelToolStripMenuItem.Text = "Mittel";
            this.mittelToolStripMenuItem.Click += new System.EventHandler(this.mittelToolStripMenuItem_Click);
            // 
            // schwerToolStripMenuItem
            // 
            this.schwerToolStripMenuItem.Name = "schwerToolStripMenuItem";
            this.schwerToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.schwerToolStripMenuItem.Text = "Schwer";
            this.schwerToolStripMenuItem.Click += new System.EventHandler(this.schwerToolStripMenuItem_Click);
            // 
            // sehrSchwerToolStripMenuItem
            // 
            this.sehrSchwerToolStripMenuItem.Name = "sehrSchwerToolStripMenuItem";
            this.sehrSchwerToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.sehrSchwerToolStripMenuItem.Text = "Sehr Schwer";
            this.sehrSchwerToolStripMenuItem.Click += new System.EventHandler(this.sehrSchwerToolStripMenuItem_Click);
            // 
            // spielfeldToolStripMenuItem
            // 
            this.spielfeldToolStripMenuItem.Name = "spielfeldToolStripMenuItem";
            this.spielfeldToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.spielfeldToolStripMenuItem.Text = "Spielfeld";
            this.spielfeldToolStripMenuItem.Click += new System.EventHandler(this.spielfeldToolStripMenuItem_Click);
            // 
            // timerBall
            // 
            this.timerBall.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerSpiel
            // 
            this.timerSpiel.Interval = 120000;
            this.timerSpiel.Tick += new System.EventHandler(this.timerSpiel_Tick);
            // 
            // timerSekunde
            // 
            this.timerSekunde.Interval = 1000;
            this.timerSekunde.Tick += new System.EventHandler(this.timerSekunde_Tick);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // druckenToolStripMenuItem
            // 
            this.druckenToolStripMenuItem.Name = "druckenToolStripMenuItem";
            this.druckenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.druckenToolStripMenuItem.Text = "Drucken";
            this.druckenToolStripMenuItem.Click += new System.EventHandler(this.druckenToolStripMenuItem_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.spielfeld);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.spielfeld_Paint);
            this.spielfeld.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel spielfeld;
        private System.Windows.Forms.Panel ball;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem spielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.Panel schlaeger;
        private System.Windows.Forms.Timer timerBall;
        private System.Windows.Forms.Timer timerSpiel;
        private System.Windows.Forms.Timer timerSekunde;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem neuesSpielToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem bestenListeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schwierigkeitsgradToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sehrEinfachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einfachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mittelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schwerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sehrSchwerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spielfeldToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem druckenToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

