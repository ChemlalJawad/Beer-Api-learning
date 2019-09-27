using System;
using System.Collections.Generic;
using System.Text;
using Genesis.Core.Domaine;

namespace Genesis.Data.Repositories.Interfaces
{
    public interface IEntrepriseRepository
    {
        
        void Create(Entreprise entreprise);
        void HireContact(ContactEntreprise contactEntreprise);
        void UpdateEntreprise(Entreprise entreprise);
        void EditSiegeSocialAndAddAdresses(Entreprise entreprise);
        Entreprise FindOneById(int Id);
    }
}
