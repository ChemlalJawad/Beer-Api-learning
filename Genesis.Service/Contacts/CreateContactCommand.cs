using System;
using System.Collections.Generic;
using System.Text;
using Genesis.Core.Domaine;
using Genesis.Core.Enum;

namespace Genesis.Service.Contacts
{
    public class CreateContactCommand
    {
        public Adresse Adresse;
        public TypeContact TypeContact { get; set; }
        public string NumeroTva { get; set; }
        
    }
}
