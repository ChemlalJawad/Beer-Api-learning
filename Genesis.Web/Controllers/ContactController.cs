using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Genesis.Core.Domaine;
using Genesis.Service.Contacts;
using Genesis.Service.Contacts.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Genesis.Web.Controllers
{
    [Route("api")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService contactService) {
            _contactService = contactService ;
                }

        // GET: api/<controller>
        [HttpGet]
        [Route("contacts")]
        public ActionResult<IEnumerable<Contact>> GetAll()
        {
            var contacts = _contactService.GetAll();
            return Ok(contacts);
        }

        // POST api/<controller>
        [HttpPost]
        [Route("contact")]
        public ActionResult<Contact> Create(CreateContactCommand command)
        {
            var contact = _contactService.Create(command);
            return Ok(contact);
        }
        // Delete api/<controller>
        [HttpDelete]
        [Route("contact/{id}")]
        public ActionResult<Contact> Delete([FromRoute] int Id)
        {    
             _contactService.Delete(Id);
            return Ok();
        }

     
    }
}
