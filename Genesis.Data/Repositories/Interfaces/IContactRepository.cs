using System;
using System.Collections.Generic;
using System.Text;
using Genesis.Core.Domaine;
namespace Genesis.Data.Repositories.Interfaces
{
    public interface IContactRepository
    {
        IEnumerable<Contact> GetAll();
        void Create(Contact contact);
        void Delete(Contact contact);
        void Edit(Contact contact);

        Contact FindOneById(int Id);

    }
}
