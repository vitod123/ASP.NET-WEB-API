using AutoMapper;
using Core.DTOs;
using Core.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ICarsService
    {
        Task<IEnumerable<CarDto>> GetAll();
        Task<IEnumerable<CarDto>> Order(string order);
        Task<CarDto?> GetById(int id);
        Task Create(CarDto car);
        Task Edit(CarDto car);
        Task Delete(int id);
    }
}
