using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelRegistrationSystem.WinFormUI
{
    public static class RegExpression
    {
       public readonly static string  ID = @"/(^\d{15}$)|(^\d{18}$)|(^\d{17}(\d|X|x)$)/";
       public readonly static string Phone = @"^1[3,5,7,8]+\d{9}";
    }
}
