using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using System.Drawing;

namespace TravelRegistrationSystem.Domain.Entities
{
    public class UserInfo
    {
        
        public int ID { get; set; }                                             //编号
        public string uName { get; set; }                                       //姓名
        public string modality { get; set; }                                    //形式
        public string phoneNum { get; set; }                                    //手机号码
        public string personIDNum { get; set; }                                 //个人身份证号
        public string gender { get; set; }                                      //性别
        public int age { get; set; }                                            //年龄
        public DateTime registrationDeadline { get; set; }                      //报名日期
        public byte[] photo { get; set; }                                        //照片
        public string comment { get; set; }                                     //备注
    }
}
