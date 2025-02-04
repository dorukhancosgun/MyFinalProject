﻿using DataAccess.Abstract;
using Entitites.Concrete;
using Entitites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {   //Oracle, Sql Server, Postgres, MongoDb gibi bir veri tabanindan gelmis gibi düşün.
            _products = new List<Product>
            {
             new Product{ProductId=1, CategoryId=1 , ProductName="Bardak",UnitPrice=15, UnitsInStock=15},
             new Product{ProductId = 2, CategoryId = 1, ProductName = "Kamera", UnitPrice = 500, UnitsInStock = 10 },
             new Product{ProductId=3, CategoryId=2 , ProductName="Telefon",UnitPrice=1500, UnitsInStock=5},
             new Product{ProductId=4, CategoryId=2 , ProductName="Klavye",UnitPrice=200, UnitsInStock=65},
             new Product{ProductId=5, CategoryId=2 , ProductName="Fare",UnitPrice=85, UnitsInStock=1},
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);

        }

        public void Delete(Product product)
        {           //LINQ = Language Integrated Query
                    //Lambda (`=>`)
                    //Product productToDelete = null ;
                    //foreach (var p in _products)
                    //{
                    //    if (product.ProductId == p.ProductId)
                    //    {
                    //        productToDelete = p;
                    //    }
                    //}
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId); //bu satirin sag tarafi yukaridaki foreachi yapiyor.
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {   //Gönderdiğim ürün Idsine sahip olan ürünü listeden bul.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId); //bu satirin sag tarafi yukaridaki foreachi yapiyor.
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
