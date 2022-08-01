﻿using ShopManagement.Application.Contracts.ProductCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Domain.ProductCategoryAgg
{
    public interface IProductCategoryRepository
    {
        void Create(ProductCategory entity);
        
        //void Edit(ProductCategory entity);
        ProductCategory Get(long id);
        List<ProductCategory> GetAll();

        //bool Exists(string name);
        bool Exists(Expression<Func<ProductCategory, bool>> expression);
        void SaveChaneges();
        EditProductCategory GetDetails(long id);
        List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel);
    }
    
}
