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
    public class ModelsService : IModelsService
    {

        private readonly IRepository<Model> modelsRepo;
        private readonly IMapper mapper;

        public ModelsService(IRepository<Model> modelsRepo, IMapper mapper)
        {
            this.modelsRepo = modelsRepo;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<ModelDto>> GetAll()
        {
            var result = await modelsRepo.GetAll();

            return mapper.Map<IEnumerable<ModelDto>>(result);
        }

        public async Task<IEnumerable<ModelDto>> Order()
        {
            var result = await modelsRepo.GetListBySpec(new Models.OrderedByName());

            return mapper.Map<IEnumerable<ModelDto>>(result);
        }

        public async Task<ModelDto?> GetById(int id)
        {
            Model? item = await modelsRepo.GetItemBySpec(new Models.ById(id));

            if (item == null)
                throw new HttpException(ErrorMessages.ModelNotFound, HttpStatusCode.NotFound);

            return mapper.Map<ModelDto>(item);
        }

        public async Task Edit(ModelDto dto)
        {
            await modelsRepo.Update(mapper.Map<Model>(dto));
            await modelsRepo.Save();
        }

        public async Task Create(ModelDto dto)
        {
            await modelsRepo.Insert(mapper.Map<Model>(dto));
            await modelsRepo.Save();
        }

        public async Task Delete(int id)
        {
            if (await modelsRepo.GetById(id) == null)
                throw new HttpException(ErrorMessages.ModelNotFound, HttpStatusCode.NotFound);

            await modelsRepo.Delete(id);
            await modelsRepo.Save();
        }
    }
}
