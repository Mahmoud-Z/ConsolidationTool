﻿using ConsolidationTool.Core.Dtos;
using ConsolidationTool.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolidationTool.Service.Interfaces.ProductManagement
{
    public interface ICategoryServices
    {
        Task<string> AddOneAsync(CategoryDto input);
        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(int id);
    }
}
