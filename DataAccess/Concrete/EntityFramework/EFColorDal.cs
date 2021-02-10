using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (ReCapSqlContext context=new ReCapSqlContext())
            {
                var contextAdded = context.Entry(entity);
                contextAdded.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (ReCapSqlContext context = new ReCapSqlContext())
            {
                var contextAdded = context.Entry(entity);
                contextAdded.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (ReCapSqlContext context = new ReCapSqlContext())
            {
                return context.Set<Color>().SingleOrDefault(filter);
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (ReCapSqlContext context = new ReCapSqlContext())
            {
                return filter == null ? context.Set<Color>().ToList() : context.Set<Color>().Where(filter).ToList();
            }
        }

        public void Update(Color entity)
        {
            using (ReCapSqlContext context = new ReCapSqlContext())
            {
                var contextAdded = context.Entry(entity);
                contextAdded.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
