using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Core;
using WebApp.Core.Collections;
using WebApp.Service.Models.Configurations;
using WebApp.Services;
using WebApp.Sql.Entities.Configurations;

namespace WebApp.Service.Services.Configurations
{
    public class GenderService : BaseService<Gender>, IGenderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GenderService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Dropdown<GenderModel>> GetDropdownAsync(string searchText = null, int size = CommonVariables.DropdownSize)
        {
            var data = await _unitOfWork.Repository<Gender>().GetDropdownAsync(
                p=>(string.IsNullOrEmpty(searchText)||p.GenderName.Contains(searchText)),
                o=> o.OrderBy(ob => ob.Id),
                se => new GenderModel { Id = se.Id, GenderName = se.GenderName},
                size);

            return data;
        }
    }
}
