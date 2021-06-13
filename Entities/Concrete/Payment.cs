using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Payment :IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string NameSurname { get; set; }
        public string CardNumber { get; set; }
        public string ValidMonth { get; set; }
        public string ValidYear { get; set; }
        public string CardType { get; set; }


    }
}
