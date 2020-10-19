using Lesson_19_10_20_MVP.Presenter;
using Lesson_19_10_20_MVP.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_19_10_20_MVP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //ToDoList programView = new ToDoList(); // view
            Test programView = new Test();
            ToDoListPresenter programPresenter = new ToDoListPresenter(programView); // presenter

            //programView.presenter = programPresenter;
           // programPresenter.view = programView;

            Application.Run(programView);
        }
    }
}
