﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public static class Program
    {
        static private Form1 form = null;

        static public Form1 GetForm(bool isDll)
        {
            if (form == null)
                form = new Form1(isDll);
            return form;
        }

        [STAThread]
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern void SetProcessDPIAware();        //声明Windows API函数
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        static void Main()
        {
            SetProcessDPIAware();       //防止高DPI时界面模糊
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(GetForm(false));
        }
    }
}
