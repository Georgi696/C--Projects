namespace TestDatenBank
{
    partial class Kundensuche
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
            this.components = new System.ComponentModel.Container();
            this.sucheKunde = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.testDatenBank2020DataSet = new TestDatenBank.TestDatenBank2020DataSet();
            this.kundeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kundeTableAdapter = new TestDatenBank.TestDatenBank2020DataSetTableAdapters.KundeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.testDatenBank2020DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sucheKunde
            // 
            this.sucheKunde.Location = new System.Drawing.Point(93, 78);
            this.sucheKunde.Name = "sucheKunde";
            this.sucheKunde.Size = new System.Drawing.Size(75, 23);
            this.sucheKunde.TabIndex = 0;
            this.sucheKunde.Text = "Suchen";
            this.sucheKunde.UseVisualStyleBackColor = true;
            this.sucheKunde.Click += new System.EventHandler(this.sucheKunde_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kundeBindingSource, "vorname", true));
            this.textBox1.Location = new System.Drawing.Point(12, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 20);
            this.textBox1.TabIndex = 1;
            // 
            // testDatenBank2020DataSet
            // 
            this.testDatenBank2020DataSet.DataSetName = "TestDatenBank2020DataSet";
            this.testDatenBank2020DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kundeBindingSource
            // 
            this.kundeBindingSource.DataMember = "Kunde";
            this.kundeBindingSource.DataSource = this.testDatenBank2020DataSet;
            // 
            // kundeTableAdapter
            // 
            this.kundeTableAdapter.ClearBeforeFill = true;
            // 
            // Kundensuche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 153);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sucheKunde);
            this.Name = "Kundensuche";
            this.Text = "Kundensuche";
            this.Load += new System.EventHandler(this.Kundensuche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testDatenBank2020DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sucheKunde;
        private System.Windows.Forms.TextBox textBox1;
        private TestDatenBank2020DataSet testDatenBank2020DataSet;
        private System.Windows.Forms.BindingSource kundeBindingSource;
        private TestDatenBank2020DataSetTableAdapters.KundeTableAdapter kundeTableAdapter;
    }
}