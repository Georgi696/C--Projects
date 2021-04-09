using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Snake_Spiel
{
    class Schlangenkopf : Schlangen_Teil
    {
        public Schlangenkopf(Point position, Color farbe) : base(position, farbe)
        {

        }

        public override void Bewegen(int richtung)
        {

            //die alte Position speichern
            altePosition = position;
            //und verändern
            switch (richtung)
            {
                case 0:
                    position.Y = position.Y - groesse;
                    break;
                case 1:
                    position.X = position.X + groesse;
                    break;
                case 2:
                    position.Y = position.Y + groesse;
                    break;
                case 3:
                    position.X = position.X - groesse;
                    break;
            }
        }

        public override Point LieferNeuePosition()
        {
            return position;
        }
    }
}
