using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using System.Threading;

namespace TravelRegistrationSystem.WinFormUI
{
    public static class DialogHelper
    {
        private static Thread myThread;
        //ShowNextDlg方法的参数传入下一个窗口的引用
        public static void ShowNextDlg(Thread th)
        {
            myThread = th;
            DialogThread(myThread);
        }
        private static void DialogThread(Thread th)
        {
            //开启新线程终止当前线程
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
