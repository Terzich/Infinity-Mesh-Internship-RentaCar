using RentaCar_Praksa.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RentaCar_Praksa.Dal.ViewModel
{
   public class ContactViewModel
    {
        public ContactViewModel(List<Contact> contacts)
        {
            Collection = contacts.Select(contact => new ContactDto(contact)).ToList();
        }

        public List<ContactDto> Collection { get; set; }
    }

}
