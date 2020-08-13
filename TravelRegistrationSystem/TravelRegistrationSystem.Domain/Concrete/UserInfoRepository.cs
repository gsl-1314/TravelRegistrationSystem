using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using TravelRegistrationSystem.Domain.Abstract;
using TravelRegistrationSystem.Domain.Entities;
using System.Windows.Forms;

namespace TravelRegistrationSystem.Domain.Concrete
{
    /// <summary>
    /// 实现普通用户接口的类——UserInfoRepository
    /// 1个成员变量:context——EF上下文
    /// 3个方法
    /// UserInfo——取得用户记录
    /// SaveUserInfo——保存用户信息（增加和编辑)
    /// DeleteUserInfo——删除用户信息
    /// </summary>
    public class UserInfoRepository:IUserInfoRepository
    {
        private EFDbContext context = new EFDbContext();

        public IQueryable<UserInfo> UserInfoes
        {
            get { return context.UserInfoes; }
        }

        public void SaveUserInfo(UserInfo uInfo)
        {
            if (uInfo.ID == 0)
            {
                context.UserInfoes.Add(uInfo);
            }
            else
            {
                UserInfo dbEntry = context.UserInfoes.Find(uInfo.ID);
                if (dbEntry != null)
                {
                    dbEntry.modality = uInfo.modality;
                    dbEntry.phoneNum = uInfo.phoneNum;
                    dbEntry.personIDNum = uInfo.personIDNum;
                    dbEntry.gender = uInfo.gender;
                    dbEntry.comment = uInfo.comment;
                    dbEntry.age = uInfo.age;
                    dbEntry.photo = uInfo.photo;
                    dbEntry.registrationDeadline = uInfo.registrationDeadline;
                    dbEntry.uName = uInfo.uName;
                }
            }
            try 
            { 
            context.SaveChanges();
             }
            catch
            {
                MessageBox.Show("操作无效，没有保存成功！");
            }
        }
        public UserInfo DeleteUserInfo(int productID)
        {
            UserInfo dbEntry = context.UserInfoes.Find(productID);
            if (dbEntry != null)
            {
                context.UserInfoes.Remove(dbEntry);
                try 
                { 
                context.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("操作无效，删除失败！");
                }
            }
            return dbEntry;
        }
    }
   
}
