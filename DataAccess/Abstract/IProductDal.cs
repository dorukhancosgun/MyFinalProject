﻿using Core.DataAccess;
using Entitites.Concrete;
using Entitites.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product> //Dal: Data Access Layer
    {
        List<ProductDetailDto> GetProductDetails();

    }
}

//Code Refactoring
