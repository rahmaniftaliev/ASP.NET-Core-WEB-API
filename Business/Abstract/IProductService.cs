using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetList();
        List<Product> GetListByCategory(int categoryID);
        Product GetById(int productID);
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);

    }
}
