using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IEnginesService
    {
        Task<IEnumerable<EngineDto>> GetAll();
        Task<IEnumerable<EngineDto>> Order(string order);
        Task<EngineDto?> GetById(int id);
        Task Create(EngineDto engineDto);
        Task Edit(EngineDto engineDto);
        Task Delete(int id);
    }
}
