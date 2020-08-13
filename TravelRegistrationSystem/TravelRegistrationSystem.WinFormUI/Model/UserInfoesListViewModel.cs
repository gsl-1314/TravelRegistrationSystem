using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using TravelRegistrationSystem.Domain.Entities;

namespace TravelRegistrationSystem.WinFormUI.Model
{
    public class UserInfoesListViewModel
    {
        public IEnumerable<UserInfo> UserInfoes { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
