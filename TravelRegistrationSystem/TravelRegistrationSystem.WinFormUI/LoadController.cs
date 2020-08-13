using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using CCWin;
using System.Windows.Forms;

namespace TravelRegistrationSystem.WinFormUI
{
    public class LoadController
    {
        /// <summary>
        /// Loading界面
        /// </summary>
        private static Skin_Metro frm = null;
        private static ILoad iLoad;


        /// <summary>
        /// 显示加载界面
        /// </summary>
        /// <param name="frmType"></param>
        public static void Show(Type frmType)
        {
            if (frmType == null) return;
            Task.Factory.StartNew(() =>
            {
                object obj = Activator.CreateInstance(frmType);

                frm = obj as Skin_Metro;
                iLoad = obj as ILoad;

                Application.Run(frm);
            });
        }
        //设置加载状态
        public static string State
        {
            set
            {
                if (frm == null || iLoad == null) return;
                if (frm.InvokeRequired)
                    frm.Invoke(new Action<string>((str) =>
                    {
                        iLoad.SetState(str);
                    }), value);
            }
        }
        //关闭加载界面
        public static Skin_Metro Close()
        {
            if (frm == null) return frm;
            if (frm.InvokeRequired) { 
                frm.Invoke(new MethodInvoker(frm.Hide));
            }
            return frm;
        }
    }
}
