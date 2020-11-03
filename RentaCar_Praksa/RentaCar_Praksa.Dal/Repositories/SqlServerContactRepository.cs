using Microsoft.EntityFrameworkCore;
using RentaCar_Praksa.Dal.Domain;
using RentaCar_Praksa.Dal.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RentaCar_Praksa.Dal.Repositories
{
    public class SqlServerContactRepository : IContactRepository
    {
        private readonly RentaCarDbContext _context;
        public SqlServerContactRepository(RentaCarDbContext context)
        {
            _context = context;
        }

        public async Task<List<ContactDto>> GetContacts(CancellationToken cancellationToken = default)
        {

            var collection = await _context.Contacts.ToListAsync(cancellationToken);
            var data = collection.Select(contact => new ContactDto
            {
                Id = contact.Id,
                Name = contact.Name,
                Email = contact.Email,
                Subject = contact.Subject,
                Message = contact.Message
             

            }).ToList();
            return data;

        }

        public async Task<int> SaveContact(ContactDto contact, CancellationToken cancellationToken = default)
        {
            var contactDomain = new Contact
            {
                Id = contact.Id,
                Name = contact.Name,
                Email = contact.Email,
                Subject = contact.Subject,
                Message = contact.Message

            };
            await _context.Contacts.AddAsync(contactDomain,cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return contactDomain.Id;



        }
    }
}
