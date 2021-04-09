using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class EinstellungenDIalog : Form
    {
        Graphics Spielvorschau;
        Rectangle rahmen;
        int MaxX, MinX, MaxY, MinY, rahmenBreite = 10;
        SolidBrush pinsel;

        public EinstellungenDIalog()
        {
            InitializeComponent();
            Spielvorschau = panelVorschau.CreateGraphics();
            pinsel = new SolidBrush(colorDialogRahmen.Color);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Point LieferWerte()
        {
            Point rueckGabe = new Point(0, 0);
            if (radioButtonGroesse1.Checked == true)
                rueckGabe = new Point(320, 200);
            if (radioButtonGroesse2.Checked == true)
                rueckGabe = new Point(640, 480);
            if (radioButtonGroesse3.Checked == true)
                rueckGabe = new Point(1024, 768);
            if (radioButtonMax.Checked == true)
                rueckGabe = new Point(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);           
            return rueckGabe;
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
                colorDialogRahmen.ShowDialog();
                Brush pinsel = new SolidBrush(colorDialogRahmen.Color);
                rahmen = ClientRectangle;
                rahmen = panelVorschau.ClientRectangle;
                MaxX = rahmen.Right - rahmenBreite;
                MinX = rahmen.Left + rahmenBreite;
                MaxY = rahmen.Bottom - rahmenBreite;
                MinY = rahmen.Top + rahmenBreite;

                Spielvorschau.FillRectangle(pinsel, 0, 0, MaxX, rahmenBreite);
                Spielvorschau.FillRectangle(pinsel, MaxX, 0, rahmenBreite, MaxY + rahmenBreite);
                Spielvorschau.FillRectangle(pinsel, 0, MaxY, MaxX, rahmenBreite);
                ball.BackColor = colorDialogRahmen.Color;
                schlaeger.BackColor = colorDialogRahmen.Color;
        }

            private void buttonSpielfeldColor_Click(object sender, EventArgs e)
            {
                colorDialogSpielfeld.ShowDialog();
                panelVorschau.BackColor = colorDialogRahmen.Color;
            }
            public void NeuerBall()
            {
                //die Größe des Balles setzen
                ball.Width = 10;
                ball.Height = 10;
                //die Größe des Schlägers setzen
                schlaeger.Width = 10;
                schlaeger.Height = 40;
                //beide Panels in Weiß setzen
                ball.BackColor = colorDialogRahmen.Color;
                schlaeger.BackColor = colorDialogRahmen.Color;
                //den schlaeger Positionieren links an der Rand
                schlaeger.Left = 2;
            //ungefär in der mitte
        }

    }
}
