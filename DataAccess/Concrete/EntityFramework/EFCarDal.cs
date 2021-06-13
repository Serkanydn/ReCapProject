using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Car specific operation
    public class EFCarDal : EfEntityRepositoryBase<Car, ReCapSqlContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetailDtos(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (ReCapSqlContext context = new ReCapSqlContext())
            {
                var result = from car in context.Cars
                             join brand in context.Brands
                             on car.BrandId equals brand.Id
                             join color in context.Colors
                             on car.ColorId equals color.Id
                             select new CarDetailDto
                             {
                                 CarId = car.Id,
                                 BrandId = brand.Id,
                                 ColorId = color.Id,
                                 BrandName=brand.BrandName,
                                 ColorName=color.ColorName,
                                 ModelYear=car.ModelYear,
                                 DailyPrice=car.DailyPrice,
                                 Description=car.Description,
                                 CarImages = (from i in context.CarImages
                                              where car.Id == i.CarId
                                              select new CarImage { Id = i.Id, CarId = i.CarId, ImagePath = i.ImagePath, Date = i.Date }).ToList()
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
