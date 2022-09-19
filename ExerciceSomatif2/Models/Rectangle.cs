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
        private Color color;

        public Rectangle(Color color) : base(color)
        {
            this.color = color;
        }

        public override string ObtenirForme()
        {
            return Type = "Rectangle";
        }

        protected override void Dessiner(Graphics graphics)
        {
            Pen pen = new Pen(color, 5);
            graphics.DrawRectangle(pen, 10, 10, 70, 50);
            ObtenirForme();
        }
    }
}