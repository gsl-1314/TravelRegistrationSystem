using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using TravelRegistrationSystem.Domain.Abstract;
using TravelRegistrationSystem.Domain.Entities;

namespace TravelRegistrationSystem.Domain.Concrete
{
    /// <summary>
    /// 实现管理员接口的类——UserAdminRepository
    /// 1个成员变量:context——EF上下文
    /// 1个方法UserAdmins——取得管理员记录
    /// </summary>
    public class UserAdminRepository:IUserAdminRepository
    {
        private EFDbContext context = new EFDbContext();

        public IQueryable<UserAdmin> UserAdmins
        {
            get { return context.UserAdmins; }
        }
    }
}
