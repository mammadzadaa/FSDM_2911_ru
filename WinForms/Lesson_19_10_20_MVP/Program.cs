using Lesson_19_10_20_MVP.Presenter;
using Lesson_19_10_20_MVP.Services;
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
        static IToDoListRepository repository;
        static ToDoList programView;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            programView = new ToDoList(); // view
            //Test programView = new Test();
            //repository = new ToDoListRepository();
            repository = new ToDoListJsonRepository();

            ToDoListPresenter programPresenter = new ToDoListPresenter(programView, repository); // presenter

            //programView.presenter = programPresenter;
           // programPresenter.view = programView;

            Application.Run(programView);
        }

        public static void AddItem()
        {
            var dialog = new AddForm();
            var dialogPresenter = new AddPresenter(dialog, repository);

            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                programView.UpdateList(repository.GetAllTasks());
            }
        }
    }
}
