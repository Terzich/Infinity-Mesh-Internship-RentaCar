using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RentaCar_Praksa.Dal.Domain;
using RentaCar_Praksa.Dal.ViewModel;

namespace RentaCar_Praksa.Dal.Repositories
{
    public class SqlServerCarRepository : ICarRepository
    {
        private readonly RentaCarDbContext _context;
        public SqlServerCarRepository(RentaCarDbContext context)
        {
            _context = context;
        }

        public async Task EditCar(int carId, CarDto car, CancellationToken cancellationToken = default)
        {
            var carDomain = await _context.Cars.FindAsync(carId);
            carDomain.CarName = car.CarName;
            carDomain.YearOFProduction = car.YearOFProduction;
            carDomain.HorsePower = car.HorsePower;
            carDomain.NumberOfDoors = car.NumberOfDoors;
            carDomain.Price = car.Price;
            carDomain.ImageURL = car.ImageURL;
            carDomain.ColorID = car.ColorID;
            _context.Cars.Update(carDomain);
            await _context.SaveChangesAsync(cancellationToken);

        }

        public async Task<CarDto> GetCarById(int id, CancellationToken cancellationToken = default)
        {
            var carDoamin = _context.Cars.Find(id);
            var data = new CarDto
            {
                Id = carDoamin.Id,
                CarName = carDoamin.CarName,
                YearOFProduction = carDoamin.YearOFProduction,
                HorsePower = carDoamin.HorsePower,
                NumberOfDoors = carDoamin.NumberOfDoors,
                Price = carDoamin.Price,
                ImageURL = carDoamin.ImageURL,
                ColorID = carDoamin.ColorID,
                CarDetails = carDoamin.CarDetails
            };
            return data;
        }

        public async Task<List<CarDto>> GetCars(CancellationToken cancellationToken = default)
        {
            var collection = await _context.Cars.ToListAsync(cancellationToken);
            var data = collection.Select(car => new CarDto
            {
                Id = car.Id,
                CarName = car.CarName,
                YearOFProduction = car.YearOFProduction,
                HorsePower = car.HorsePower,
                NumberOfDoors = car.NumberOfDoors,
                Price = car.Price,
                ImageURL = car.ImageURL,
                ColorID = car.ColorID,
                CarDetails = car.CarDetails

            }).ToList();
            return data;

        }

        public async Task RemoveCar(int carId,CancellationToken cancellationToken=default)
        {
            var car = _context.Cars.Find(carId);
            _context.Cars.Remove(car);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<int> SaveCar(CarDto car, CancellationToken cancellationToken = default)
        {
            var carDomain = new Car
            {
                CarName = car.CarName,
                YearOFProduction = car.YearOFProduction,
                HorsePower = car.HorsePower,
                NumberOfDoors = car.NumberOfDoors,
                Price = car.Price,
                ImageURL = car.ImageURL,
                ColorID = car.ColorID
            };
            await _context.Cars.AddAsync(carDomain, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return carDomain.Id;

        }
    }
}
