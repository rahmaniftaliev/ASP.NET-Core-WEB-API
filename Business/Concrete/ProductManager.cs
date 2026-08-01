using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

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
            // bussiness codes if you need
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            // bussiness codes if you need
            _productDal.Delete(product);
        }

        public Product GetById(int productID)
        {
            // bussiness codes if you need
            return _productDal.Get(p => p.ProductID == productID);
        }

        public List<Product> GetList()
        {
            // bussiness codes if you need
            return _productDal.GetList().ToList();
        }

        public List<Product> GetListByCategory(int categoryID)
        {
            // bussiness codes if you need
            return _productDal.GetList(p => p.CategoryID == categoryID).ToList();
        }

        public void Update(Product product)
        {
            // bussiness codes if you need
            _productDal.Update(product);
        }
    }
}
