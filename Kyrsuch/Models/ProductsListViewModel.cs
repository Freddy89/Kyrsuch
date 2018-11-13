﻿using Kyrsuch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kyrsuch.Models
{
    public class ProductsListViewModel
    {
        public IEnumerable<Products> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}