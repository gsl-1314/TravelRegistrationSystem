using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using TravelRegistrationSystem.Domain.Entities;
using System.Data.Entity;

namespace TravelRegistrationSystem.Domain.Concrete
{
    public class EFDbContext:DbContext
    {
        public DbSet<UserAdmin> UserAdmins { get; set; }        //数据表的记录在UserAdminRepository.cs中处理
        public DbSet<UserInfo> UserInfoes { get; set; }         //数据表的记录在UserInfoRepository.cs中处理
    }
}
