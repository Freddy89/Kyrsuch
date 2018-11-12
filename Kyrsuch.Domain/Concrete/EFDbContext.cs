using Kyrsuch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsuch.Domain.Concrete
{
    public class EFDbContext :DbContext
    {
        public DbSet<Products> Products { get; set; }
    }
}
