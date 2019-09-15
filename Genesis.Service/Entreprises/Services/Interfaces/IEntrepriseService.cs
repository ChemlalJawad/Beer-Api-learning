using System;
using System.Collections.Generic;
using System.Text;
using Genesis.Core.Domaine;
using Genesis.Service.Entreprises;
namespace Genesis.Service.Entreprises.Services.Interfaces
{
    public interface IEntrepriseService
    {
        Entreprise CreateEntreprise(CreateEntrepriseCommand command);
        void HireContact(HireContactCommand command);
        Entreprise Update(int Id, CreateEntrepriseCommand command);

    }
}
