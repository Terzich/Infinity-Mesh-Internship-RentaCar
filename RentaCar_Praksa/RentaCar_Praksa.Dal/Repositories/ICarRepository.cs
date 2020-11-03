using RentaCar_Praksa.Dal.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RentaCar_Praksa.Dal.Repositories
{
    public interface ICarRepository
    {
        Task<List<CarDto>> GetCars(CancellationToken cancellationToken = default);
        Task<CarDto> GetCarById(int id, CancellationToken cancellationToken = default);
        Task<int> SaveCar(CarDto car, CancellationToken cancellationToken = default);
        Task EditCar(int carId, CarDto car, CancellationToken cancellationToken = default);
        Task RemoveCar(int carId, CancellationToken cancellationToken=default);

    }
}
