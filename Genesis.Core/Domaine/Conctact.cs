using System;
using System.Collections.Generic;
using System.Text;

namespace Genesis.Core.Domaine
{
    public class Conctact
    {
        public int Id { get; set; }
        public Adresse Adresse { get; set; }
        public Type TypeContact { get; set; }
        public string VATNumber { get; set; }
        public ICollection<Entreprise> Entreprises { get; set; }

    }
    public enum Type {
        Freelance,
        Employe };

}
