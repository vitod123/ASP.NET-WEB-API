using AutoMapper;
using Core.DTOs;
using Core.Entities;
using Core.Helpers;
using Core.Interfaces;
using Core.Resources;
using Core.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class CarsService : ICarsService
    {

        private readonly IRepository<Car> carsRepo;
        private readonly IMapper mapper;

        public CarsService(IRepository<Car> carsRepo, IMapper mapper)
        {
            this.carsRepo = carsRepo;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<CarDto>> GetAll()
        {
            var result = await carsRepo.GetListBySpec(new Cars.GetAll());

            return mapper.Map<IEnumerable<CarDto>>(result);
        }

        public async Task<IEnumerable<CarDto>> Order(string order)
        {
            IEnumerable<Car> result;
            if(order == "orderbycountry" || order == "country" || order == "bycountry") 
                result = await carsRepo.GetListBySpec(new Cars.OrderedByCountry());
            else if(order == "orderbymakename" || order == "bymakename" || order == "makename") 
                result = await carsRepo.GetListBySpec(new Cars.OrderedByMakeName());
            else if(order == "orderbymaxspeed" || order == "bymaxspeed" || order == "maxspeed") 
                result = await carsRepo.GetListBySpec(new Cars.OrderedByMaxSpeed());
            else if(order == "orderbyyear" || order == "byyear" || order == "year") 
                result = await carsRepo.GetListBySpec(new Cars.OrderedByYear());
            else
                result = await carsRepo.GetListBySpec(new Cars.OrderedByModelName());

            return mapper.Map<IEnumerable<CarDto>>(result);
        }

        public async Task<CarDto?> GetById(int id)
        {
            Car? item = await carsRepo.GetItemBySpec(new Cars.ById(id));

            if (item == null)
                throw new HttpException(ErrorMessages.CarNotFound, HttpStatusCode.NotFound);

            return mapper.Map<CarDto>(item);
        }

        public async Task Edit(CarDto dto)
        {
            await carsRepo.Update(mapper.Map<Car>(dto));
            await carsRepo.Save();
        }

        public async Task Create(CarDto dto)
        {
            await carsRepo.Insert(mapper.Map<Car>(dto));
            await carsRepo.Save();
        }

        public async Task Delete(int id)
        {
            if (await carsRepo.GetById(id) == null)
                throw new HttpException(ErrorMessages.CarNotFound, HttpStatusCode.NotFound);

            await carsRepo.Delete(id);
            await carsRepo.Save();
        }
    }
}
