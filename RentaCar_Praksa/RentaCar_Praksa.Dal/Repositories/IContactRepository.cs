using RentaCar_Praksa.Dal.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RentaCar_Praksa.Dal.Repositories
{
    public interface IContactRepository
    {
        Task<List<ContactDto>> GetContacts(CancellationToken cancellationToken = default);
        Task<int> SaveContact(ContactDto contact, CancellationToken cancellationToken = default);
    }
}
