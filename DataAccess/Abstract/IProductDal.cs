using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
        //IProductDal - Interface Product Data Access Layer
    {
        List<ProductDetailDto> GetProductDetails();

    }
}

//Code Refactoring - Kodun İyileştirilmesi