using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using Ninject.Modules;
using TravelRegistrationSystem.Domain.Abstract;
using TravelRegistrationSystem.Domain.Concrete;

namespace TravelRegistrationSystem.WinFormUI.Infrastructure
{
    public class ApplicationModule:NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IUserAdminRepository)).To(typeof(UserAdminRepository));
            Bind(typeof(IUserInfoRepository)).To(typeof(UserInfoRepository));
        }
    }
}
