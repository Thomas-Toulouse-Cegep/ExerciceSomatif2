using ExerciceSomatif2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2.Models
{
    public class Rectangle : Forme
    {
        protected int longueur;
        protected int hauteur;
        private string type;
        private Color color;

        public Rectangle(Color color) : base(color)
        {
        }

        public override string ObtenirForme()
        {
            return "Rectangle";
        }

        protected override void Dessiner(Graphics graphics)
        {
            Pen pen = new Pen(color, 5);
            graphics.DrawRectangle(pen, 10, 10, longueur, hauteur);
        }
    }
}