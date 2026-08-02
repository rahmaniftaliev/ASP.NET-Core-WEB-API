using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetList();
        IDataResult<List<Product>> GetListByCategory(int categoryID);
        IDataResult<Product> GetById(int productID);
        IResult Add(Product product);
        IResult Delete(Product product);
        IResult Update(Product product);

    }
}
