using System;
using System.Collections.Generic;
using System.Text;

namespace Genesis.Core.Domaine
{
   public class Entreprise
    {
        public int Id { get; set; }
        public Adresse SiegeSocial { get; set; }
        public ICollection<Adresse> Adresses { get; set; }
        public string NumeroTva { get; set; }
        public ICollection<ContactEntreprise> Contacts { get; set; }
    }
}
