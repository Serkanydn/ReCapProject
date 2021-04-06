
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace  DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapSqlContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetailDtos()
        {
            using (ReCapSqlContext context=new ReCapSqlContext())
            {
                var result = from rental in context.Rentals
                             join car in context.Cars
                             on rental.CarId equals car.Id

                             join customer in context.Customers
                             on rental.CustomerId equals customer.Id

                             join user in context.Users
                             on customer.UserId equals user.Id

                             join brand in context.Brands
                             on car.BrandId equals brand.Id

                             join color in context.Colors
                             on car.ColorId equals color.Id
                             
                             

                             select new RentalDetailDto
                             {
                                 RentalId = rental.Id,
                                 CarId=car.Id,
                                 CustomerId=customer.Id,
                                 Brand=brand.BrandName,
                                 Color=color.ColorName,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 CompanyName = customer.CompanyName,
                                 Email = user.Email,
                                 RentDate = rental.RentDate,
                                 ReturnDate = rental.ReturnDate
                                 
                             };
                return result.ToList();








            }
        }

     
    }
}
