using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelRegistrationSystem.WinFormUI
{
    public interface ILoad
    {
        /// <summary>
        /// 设置加载状态
        /// </summary>
        /// <param name="state"></param>
        void SetState(string state);
    }
}
