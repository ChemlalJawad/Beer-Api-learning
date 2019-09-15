using System;
using System.Collections.Generic;
using System.Text;

namespace Genesis.Core.Domaine
{
    public class ContactEntreprise
    {
        public int ContactId { get; set; }
        public Contact Contact { get; set; }

        public int EntrepriseId { get; set; }
        public Entreprise Entreprise { get; set; }
    }
}
