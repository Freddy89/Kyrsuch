using Kyrsuch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsuch.Domain.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Products> Products { get; }
        void SaveProduct(Products product);
    }
}
