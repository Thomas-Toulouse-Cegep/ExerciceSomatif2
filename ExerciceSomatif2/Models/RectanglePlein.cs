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
        private string type;

        public RectanglePlein(int longueur, int hauteur, string type)
        {
            this.longueur = longueur;
            this.hauteur = hauteur;
            this.type = type;
        }

        protected override void Dessiner(Graphics graphics)
        {
            Brush brush = new SolidBrush(Color.Green);
            graphics.FillRectangle(brush, 10, 10, longueur, hauteur);
        }
    }
}