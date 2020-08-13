using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using TravelRegistrationSystem.Domain.Entities;

namespace TravelRegistrationSystem.Domain.Abstract
{
    //普通用户接口
   public interface IUserInfoRepository
    {
       IQueryable<UserInfo> UserInfoes { get; }
       void SaveUserInfo(UserInfo uInfo);
       UserInfo DeleteUserInfo(int productID);
    }
}
