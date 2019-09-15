using System;
using System.Collections.Generic;
using System.Text;
using Genesis.Core.Domaine;

namespace Genesis.Service.Entreprises
{
    public class EntreprisesCommand
    {
        public ICollection<Adresse> Adresses { get; set; }

        public string VatNumber { get; set; }
        public string SiegeSocial { get; set; }
       

    }
}
