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
        private int rayon;
        private int Diametre { get => rayon * 2; set => rayon = value / 2; }

        protected override void Dessiner(Graphics graphics)
        {
            Brush brush = new SolidBrush(Color.Orange);
            graphics.FillEllipse(brush, 10, 10, Diametre, Diametre);
        }
    }
}