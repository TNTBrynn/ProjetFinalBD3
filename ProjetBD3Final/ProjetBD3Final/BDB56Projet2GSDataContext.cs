using System.Data.Linq;

namespace ProjetBD3Final
{
    public class BDB56Projet2GSDataContext : DataContext
    {
        public Table<Employes> Employes;

        public Table<Abonnements> Abonnements;

        public Table<Services> Services;

        public Table<Depenses> Depenses;

        public Table<Provinces> Provinces;

        public Table<TypesEmploye> TypesEmploye;

        public Table<Reabonnements> Reabonnements;

        public Table<PrixDepensesAbonnements> PrixDepensesAbonnements;
        public BDB56Projet2GSDataContext(string connection) : base(connection) { }
    }
}
