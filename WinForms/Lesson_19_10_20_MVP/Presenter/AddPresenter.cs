using Lesson_19_10_20_MVP.Model;
using Lesson_19_10_20_MVP.Services;
using Lesson_19_10_20_MVP.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_19_10_20_MVP.Presenter
{
    public class AddPresenter
    {
        private IAddTaskView view;
        private IToDoListRepository repository;

        public AddPresenter(IAddTaskView view, IToDoListRepository repository)
        {
            this.view = view;
            this.repository = repository;
            view.Add += AddItem;
        }

        private void AddItem()
        {
            var task = new ToDo()
            {
                Id = Guid.NewGuid().ToString(),
                Task = view.Title,
                Description = view.Description
            };

            repository.AddTask(task);
        }
    }
}
