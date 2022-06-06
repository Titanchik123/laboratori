using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaia
{
    internal static class Program
        
    {
        public static int smcount = 16;
        public static int ecount1=4;
        public static int ecount2 = 8;
        public static int ecount3 = 6;
        public static участник[] grop1;
        public static участник[] grop2;
        public static участник[] grop3;
        public static участник[] grop4;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new main());
        }
    }
}
