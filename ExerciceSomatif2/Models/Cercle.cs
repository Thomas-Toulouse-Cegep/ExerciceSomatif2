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
        private int rayon;
        private int Diametre { get => rayon * 2; set => rayon = value / 2; }
        private string Type;

        protected override void Dessiner(Graphics graphics)
        {
            Pen pen = new Pen(Color.Orange, 5);
            graphics.DrawEllipse(pen, 10, 10, Diametre, Diametre);
        }

        public override string TypeForme()
        {
            return "Cercle";
        }
    }
}