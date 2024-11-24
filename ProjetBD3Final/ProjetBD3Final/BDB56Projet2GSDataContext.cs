using System.Data.Linq;

namespace ProjetBD3Final
{
    public class BDB56Projet2GSDataContext : DataContext
    {
        public Table<Employes> Employes;

        public BDB56Projet2GSDataContext(string connection) : base(connection) { }
    }
}
