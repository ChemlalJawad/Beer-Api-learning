using System;
using System.Collections.Generic;
using System.Text;
using Genesis.Core.Domaine;

namespace Genesis.Data.Repositories.Interfaces
{
    public interface IEntrepriseRepository
    {
        
        void CreateEnt(Entreprise entreprise);
        void HireContact(ContactEntreprise contactEntreprise);
        void EditEntreprise(Entreprise entreprise);

        Entreprise EntrepriseById(int Id);
    }
}
