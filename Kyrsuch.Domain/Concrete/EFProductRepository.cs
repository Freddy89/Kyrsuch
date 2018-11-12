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
    }
}
