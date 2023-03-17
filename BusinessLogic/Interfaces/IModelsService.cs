using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IModelsService
    {
        Task<IEnumerable<ModelDto>> GetAll();
        Task<IEnumerable<ModelDto>> Order();
        Task<ModelDto?> GetById(int id);
        Task Create(ModelDto model);
        Task Edit(ModelDto model);
        Task Delete(int id);
    }
}
