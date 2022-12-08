﻿using ConsolidationTool.Core.Dtos;
using ConsolidationTool.Data.Models;
using ConsolidationTool.Repository.UnitOfWork;
using ConsolidationTool.Service.Interfaces.ProductManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolidationTool.Service.Services.ProductMangament
{
    public class CategoryServices : ICategoryServices
    {
        public IUnitOfWork _unitOfWork { get; set; }
        public CategoryServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<string> AddOneAsync(CategoryDto input)
        {
            Category model = new Category();
            model.Name = input.Name;
            model.Description = input.Description;
            await _unitOfWork.GetRepository<Category>().AddAsync(model);
            await _unitOfWork.CompleteAsync();
            return "success";
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _unitOfWork.GetRepository<Category>().GetAllAsync();
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            return await _unitOfWork.GetRepository<Category>().GetByIdAsync(id);
        }

    }
}
