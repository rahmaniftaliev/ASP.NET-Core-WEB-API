using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(Product product)
        {
            // bussiness codes if you need
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Product product)
        {
            // bussiness codes if you need
            _productDal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<Product> GetById(int productID)
        {
            // bussiness codes if you need
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductID == productID));
        }

        public IDataResult<List<Product>> GetList()
        {
            // bussiness codes if you need
            return new SuccessDataResult<List<Product>>(_productDal.GetList().ToList());
        }

        public IDataResult<List<Product>> GetListByCategory(int categoryID)
        {
            // bussiness codes if you need
            return new SuccessDataResult<List<Product>>(_productDal.GetList(p => p.CategoryID == categoryID).ToList());
        }

        public IResult Update(Product product)
        {
            // bussiness codes if you need
            _productDal.Update(product);
            return new SuccessResult(Messages.ProductModified);
        }
    }
}
