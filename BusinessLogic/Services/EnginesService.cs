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

namespace Core.Service
{
    public class EnginesService : IEnginesService
    {

        private readonly IRepository<Engine> enginesRepo;
        private readonly IMapper mapper;

        public EnginesService(IRepository<Engine> enginesRepo, IMapper mapper)
        {
            this.enginesRepo = enginesRepo;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<EngineDto>> GetAll()
        {
            var result = await enginesRepo.GetAll();

            return mapper.Map<IEnumerable<EngineDto>>(result);
        }

        public async Task<IEnumerable<EngineDto>> Order(string order)
        {
            IEnumerable<Engine> result;
            if (order == "orderbyhorsepower" || order == "byhorsepower" || order == "horsepower")
                result = await enginesRepo.GetListBySpec(new Engines.OrderedByHorsepower());
            else
                result = await enginesRepo.GetListBySpec(new Engines.OrderedByVolume());

            return mapper.Map<IEnumerable<EngineDto>>(result);
        }

        public async Task<EngineDto?> GetById(int id)
        {
            var item = await enginesRepo.GetById(id);

            if (item == null)
                throw new HttpException(ErrorMessages.EngineNotFound, HttpStatusCode.NotFound);

            return mapper.Map<EngineDto>(item);
        }

        public async Task Edit(EngineDto dto)
        {
            await enginesRepo.Update(mapper.Map<Engine>(dto));
            await enginesRepo.Save();
        }

        public async Task Create(EngineDto dto)
        {
            await enginesRepo.Insert(mapper.Map<Engine>(dto));
            await enginesRepo.Save();
        }

        public async Task Delete(int id)
        {
            if (await enginesRepo.GetById(id) == null)
                throw new HttpException(ErrorMessages.EngineNotFound, HttpStatusCode.NotFound);

            await enginesRepo.Delete(id);
            await enginesRepo.Save();
        }
    }
}