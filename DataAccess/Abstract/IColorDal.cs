using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Color abstract operation
    public interface IColorDal:IEntityRepository<Color>
    {
    }
}
