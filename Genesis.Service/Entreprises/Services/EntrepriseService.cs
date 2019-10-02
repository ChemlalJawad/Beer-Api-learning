using System;
using System.Collections.Generic;
using System.Text;
using Genesis.Core.Domaine;
using Genesis.Service.Entreprises.Services.Interfaces;
using Genesis.Data.Repositories.Interfaces;
using Genesis.Data.UnitOfWork;

namespace Genesis.Service.Entreprises.Services
{
    public class EntrepriseService : IEntrepriseService
    {
        private readonly IEntrepriseRepository _entrepriseRepository;
        private readonly IUnitOfWork _unitOfWork;
        public EntrepriseService(IEntrepriseRepository entrepriseRepository,IUnitOfWork unitOfWork)
        {
            _entrepriseRepository = entrepriseRepository;
            _unitOfWork = unitOfWork;
        }
        public Entreprise CreateEntreprise(CreateEntrepriseCommand command)
        {
            
            var entreprise = new Entreprise {
                Adresses = command.Adresses,
                NumeroTva = command.NumeroTva,
                SiegeSocial = command.SiegeSocial
            };
            _entrepriseRepository.Create(entreprise);
            _unitOfWork.SaveChanges();
            return entreprise;
        }

        public void HireContact(HireContactCommand command)
        {
            var contactEntreprise = new ContactEntreprise {
               ContactId = command.ContactId,
               EntrepriseId = command.EntrepriseId
            };

            _entrepriseRepository.HireContact(contactEntreprise);
            _unitOfWork.SaveChanges();

        }

        public Entreprise Update(int Id, CreateEntrepriseCommand command)
        {
            var entreprise = _entrepriseRepository.FindOneById(Id);
            if (command.Adresses != null) entreprise.Adresses = command.Adresses;
            if (command.SiegeSocial != null)  entreprise.SiegeSocial = command.SiegeSocial;
            if (command.NumeroTva != null)  entreprise.NumeroTva = command.NumeroTva;

            _entrepriseRepository.Update(entreprise);
            _unitOfWork.SaveChanges();

            return entreprise;
        }

        public Entreprise UpdateSiegeSocialAndAddAdress(int Id, CreateEntrepriseCommand command)
        {
            var entreprise = _entrepriseRepository.FindOneById(Id);
            if (command.Adresses != null) entreprise.Adresses = command.Adresses;
            if (command.SiegeSocial != null) entreprise.SiegeSocial = command.SiegeSocial;
         

            _entrepriseRepository.UpdateSiegeSocialOrAdresses(entreprise);
            _unitOfWork.SaveChanges();

            return entreprise;
        }
    }
}
