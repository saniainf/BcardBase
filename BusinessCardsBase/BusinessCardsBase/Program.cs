using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BusinessCardsBase
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFormBase());
        }
    }
    
    /// <summary>
    /// static класс для делегатов,
    /// используется для передачи данных между формами
    /// </summary>
    public static class PassingDataSupport
    {
        /// <summary>
        /// делегат поддежки события выбора пользователя
        /// </summary>
        /// <param name="name">имя</param>
        public delegate void selectUserEvent(string name);
        
        /// <summary>
        /// событие "выбор пользователя"
        /// </summary>
        public static selectUserEvent eventSelectUser;

        public static EventHandler eventReload;
    }
}
