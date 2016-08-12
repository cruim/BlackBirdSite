using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;

namespace WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        private void AddBindings()
        {
            throw new NotImplementedException();
        }

        public object GetService(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        public IEnumerable<object> GetServices(Type servicesType)
        {
            return kernel.GetAll(servicesType);
        } 
    }
}