using Microsoft.VisualStudio.TestTools.UnitTesting;
using Genesis.Core.Domaine;
using Genesis.Core.Enum;
using Genesis.Data;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
       public Contact cnt;
       public Entreprise ent;
      
        public void PrepareCase() {
            var tabAdresse = new List<Adresse>();
           
            var adresse = new Adresse
            {
                Pays = "Belgique",
                Rue = "Rue du bois 57",
                Ville = "Moustier"

            };
            var entreprise1 = new Entreprise
            {
                Adresses = tabAdresse,
                NumeroTva = "sdqsdqsdsq",
                SiegeSocial = adresse
            };
            tabAdresse.Add(adresse);
            
          
           
            var contact = new Contact {
                TypeContact = TypeContact.Employe,
                Adresse = adresse,
                NumeroTva = null,
                 
               
            };
            var cEntreprise = new ContactEntreprise
            {Contact = contact,
            Entreprise = entreprise1
            };
            contact.Entreprises.Add(cEntreprise);

            this.cnt = contact;
            this.ent = entreprise1;
        }
        [TestMethod]
        public void TestMethod1()
        {
            PrepareCase();
            if (cnt != null) {

            }
            
        }
    }
}
