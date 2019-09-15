using System;
using System.Collections.Generic;
using System.Text;
using Genesis.Core.Domaine;
using Genesis.Service.Contacts;

namespace Genesis.Service.Contacts.Services.Interfaces
{
    public interface IContactService
    {
        IEnumerable<Contact> GetAll(); //verifier si j'ai bien au moins un contact
        Contact Create(CreateContactCommand command);
        void Delete(int Id);
        
    }
}
