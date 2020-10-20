using Lesson_19_10_20_MVP.Model;
using Lesson_19_10_20_MVP.Services;
using Lesson_19_10_20_MVP.View;
using Lesson_19_10_20_MVP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_19_10_20_MVP.Presenter
{
    public class ToDoListPresenter
    {
        
        private IToDoList view;
        private IToDoListRepository repository;

        public ToDoListPresenter(IToDoList view, IToDoListRepository repository)
        {
            this.view = view;
            this.repository = repository;

            view.Add += AddItem;
            view.Remove += DeleteItem;

            view.UpdateList(repository.GetAllTasks());
        }

        public void DeleteItem(string Id)
        {
            repository.RemoveTask(Id);
            view.UpdateList(repository.GetAllTasks());            
        }

        public void AddItem()
        {
            Program.AddItem();
        }

    }
}
