using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using IM.Model;
namespace IM
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            User u = new User();
            Application.Run(new FrmLogin());
        }
    }
}
