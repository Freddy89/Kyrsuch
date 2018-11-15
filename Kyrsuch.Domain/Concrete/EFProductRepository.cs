using Kyrsuch.Domain.Abstract;
using Kyrsuch.Domain.Entities;
using System.Collections.Generic;

namespace Kyrsuch.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Products> Products
        {
            get { return context.Products; }
        }

        public void SaveProduct(Products product)
        {
            if (product.Id == 0)
                context.Products.Add(product);
            else
            {
                Products dbEntry = context.Products.Find(product.Id);
                if (dbEntry != null)
                {
                    dbEntry.Name = product.Name;
                    dbEntry.Description = product.Description;
                    dbEntry.Price = product.Price;
                    dbEntry.Category = product.Category;
                }
            }
            context.SaveChanges();
        }
    }
}
