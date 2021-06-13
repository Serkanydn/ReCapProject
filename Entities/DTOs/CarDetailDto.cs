using System;
using System.Collections.Generic;
using System.Text;
using Core.Entity;
using Core.Entity.Abstract;
using Entities.Concrete;

namespace Entities.DTOs
{
    //Car detail feature class
    public class CarDetailDto:IDto
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public string ModelYear { get; set; }
        public string Description { get; set; }
        public decimal DailyPrice { get; set; }
        public List<CarImage> CarImages { get; set; }


    }
}
