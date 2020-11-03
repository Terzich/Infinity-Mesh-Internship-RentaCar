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
    public class SqlServerBookedCarRepository : IBaseRepository<BookedCarDto>
    {
        private readonly RentaCarDbContext _context;

        public SqlServerBookedCarRepository(RentaCarDbContext context)
        {
            _context = context;
        }

        public Task Edit(int id, BookedCarDto dto, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<List<BookedCarDto>> GetAll(CancellationToken cancellationToken = default)
        {
            var collection = await _context.BookedCars.ToListAsync(cancellationToken);
            var data = collection.Select(car => new BookedCarDto
            {
                Id = car.Id,
                CarID=car.CarID,
                UserID=car.UserID,
                From=car.From,
                To=car.To,
                TotalPrice=car.TotalPrice
            }).ToList();
            return data;

        }

        public Task<BookedCarDto> GetById(int id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task Remove(int id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Save(BookedCarDto dto, CancellationToken cancellationToken = default)
        {
            var bookedCar = new BookedCar
            {
                UserID = 1,
                CarID = dto.CarID,
                From = dto.From,
                To = dto.To,
                TotalPrice = dto.TotalPrice
            };
            await _context.BookedCars.AddAsync(bookedCar, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return bookedCar.Id;

        }
    }
}
