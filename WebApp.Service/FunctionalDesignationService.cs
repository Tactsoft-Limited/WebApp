﻿using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Core;
using WebApp.Core.Collections;
using WebApp.Service.Models.Enrols;
using WebApp.Services;
using WebApp.Sql.Entities.Enrols;

namespace WebApp.Service
{
    public class FunctionalDesignationService : BaseService<FunctionalDesignation>, IFunctionalDesignationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FunctionalDesignationService(IUnitOfWork unitOfWork, IMapper mapper, IWebHostEnvironment webHostEnvironment) : base(unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
            this._webHostEnvironment = webHostEnvironment;
        }

        public async Task<FunctionalDesignationModel> AddFunctionalDesignationDetailAsync(FunctionalDesignationModel functionalDesignation)
        {
            var entity = _mapper.Map<FunctionalDesignationModel, FunctionalDesignation>(functionalDesignation);
            await _unitOfWork.Repository<FunctionalDesignation>().UpdateAsync(entity);
            await _unitOfWork.CompleteAsync();
            return new FunctionalDesignationModel();
        }


        public async Task<FunctionalDesignationModel> GetFunctionalDesignationDetailAsync(long functionalDesignationId)
        {
            var data = await _unitOfWork.Repository<FunctionalDesignation>().FirstOrDefaultAsync(f => f.Id == functionalDesignationId, o => o.OrderBy(ob => ob.Id), i => i.User);
            var response = _mapper.Map<FunctionalDesignation, FunctionalDesignationModel>(data);
            return response;
        }


        public async Task<FunctionalDesignationModel> UpdateFunctionalDesignationDetailAsync(long functionalDesignationId, FunctionalDesignationModel model)
        {
            var entity = _mapper.Map<FunctionalDesignationModel, FunctionalDesignation>(model);
            await _unitOfWork.Repository<FunctionalDesignation>().UpdateAsync(entity);
            await _unitOfWork.CompleteAsync();
            return new FunctionalDesignationModel();
        }
    }
}
