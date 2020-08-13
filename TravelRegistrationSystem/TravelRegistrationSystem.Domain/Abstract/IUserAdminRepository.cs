using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using TravelRegistrationSystem.Domain.Entities;

namespace TravelRegistrationSystem.Domain.Abstract
{
    //管理员接口
    public interface IUserAdminRepository
    {
        IQueryable<UserAdmin> UserAdmins { get; }
    }
}
