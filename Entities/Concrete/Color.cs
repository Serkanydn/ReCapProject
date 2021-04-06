
using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //Color feature class
    public class Color : IEntity
    {
        public int Id { get; set; }
        public string ColorName { get; set; }

    }
}
