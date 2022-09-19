using ExerciceSomatif2.Models;
using System.Reflection;
using System.Windows.Forms;

namespace ExerciceSomatif2
{
    public partial class FormAffichageForme : Form
    {
        private readonly Controller controller;

        public FormAffichageForme()
        {
            controller = new Controller();
            InitializeComponent();
            Abonnement();
        }

        private void Abonnement()
        {
            controller.ChangementFormeCourantEvent += Control_ChangementFormeCourant;
        }

        private void btnGenererForme_Click(object sender, EventArgs e)
        {
            controller.ChoisirForme();
            //controller.IdForme += 1;
        }

        private void Control_ChangementFormeCourant(object? sender, Forme forme)
        {
            controlUserForme1.Forme = forme;
            controller.IdForme = (controller.IdForme + 1) % controller.Formes.Count; 
        }

        private void FormAffichageForme_Load(object sender, EventArgs e)
        {
        }

        private void controlUserForme1_Load(object sender, EventArgs e)
        {

        }
    }
}