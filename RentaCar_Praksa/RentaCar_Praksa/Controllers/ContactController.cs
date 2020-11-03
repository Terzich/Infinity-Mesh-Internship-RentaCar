using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RentaCar_Praksa.Dal.Repositories;
using RentaCar_Praksa.Dal.ViewModel;

namespace RentaCar_Praksa.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ContactController : Controller
    {
        private readonly IContactRepository _contactRepository;
        public ContactController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }



        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var contacts = await _contactRepository.GetContacts();
            return Ok(contacts);
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody] ContactDto contact)
        {
            var id = await _contactRepository.SaveContact(contact);
            return Ok(id);
        }
    }
}
