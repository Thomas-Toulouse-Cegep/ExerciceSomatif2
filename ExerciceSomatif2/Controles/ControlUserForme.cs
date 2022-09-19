using ExerciceSomatif2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design.Behavior;

namespace ExerciceSomatif2.Controles
{
    public partial class ControlUserForme : UserControl
    {
        private Forme forme;

        public Forme Forme
        {
            get => forme;
            set { SetForme(value); }
        }

        private void SetForme(Forme? forme)
        {
            //InitForme();
            if (forme is null)
            {
                lbAffichageForm.Text = "";
                picboxForme.Image = null;
            }
            else
            {
                Desabonner();
            }
            this.forme = forme;
            if (forme is not null)
            {
                Abonner();
                InitForme();
            }
        }

        private void Abonner()
        {
            forme.ValeurIdChanged += ValeurIdChanged;
        }

        private void Desabonner()
        {
            if (forme is not null)
            {
                forme.ValeurIdChanged -= ValeurIdChanged;
            }
        }

        private void InitForme()
        {
            
            lbAffichageForm.Text = forme.Type;
            picboxForme.Image = forme.Dessiner();
            //formes[0].Dessiner();
        }

        public ControlUserForme()
        {
            InitializeComponent();
        }

        private void lbAffichageForm_Click(object sender, EventArgs e)
        {
        }

        private void ControlUserForme_Load(object sender, EventArgs e)
        {
        }

        private void ValeurIdChanged(object? sender, int valeur)
        {
            lbAffichageForm.Text = valeur.ToString();
        }
    }
}