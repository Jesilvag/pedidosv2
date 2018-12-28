using Entities;
using Entities.Models;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace Services.Services
{
    public class ProductoService : IDAOGeneric<Producto>
    {

       
        
        public int Add(Producto entity)
        {
            using (var Context=new ApplicationDbContext())
            {
                Context.Productos.Add(entity);
               
                return Context.SaveChanges();
            }
            
        }

        public int Delete(Producto entity)
        {
            using (var ctx=new ApplicationDbContext())
            {
                         
                ctx.Productos.Remove(entity);
                return  ctx.SaveChanges();
            }
        }

        public IEnumerable<Producto> Find(Expression<Func<Producto, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Producto> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Producto> SingleOrDefault(Expression<Func<Producto, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public int Update(Producto entity)
        {
            using (var ctx=new ApplicationDbContext())
            {
                ctx.Update(entity);
               return ctx.SaveChanges();
            }
        }

        public Producto Get(int Id)
        {
            using (var ctx = new ApplicationDbContext())
            {

                return ctx.Productos.SingleOrDefault(x=>x.ID==Id);          
            }
        }
    }
}
