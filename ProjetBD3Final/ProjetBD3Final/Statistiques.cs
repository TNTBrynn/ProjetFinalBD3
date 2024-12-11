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

            //Parties jouées par année
            var partiesParAnnee = from partiesJouees in dataContext.PartiesJouees
                                     group partiesJouees by partiesJouees.DatePartie.Year into g
                                     select new { Mois = g.Key, Nombre = g.Count() };

            //Parties jouées par mois de l'année courante
            var partiesParMois = from partiesJouees in dataContext.PartiesJouees
                                 where partiesJouees.DatePartie.Year == DateTime.Now.Year
                                    group partiesJouees by partiesJouees.DatePartie.Month into g
                                    select new { Mois = g.Key, Nombre = g.Count() };

            var sousTotalParties = (from partiesJouees in dataContext.PartiesJouees
                                    where partiesJouees.DatePartie.Year == DateTime.Now.Year
                                       select partiesJouees).Count();

            var totalParties = (from partiesJouees in dataContext.PartiesJouees
                                select partiesJouees).Count();

            tbSousTotalParties.Text = sousTotalParties.ToString();
            tbTotalParties.Text = totalParties.ToString();

            dgPartiesAnneeCourante.DataSource = partiesParAnnee;
            dgPartiesParAnnee.DataSource = partiesParMois;

            //Dépenses par année
            var depensesParAnnee = from depenses in dataContext.Depenses
                                  group depenses by depenses.DateDepense.Year into g
                                  select new { Mois = g.Key, Nombre = g.Count() };

            //Dépenses par mois de l'année courante
            var depensesParMois = from depenses in dataContext.Depenses
                                 where depenses.DateDepense.Year == DateTime.Now.Year
                                 group depenses by depenses.DateDepense.Month into g
                                 select new { Mois = g.Key, Nombre = g.Count() };

            var sousTotalDepenses = (from depenses in dataContext.Depenses
                                    where depenses.DateDepense.Year == DateTime.Now.Year
                                    select depenses).Count();

            var totalDepenses = (from depenses in dataContext.Depenses
                                select depenses).Count();

            tbSousTotalDepenses.Text = sousTotalDepenses.ToString();
            tbTotalDepenses.Text = totalDepenses.ToString();

            dgDepensesAnneeCourante.DataSource = depensesParAnnee;
            dgDepensesParAnnee.DataSource = depensesParMois;
        }

        private void dgAbonnementParAnnee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
