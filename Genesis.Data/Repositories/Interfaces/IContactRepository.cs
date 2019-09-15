using System;
using System.Collections.Generic;
using System.Text;
using Genesis.Core.Domaine;
namespace Genesis.Data.Repositories.Interfaces
{
    public interface IContactRepository
    {
        IEnumerable<Contact> GetAll();
        void CreateContact(Contact contact);
        void DeleteContact(Contact contact);

        Contact ContactById(int Id);

    }
}
