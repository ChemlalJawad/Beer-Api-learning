using System;
using System.Collections.Generic;
using System.Text;
using Genesis.Core.Domaine;
using Genesis.Service.Entreprises.Services.Interfaces;
using Genesis.Data.Repositories.Interfaces;

namespace Genesis.Service.Entreprises.Services
{
    public class EntrepriseService : IEntrepriseService
    {
        private readonly IEntrepriseRepository _entrepriseRepository;
        public EntrepriseService(IEntrepriseRepository entrepriseRepository)
        {
            _entrepriseRepository = entrepriseRepository;
        }
        public Entreprise CreateEntreprise(CreateEntrepriseCommand command)
        {
            
            var entreprise = new Entreprise {
                Adresses = command.Adresses,
                NumeroTva = command.NumeroTva,
                SiegeSocial = command.SiegeSocial
            };
            _entrepriseRepository.CreateEnt(entreprise);

            return entreprise;
        }

        public void HireContact(HireContactCommand command)
        {
            var contactEntreprise = new ContactEntreprise {
               ContactId = command.ContactId,
               EntrepriseId = command.EntrepriseId
            };

            _entrepriseRepository.HireContact(contactEntreprise);
        }

        public Entreprise Update(int Id, CreateEntrepriseCommand command)
        {
            var entreprise = _entrepriseRepository.EntrepriseById(Id);
            if (command.Adresses != null) entreprise.Adresses = command.Adresses;
            if (command.SiegeSocial != null)  entreprise.SiegeSocial = command.SiegeSocial;
            if (command.NumeroTva != null)  entreprise.NumeroTva = command.NumeroTva;

            _entrepriseRepository.EditEntreprise(entreprise);
            return entreprise;
        }

        public Entreprise UpdateSiegeSocialAndAddAdress(int Id, CreateEntrepriseCommand command)
        {
            var entreprise = _entrepriseRepository.EntrepriseById(Id);
            if (command.Adresses != null) entreprise.Adresses = command.Adresses;
            if (command.SiegeSocial != null) entreprise.SiegeSocial = command.SiegeSocial;
         

            _entrepriseRepository.EditSiegeSocialAndAddAdresses(entreprise);
            return entreprise;
        }
    }
}
