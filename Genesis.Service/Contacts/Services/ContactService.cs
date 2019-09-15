using System;
using System.Collections.Generic;
using System.Text;
using Genesis.Core.Domaine;
using Genesis.Service.Contacts.Services.Interfaces;
using Genesis.Data.Repositories.Interfaces;

namespace Genesis.Service.Contacts.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;
        public ContactService(IContactRepository contactRepository) {
            _contactRepository = contactRepository;
        }
        public Contact Create(CreateContactCommand command)
        {
            var contact = new Contact
            {
                 Adresse = command.Adresse,
                 TypeContact = command.TypeContact,
                 NumeroTva = command.NumeroTva
            };
            return contact;
        }

        public IEnumerable<Contact> GetAll()
        {
            var contacts = _contactRepository.GetAll();
            return contacts;
        }
    }
}
