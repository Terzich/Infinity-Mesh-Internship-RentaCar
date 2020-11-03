using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RentaCar_Praksa.Dal.Domain;
using RentaCar_Praksa.Dal.Repositories;
using RentaCar_Praksa.Dal.ViewModel;

namespace RentaCar_Praksa.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BookedCarController : Controller
    {
        private readonly IBaseRepository<BookedCarDto> _carRepository;

        public BookedCarController(IBaseRepository<BookedCarDto> carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var bookedCars = await _carRepository.GetAll();
            return Ok(bookedCars);
        }
        [HttpPost]
        public async Task<IActionResult> Save([FromBody]BookedCarDto bookedCar)
        {
            var id = await _carRepository.Save(bookedCar);
            return Ok(id);
        }


    }
}