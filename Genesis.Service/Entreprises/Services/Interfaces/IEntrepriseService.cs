using System;
using System.Collections.Generic;
using System.Text;
using Genesis.Core.Domaine;
using Genesis.Service.Entreprises;
namespace Genesis.Service.Entreprises.Services.Interfaces
{
    public interface IEntrepriseService
    {
        Entreprise CreateEnt(EntreprisesCommand command);
    }
}
