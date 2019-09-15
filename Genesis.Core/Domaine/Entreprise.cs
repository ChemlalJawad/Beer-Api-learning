using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Genesis.Core.Domaine
{
   public class Entreprise
    {
        public int Id { get; set; }
        public string SiegeSocial { get; set; }
        
        public ICollection<Adresse> Adresses { get; set; }
        public string VatNumberEnt { get; set; }
    }
}
