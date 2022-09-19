using ExerciceSomatif2.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangle = ExerciceSomatif2.Models.Rectangle;

//using Rectangle = ExerciceSomatif2.Modelse;

namespace ExerciceSomatif2
{
    public class Controller
    {
       

        private List<Forme> formes;
        private int idForme;
        private Forme formeCourant;
        private string type;

        public Controller()
        {
            Formes = new List<Forme>();
            Formes.Add(new Rectangle(Color.Green));
            Formes.Add(new RectanglePlein(Color.Green));
            Formes.Add(new Cercle(Color.Orange));
            Formes.Add(new CerclePlein(Color.Orange));

            IdForme = 0;
            FormeCourant = Formes[IdForme];
           
        }

        public Forme Forme { get => FormeCourant; }
        public string Type { get => Type1; }
        public List<Forme> Formes { get => formes; set => formes = value; }
        public int IdForme { get => idForme; set => idForme = value; }
        public Forme FormeCourant { get => formeCourant; set => formeCourant = value; }
        public string Type1 { get => type; set => type = value; }

        public event EventHandler<Forme> ChangementFormeCourantEvent;

        public event EventHandler<string> ChangementFormeCourantTypeEvent;

        public void ChoisirForme()
        {
            Forme nouvelleForme = formes[idForme];
       
            formeCourant = nouvelleForme;
            formeCourant.Dessiner();
            ChangementFormeCourantEvent?.Invoke(this, formeCourant);
        }
    }
}