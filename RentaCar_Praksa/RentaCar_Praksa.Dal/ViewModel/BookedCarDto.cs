using RentaCar_Praksa.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar_Praksa.Dal.ViewModel
{
    public class BookedCarDto
    {
        public BookedCarDto()
        {

        }
        public BookedCarDto(BookedCar bookedCar)
        {
            Id = bookedCar.Id;
            CarID = bookedCar.CarID;
            UserID = bookedCar.UserID;
            From = bookedCar.From;
            To = bookedCar.To;
            TotalPrice = bookedCar.TotalPrice;

        }

        public int Id { get; set; }
        public int CarID { get; set; }
        public int UserID { get; set; }
        //public Car Car { get; set; }
       // public User User { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public decimal TotalPrice { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CommentCreated { get; set; }
    }
}
