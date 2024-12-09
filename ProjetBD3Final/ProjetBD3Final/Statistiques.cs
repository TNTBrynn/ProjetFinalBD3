using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetBD3Final
{
    public partial class Statistiques : Form
    {
        private DataClassesDataContext dataContext = new DataClassesDataContext();

        public Statistiques()
        {
            InitializeComponent();
        }

        private void Statistiques_Load(object sender, EventArgs e)
        {
            //Abonnement par année
            var abonnementParAnnee = from abonnement in dataContext.Abonnements
                                      group abonnement by abonnement.DateAbonnement.Year into g
                                      select new { Mois = g.Key, Nombre = g.Count() };

            //abonnement par mois de l'année courante
            var abonnementParMois = from abonnement in dataContext.Abonnements
                                    where abonnement.DateAbonnement.Year == DateTime.Now.Year
                                    group abonnement by abonnement.DateAbonnement.Month into g
                                     select new { Mois = g.Key, Nombre = g.Count() };

            var sousTotalAbonnement = (from abonnement in dataContext.Abonnements
                                       where abonnement.DateAbonnement.Year == DateTime.Now.Year
                                       select abonnement).Count();

            var totalAbonnement = (from abonnement in dataContext.Abonnements
                                   select abonnement).Count();

            tbSousTotalAbonnement.Text = sousTotalAbonnement.ToString();
            tbTotalAbonnement.Text = totalAbonnement.ToString();

            dgAbonnementAnneeCourante.DataSource = abonnementParMois;
            dgAbonnementParAnnee.DataSource = abonnementParAnnee;
        }
    }
}
