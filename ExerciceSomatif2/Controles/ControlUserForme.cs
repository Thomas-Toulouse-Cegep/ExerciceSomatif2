using ExerciceSomatif2.Model;
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
            if (forme is null)
            {
                lbAffichageForm.Text = "";
                picboxForme.Image = null;
            }
            this.forme = forme;
            if (forme is not null)
            {
                InitForme();
            }
        }

        private void InitForme()
        {
            throw new NotImplementedException();
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
    }
}