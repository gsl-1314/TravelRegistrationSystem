using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using Ninject;
using Ninject.Modules;
using TravelRegistrationSystem.Domain.Abstract;
using TravelRegistrationSystem.Domain.Concrete;

namespace TravelRegistrationSystem.WinFormUI.Infrastructure
{
     public static class NinjectControllerFactory
    {
         private static IKernel ninjectKernel;

         public static void AddBindings(INinjectModule module)
         {
             ninjectKernel = new StandardKernel(module);
         }
         public static T Resolve<T>()
         {
             return ninjectKernel.Get<T>();
         }
    }
}
