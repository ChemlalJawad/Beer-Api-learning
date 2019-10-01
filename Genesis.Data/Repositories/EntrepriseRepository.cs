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
        public void Create(Entreprise entreprise)
        {
            _genesisContext.Entreprises.Add(entreprise);
            _genesisContext.SaveChanges();
        }

        public void Update(Entreprise entreprise)
        {
            _genesisContext.Entreprises.Update(entreprise);
            _genesisContext.SaveChanges();
        }

        public void UpdateSiegeSocialOrAdresses(Entreprise entreprise)
        {
            _genesisContext.Entreprises.Update(entreprise);
            _genesisContext.SaveChanges();
        }

        public Entreprise FindOneById(int Id)
        {
            var entreprise = _genesisContext.Entreprises.FirstOrDefault(e => e.Id == Id);
            return entreprise;
        }

        public void HireContact(ContactEntreprise contactEntreprise)
        {
            _genesisContext.ContactsEntreprises.Add(contactEntreprise);
            _genesisContext.SaveChanges();
        }
    }
}
