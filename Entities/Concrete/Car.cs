using Core.Entity.Abstract;

using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //Car feature class
    public class Car : IEntity
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }

    }
}
