﻿using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Car abstract operation
    public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetailDtos(Expression<Func<CarDetailDto, bool>> filter = null);
       
    }
}
