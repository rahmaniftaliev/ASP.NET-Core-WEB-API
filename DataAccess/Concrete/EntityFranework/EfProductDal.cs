using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFranework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFranework
{
    public class EfProductDal:EfEntityRepositoryBase<NorthwindContext,Product>,IProductDal
    {
    }
}
