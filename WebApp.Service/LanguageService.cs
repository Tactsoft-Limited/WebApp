using AutoMapper;
using MassTransit;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Core.Collections;
using WebApp.Service.Models.Enrols;
using WebApp.Services;
using WebApp.Sql.Entities.Enrols;
//using WebApp.Sql.Migrations;

namespace WebApp.Service
{
    public class LanguageService : BaseService<Language>, ILanguageService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public LanguageService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<LanguageModel> AddLanguageDetailAsync(LanguageModel model)
        {
            var entity = _mapper.Map<LanguageModel, Language>(model);

            await _unitOfWork.Repository<Language>().UpdateAsync(entity);
            await _unitOfWork.CompleteAsync();

            return new LanguageModel();
        }


        public async Task<LanguageModel> GetLanguageDetailAsync(long languageId)
        {
            var data = await _unitOfWork.Repository<Language>().FirstOrDefaultAsync(f => f.Id == languageId,
                o => o.OrderBy(ob => ob.Id),
                i => i.User);
            return _mapper.Map<Language, LanguageModel>(data);
            
        }

        
        public async Task<LanguageModel> UpdateLanguageDetailAsync(long languageId, LanguageModel model)
        {
            var entity = _mapper.Map<LanguageModel, Language>(model);
            await _unitOfWork.Repository<Language>().UpdateAsync(entity);
            await _unitOfWork.CompleteAsync();
            return new LanguageModel();
        }

        public async Task<LanguageModel> UpdateLanguageDetailAsync(long languageId, string model)
        {
            var langauge = JsonConvert.DeserializeObject<LanguageModel>(model);

            var entity = _mapper.Map<LanguageModel, Language>(langauge);
            await _unitOfWork.Repository<Language>().UpdateAsync(entity);
            await _unitOfWork.CompleteAsync();
            return new LanguageModel();
        }
    }
}
