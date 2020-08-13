using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelRegistrationSystem.Domain.Entities
{
    public class UserAdmin
    {
        public int ID { get; set; }                             //编号
        public string uName { get; set; }                       //管理员用户名
        public string uPwd { get; set; }                        //管理员密码
        public string comment { get; set; }                     //备注
        public DateTime dateCreated { get; set; }               //创建日期
    }
}
