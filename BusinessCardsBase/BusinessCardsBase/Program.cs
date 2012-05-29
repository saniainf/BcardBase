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
    
    
    // класс делегатов для передачи данных между формами
    public static class PassingDataSupport
    {
        // выбор пользователя
        public delegate void ofSelectUser(string name);
        public static ofSelectUser dataSelectUser;

        // создание нового манагера
        public delegate void ofNewManager(string fname, string lname, string ids);
        public static ofNewManager dataNewManager;
    }


    // класс делегатов для основных событий
    public static class GlobalEvents
    {
        /// <summary>
        /// подтвердить изменение базы
        /// </summary>
        public delegate void submitChangeBase(string ofTitle);

        /// <summary>
        /// событие для сохранения изменений базы
        /// </summary>
        public static submitChangeBase eventSubmit;

        /// <summary>
        /// reload таблицы
        /// </summary>
        /// <param name="title">название формы</param>
        public delegate void reloadDataGrid(string title);

        /// <summary>
        /// событие для reload таблицы
        /// </summary>
        public static reloadDataGrid eventReload;
    }
}
