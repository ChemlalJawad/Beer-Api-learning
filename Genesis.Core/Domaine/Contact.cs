using System;
using System.Collections.Generic;
using System.Text;
using Genesis.Core.Enum;

namespace Genesis.Core.Domaine
{
    public class Contact
    {
        public int Id { get; set; }
        public Adresse Adresse { get; set; }
        public TypeContact TypeContact { get; set; }
        public string NumeroTva { get; set; }
        public ICollection<ContactEntreprise> Entreprises { get; set; }
    }
}