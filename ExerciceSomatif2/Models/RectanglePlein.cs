using ExerciceSomatif2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2.Models
{
    public class RectanglePlein : Forme
    {
        protected int longueur;
        protected int hauteur;

        public RectanglePlein(Color color) : base(color)
        {
        }

        public override string ObtenirForme()
        {
            return "Rectangle Plein";
        }

        protected override void Dessiner(Graphics graphics)
        {
            Brush brush = new SolidBrush(Color.Green);
            graphics.FillRectangle(brush, 10, 10, longueur, hauteur);
        }
    }
}