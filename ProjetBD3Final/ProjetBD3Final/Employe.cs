using System.Data.Linq.Mapping;

namespace ProjetBD3Final
{
    [Table(Name = "Employes")]
    public class Employes
    {
        [Column(IsPrimaryKey = true)]
        public int No { get; set; }

        [Column(CanBeNull = false)]
        public string MotDePasse { get; set; }

        [Column(CanBeNull = false)]
        public string Nom { get; set; }

        [Column(CanBeNull = false)]
        public string Prenom { get; set; }

        [Column(CanBeNull = false)]
        public string Sexe { get; set; }

        [Column(CanBeNull = false)]
        public int Age { get; set; }

        [Column(CanBeNull = false)]
        public int NoCivique { get; set; }

        [Column(CanBeNull = false)]
        public string Rue { get; set; }

        [Column(CanBeNull = false)]
        public string Ville { get; set; }

        [Column(CanBeNull = false)]
        public string IdProvince { get; set; }

        [Column(CanBeNull = false)]
        public string CodePostal { get; set; }

        [Column(CanBeNull = false)]
        public string Telephone { get; set; }

        [Column(CanBeNull = false)]
        public string Cellulaire { get; set; }

        [Column(CanBeNull = false)]
        public string Courriel { get; set; }

        [Column(CanBeNull = false)]
        public decimal SalaireHoraire { get; set; }

        [Column(CanBeNull = false)]
        public int NoTypeEmploye { get; set; }

        [Column(CanBeNull = true)]
        public string Remarque { get; set; }
    }
}
