using System;
using System.Collections.Generic;
using System.Text;
using Core.Entity;
using Core.Entity.Abstract;

namespace Entities.DTOs
{
    //Car detail feature class
    public class CarDetailDto:IDto
    {
        public int CarId { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
