using Kyrsuch.Domain.Abstract;
using Kyrsuch.Domain.Entities;
using Moq;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kyrsuch.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new List<Products>
            {
                new Products {Name = "Milk",Price = 20},
                new Products {Name = "Suger",Price = 15},
                new Products {Name = "Solt",Price = 10}
            });
            kernel.Bind<IProductRepository>().ToConstant(mock.Object);
        }
    }
}