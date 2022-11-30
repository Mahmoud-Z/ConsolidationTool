﻿using ConsolidationTool.Data.Models;
using ConsolidationTool.Repository.UnitOfWork;
using ConsolidationTool.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolidationTool.Service.Services
{
    public class CustomerService : ICustomerService
    {
        public IUnitOfWork unitOfWork { get; set; }
        public CustomerService(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }
        public async Task<List<Customer>> GetAll(int id = 0)
        {
            if (id != 0)
                return await unitOfWork.GetRepository<Customer>().GetAll(a => a.Id == id);
            else
                return await unitOfWork.GetRepository<Customer>().GetAll();
        }
    }
}
