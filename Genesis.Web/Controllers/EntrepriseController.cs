using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Genesis.Core.Domaine;
using Genesis.Service.Entreprises;
using Genesis.Service.Entreprises.Services.Interfaces;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Genesis.Web.Controllers
{
    [Route("api")]
    [ApiController]
    public class EntrepriseController : Controller
    {
        private readonly IEntrepriseService _entrepriseService;
        public EntrepriseController(IEntrepriseService entrepriseService)
        {
            _entrepriseService = entrepriseService;
        }

        // POST api/<controller>
        [HttpPost]
        [Route("entreprise")]
        public ActionResult<Contact> Create(CreateEntrepriseCommand command)
        {
            var contact = _entrepriseService.CreateEntreprise(command);
            return Ok(contact);
        }

        // POST api/<controller>
        [HttpPost]
        [Route("entreprises/{id}/contacts/hire")]
        public ActionResult<Contact> HireContact([FromRoute] int id, [FromBody] HireContactCommand command)
        {
            command.EntrepriseId = id;
            _entrepriseService.HireContact(command);
            return Ok();
        }
    }
}
