﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            //Business codes,validation

            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public Product GetbyId(int productId)
        {
            return _productDal.Get(filter: p => p.ProductId == productId);
        }

        public List<Product> GetList()
        {
            return _productDal.GetList().ToList();
        }

        public List<Product> GetListByCategory(int categoryId)
        {
            return _productDal.GetList(filter: p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
