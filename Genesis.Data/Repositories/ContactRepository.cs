using System;
using System.Collections.Generic;
using System.Linq;
using Genesis.Core.Domaine;
using Genesis.Data.Repositories.Interfaces;
namespace Genesis.Data.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly GenesisContext _genesisContext;
        public ContactRepository(GenesisContext genesisContext) {
            _genesisContext = genesisContext;
        }
        public void CreateContact(Contact contact)
        {
            _genesisContext.Contacts.Add(contact);
            _genesisContext.SaveChanges();
        }

        public IEnumerable<Contact> GetAll()
        {
            var contacts = _genesisContext.Contacts.ToList();
            return contacts;
        }
    }
}
