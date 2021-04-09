using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace RichTextBoxDemo
{
    public partial class Form1 : Form
    {
        int zaehler;
        ToolStripMenuItem menuEintrag;
        string dateiName;

        public Form1()
        {
            InitializeComponent();
            zaehler = 1;
            menuEintrag = new ToolStripMenuItem("&1 - " + dateiName, null, new EventHandler(this.letzteDatei_Click));
            toolStripMenuItem1.DropDownItems.Insert(toolStripMenuItem1.DropDownItems.Count - 1, menuEintrag);
            toolStripMenuItem1.DropDownItems.Insert(toolStripMenuItem1.DropDownItems.Count - 1, new ToolStripSeparator());
        }
        private void letzteDatei_Click(object sender,EventArgs e)
        {
            string name;
            //den namen zurücklesen
            name = ((ToolStripMenuItem)(sender)).Text;
            //die ersten fünf(!!) wieder zeichen löschen
            name = name.Remove(0, 5);
            if (System.IO.File.Exists(name))
            {
                //den dateiname setzen
                dateiName = name;
                //in der titelliste anzeigen
                this.Text = dateiName;
                //die datei lade
                richTextBox1.LoadFile(dateiName);
                //die eigenschaft für Modify zur sicherheit auf false setzen
                richTextBox1.Modified = false;               
            }
        }

        private void öffnenToolStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void speichernToolStripButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            dateiName = openFileDialog1.FileName;
            this.Text = dateiName;
            richTextBox1.SaveFile(dateiName);
            richTextBox1.Modified = false;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string name;
            name = saveFileDialog1.FileName;
            Speichern(name);
        }

        private void bearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }
        void neuesDokument()
        {
            richTextBox1.Clear();
            this.Text = "Datei" + zaehler;
            zaehler++;
            dateiName = String.Empty;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            neuesDokument();
        }

        private void neuToolStripButton_Click(object sender, EventArgs e)
        {
            neuesDokument();

        }
        void Speichern(string name)
        {
            dateiName = name;
            this.Text = dateiName;
            richTextBox1.SaveFile(dateiName);
            richTextBox1.Modified = false;
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            neuesDokument();
        }

        private void DateiSpeichern(object sender, EventArgs e)
        {
            if (dateiName == String.Empty)
                saveFileDialog1.ShowDialog();
            else
                Speichern(dateiName);
        }

        private void DateiLaden(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(dateiName +".bak");
            if (richTextBox1.Modified == true)
            {
                if (MessageBox.Show("Möchten Sie die Änderungen speichern", "Änderungen speichern", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                DateiSpeichern(sender, e);
            }
            openFileDialog1.ShowDialog();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void rückgengigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo == true)
                richTextBox1.Undo();
        }

        private void wiederholenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo == true)
                richTextBox1.Redo();
        }

        private void ausschneidenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kopierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void einfügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void fettToolStripButton1_Click(object sender, EventArgs e)
        {
            if (fettToolStripButton1.CheckOnClick == true)
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Bold);
        }

        private void zentriertToolStripButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            
        }

        private void leftToolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(dateiName != string.Empty)
            //den schlüssel HKEY_CURRENT_USER anlegen
            {
                using (RegistryKey regSchluessel = Registry.CurrentUser.CreateSubKey("Software\\Minitext"))
                {
                    regSchluessel.SetValue("Datei", dateiName);

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //für den menüeintrag
            ToolStripMenuItem menuEintrag;
            string name;
            //den namen zur sicherheit leer initializieren
            name = string.Empty;
            //den schlüssel HKEY_CURRENT_USER öffnen
            using (RegistryKey regSchlüssel = Registry.CurrentUser.OpenSubKey("Software\\Minitext"))
            {
                //ist der schlüssel vorhanden
                if(regSchlüssel != null)
                {
                    //lesen und zuweisen
                    name = Convert.ToString(regSchlüssel.GetValue("Datei"));
                    //den namen menüeintrag erzeugen
                    menuEintrag = new ToolStripMenuItem("&1 - " + name, null, new EventHandler(this.letzteDatei_Click));
                    //und einfügen
                    toolStripMenuItem1.DropDownItems.Insert(toolStripMenuItem1.DropDownItems.Count - 1, menuEintrag);

                    toolStripMenuItem1.DropDownItems.Insert(toolStripMenuItem1.DropDownItems.Count - 1, toolStripSeparator);

                }
            }
        }
    }
}
