using AutoMapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Core.DataType;
using WebApp.Service.Models.Enrols;
using WebApp.Services;
using WebApp.Sql.Entities.Enrols;

namespace WebApp.Service
{
    public class EducationService : BaseService<Education>, IEducationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EducationService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<EducationModel> AddEducationDetailsAsync(EducationModel model)
        {
            var entity = _mapper.Map<EducationModel, Education>(model);
            await _unitOfWork.Repository<Education>().UpdateAsync(entity);
            await _unitOfWork.CompleteAsync();

            return new EducationModel();
        }

        public async Task<EducationModel> GetEducationDetailsAsync(long educationId)
        {
            var data = await _unitOfWork.Repository<Education>().FirstOrDefaultAsync(f=>f.Id== educationId,
                o=>o.OrderBy(ob=>ob.Id));

            return _mapper.Map<Education, EducationModel>(data);
        }

        public async Task<EducationModel> UpdateEducationDetailsAsync(long educationId, EducationModel model)
        {
            var entity = _mapper.Map<EducationModel, Education>(model);
            await _unitOfWork.Repository<Education>().UpdateAsync(entity);
            await _unitOfWork.CompleteAsync(); 
            return new EducationModel();
        }

        public async Task<EducationModel> UpdateEducationDetailsAsync(long educationId, string model)
        {
            var education = JsonConvert.DeserializeObject<EducationModel>(model);
            var entity = _mapper.Map<EducationModel, Education>(education);

            await _unitOfWork.Repository<Education>().UpdateAsync(entity);
            await _unitOfWork.CompleteAsync();

            return new EducationModel();

        }
    }
}
