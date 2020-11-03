using RentaCar_Praksa.Dal.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RentaCar_Praksa.Dal.Repositories
{
    public interface IBaseRepository<TDto>
    {

        Task<List<TDto>> GetAll(CancellationToken cancellationToken = default);
        Task<TDto> GetById(int id, CancellationToken cancellationToken = default);
        Task<int> Save(TDto dto, CancellationToken cancellationToken = default);
        Task Edit(int id, TDto dto, CancellationToken cancellationToken = default);
        Task Remove(int id, CancellationToken cancellationToken = default);
    }
}
