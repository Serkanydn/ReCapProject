using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    //Car detail feature class
    public class CarDetailDto
    {
        public int CarId { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
