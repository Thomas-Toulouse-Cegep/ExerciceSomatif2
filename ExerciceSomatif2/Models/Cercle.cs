using ExerciceSomatif2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2.Models
{
    public class Cercle : Forme
    {
        public Cercle(Color color) : base(color)
        {
            this.Color = color;
        }

        public override string ObtenirForme()
        {
            return Type = "Cercle";
        }

        protected override void Dessiner(Graphics graphics)
        {
            Pen pen = new Pen(Color.Orange, 5);
            graphics.DrawEllipse(pen, 10, 10, 70, 70);
            ObtenirForme();
        }
    }
}