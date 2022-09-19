using ExerciceSomatif2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2.Models
{
    public class CerclePlein : Forme
    {
        public CerclePlein(Color color) : base(color)
        {
            this.Color = color;
        }

        public override string ObtenirForme()
        {
            return Type = "Cercle Plein";
        }

        protected override void Dessiner(Graphics graphics)
        {
            Brush brush = new SolidBrush(Color.Orange);
            graphics.FillEllipse(brush, 10, 10, 70, 70);
            ObtenirForme();
        }
    }
}