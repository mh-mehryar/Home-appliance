﻿using _0_Framework.Domain;
using ShopManagement.Domain.ProductCategoryAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Domain.ProductAgg
{
    public class Product:EntityBase
    {
        public string Name { get; private set; }
        public string Code { get; private set; }
        public double UnitPrice { get; private set; }
        public bool IsInStock { get; private set; }
        public string Picture { get; private set; }
        public string PictureTitle { get; private set; }
        public string PictureAlt { get; private set; }
        public string ShortDescription { get; private set; }
        public string Description { get; private set; }
        public string MetaDescription { get; private set; }
        public string Keywords { get; private set; }
        public string Slug { get; private set; }
        public long CategoryId { get; private set; }
        public ProductCategory Category { get; private set; }

        public Product(string name,string code,double unitPrice,string picture,
            string pictureTitle,string pictureAlt,string shortDescription,string description,
            string metaDescription,string keywords,string slug,long categoryId)
        {
            Name = name;
            Code = code;
            UnitPrice = unitPrice;
            Picture = picture;
            PictureTitle = pictureTitle;
            PictureAlt = pictureAlt;
            ShortDescription = shortDescription;
            Description = description;
            MetaDescription = metaDescription;
            Keywords = keywords;
            Slug = slug;
            CategoryId = categoryId;
            IsInStock = true;

        }

        public void Edit(string name, string code, double unitPrice, string picture,
            string pictureTitle, string pictureAlt, string shortDescription, string description,
            string metaDescription, string keywords, string slug, long categoryId)
        {
            Name = name;
            Code = code;
            UnitPrice = unitPrice;
            Picture = picture;
            PictureTitle = pictureTitle;
            PictureAlt = pictureAlt;
            ShortDescription = shortDescription;
            Description = description;
            MetaDescription = metaDescription;
            Keywords = keywords;
            Slug = slug;
            CategoryId = categoryId;

        }
        public void InStock()
        {
           IsInStock = true;
        }

        public void NotInStock()
        {
            IsInStock = false;
        }



    }
}
