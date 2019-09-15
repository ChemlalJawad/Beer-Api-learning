using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Genesis.Core.Domaine
{
    public class Contact
    {
        public int Id { get; set; }
        [JsonProperty("Adresse")]
        public Adresse Adresse { get; set; }
        public TypeContact TypeContact { get; set; }
        public string VATNumber { get; set; }
        public ICollection<Entreprise> Entreprises { get; set; }

    }
    public enum TypeContact {
        Freelance,
        Employe };

}
