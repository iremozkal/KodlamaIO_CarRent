﻿using FluentValidation.Results;
using CarRent.DataAccess.Abstract;
using CarRent.Entities.Concrete;
using CarRent.Business.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CarRent.DataAccess.Concrete.EntityFramework;
using System.Data.Entity;

namespace CarRent.DataAccess.Concrete.InMemory
{
    public class EFCarDal : ICarDal
    {
        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (CarRentContext context = new CarRentContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public int GetCount()
        {
            using (CarRentContext context = new CarRentContext())
            {
                return context.Set<Car>().Count();
            }
        }

        public bool IsExists(Expression<Func<Car, bool>> filter)
        {
            using (CarRentContext context = new CarRentContext())
            {
                return context.Set<Car>().Any(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (CarRentContext context = new CarRentContext())
            {
                return filter == null
                    ? context.Set<Car>().ToList()
                    : context.Set<Car>().Where(filter).ToList();
            }
        }

        public void Add(Car entity)
        {
            using (CarRentContext context = new CarRentContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Car entity)
        {
            using (CarRentContext context = new CarRentContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (CarRentContext context = new CarRentContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}