using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Genesis.Core.Domaine;
using Genesis.Data.Repositories.Interfaces;

namespace Genesis.Data.Repositories
{
    public class EntrepriseRepository : IEntrepriseRepository
    {
        private readonly GenesisContext _genesisContext;
        public EntrepriseRepository(GenesisContext genesisContext)
        {
            _genesisContext = genesisContext;
        }
        public void CreateEnt(Entreprise entreprise)
        {
            _genesisContext.Entreprises.Add(entreprise);
            _genesisContext.SaveChanges();
        }

        public void HireContact(ContactEntreprise contactEntreprise)
        {
            _genesisContext.ContactsEntreprises.Add(contactEntreprise);
            _genesisContext.SaveChanges();
        }
    }
}
