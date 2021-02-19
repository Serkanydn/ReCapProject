using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Brand abstract operation
    public interface IBrandDal:IEntityRepository<Brand>
    {
    }
}
