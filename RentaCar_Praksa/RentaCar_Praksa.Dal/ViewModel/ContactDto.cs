using RentaCar_Praksa.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar_Praksa.Dal.ViewModel
{
   public  class ContactDto
    {
        public ContactDto(Contact contact)
        {
            Id = contact.Id;
            Name = contact.Name;
            Email = contact.Email;
            Subject = contact.Subject;
            Message = contact.Message;

        }
        public ContactDto()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }

        public string Message { get; set; }
    }
}
