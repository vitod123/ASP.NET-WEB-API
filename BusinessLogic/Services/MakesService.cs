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
    public class MakesService : IMakesService
    {

        private readonly IRepository<Make> makesRepo;
        private readonly IMapper mapper;

        public MakesService(IRepository<Make> makesRepo, IMapper mapper)
        {
            this.makesRepo = makesRepo;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<MakeDto>> GetAll()
        {
            var result = await makesRepo.GetAll();

            return mapper.Map<IEnumerable<MakeDto>>(result);
        }

        public async Task<IEnumerable<MakeDto>> Order()
        {
            var result = await makesRepo.GetListBySpec(new Makes.OrderedByName());

            return mapper.Map<IEnumerable<MakeDto>>(result);
        }

        public async Task<MakeDto?> GetById(int id)
        {
            Make? item = await makesRepo.GetItemBySpec(new Makes.ById(id));

            if (item == null)
                throw new HttpException(ErrorMessages.MakeNotFound, HttpStatusCode.NotFound);

            return mapper.Map<MakeDto>(item);
        }

        public async Task Edit(MakeDto dto)
        {
            await makesRepo.Update(mapper.Map<Make>(dto));
            await makesRepo.Save();
        }

        public async Task Create(MakeDto dto)
        {
            await makesRepo.Insert(mapper.Map<Make>(dto));
            await makesRepo.Save();
        }

        public async Task Delete(int id)
        {
            if (await makesRepo.GetById(id) == null)
                throw new HttpException(ErrorMessages.MakeNotFound, HttpStatusCode.NotFound);

            await makesRepo.Delete(id);
            await makesRepo.Save();
        }
    }
}
