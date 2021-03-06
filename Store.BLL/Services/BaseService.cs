﻿using AutoMapper;
using Store.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.BLL.Services
{
    public abstract class BaseService
    {
        protected readonly IUnitOfWork unitOfWork;
        protected readonly IMapper mapper;

        public BaseService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

    }
}
