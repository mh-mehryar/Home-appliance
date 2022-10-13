﻿using _0_Framework.Application;
using ShopManagement.Application.Contracts.ProductCategory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Application.Contracts.Product
{
    public class CreateProduct
    {
        [Required(ErrorMessage =ValidationMessages.IsRequired)]
        public string Name { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Code { get; set; }

        [Range(1, 9999999999999999.99,ErrorMessage = ValidationMessages.IsRequired)]
        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$",ErrorMessage ="فقط مقادیر عددی وارد شود")]
        public double UnitPrice { get;  set; }

        public string Picture { get;  set; }
        public string PictureTitle { get;  set; }
        public string PictureAlt { get;  set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string ShortDescription { get;  set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Description { get;  set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string MetaDescription { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Keywords { get;  set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Slug { get;  set; }

        [Range(1,1000,ErrorMessage = ValidationMessages.IsRequired)]
        public long CategoryId { get;  set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public List<ProductCategoryViewModel> Categories { get; set; }


    }
}
