using Lesson_19_10_20_MVP.Model;
using Lesson_19_10_20_MVP.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_19_10_20_MVP.Presenter
{
    public class ToDoListPresenter
    {
        private List<ToDo> listOfToDo = new List<ToDo>();
        public IToDoList view;

        public ToDoListPresenter(IToDoList view)
        {
            this.view = view;
            view.Add += AddItem;
            view.Remove += DeleteItem;


            listOfToDo.Add(new ToDo() { Id = Guid.NewGuid().ToString(), 
                                        Task = "Do homework", 
                                        Description = "Do gomework before bed time 9 pm" });
            listOfToDo.Add(new ToDo() { Id = Guid.NewGuid().ToString(),
                                        Task = "Repair Car Headlights",
                                        Description = "Get the best one from dilership" });
            listOfToDo.Add(new ToDo() { Id = Guid.NewGuid().ToString(),
                                        Task = "Take children from school",
                                        Description = "Be at school at 3 pm" });

            view.UpdateList(listOfToDo);
       
        }

        public void DeleteItem(string Id)
        {
            var index = listOfToDo.FindIndex(x => x.Id == Id);
            if (index != -1)
            {
                listOfToDo.RemoveAt(index);
                view.UpdateList(listOfToDo);
            }
            
        }

        public void AddItem()
        {
            listOfToDo.Add(new ToDo()
            {
                Id = Guid.NewGuid().ToString(),
                Task = "Buy some bread",
                Description = "Buy bread from nearest grosery store"
            });
            view.UpdateList(listOfToDo);
            
        }

    }
}
