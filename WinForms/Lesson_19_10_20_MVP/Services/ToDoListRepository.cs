using Lesson_19_10_20_MVP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_19_10_20_MVP.Services
{
    public class ToDoListRepository : IToDoListRepository
    {
        private List<ToDo> listOfToDo = new List<ToDo>();

        public ToDoListRepository()
        {
            listOfToDo.Add(new ToDo()
            {
                Id = Guid.NewGuid().ToString(),
                Task = "Do homework",
                Description = "Do gomework before bed time 9 pm"
            });
            listOfToDo.Add(new ToDo()
            {
                Id = Guid.NewGuid().ToString(),
                Task = "Repair Car Headlights",
                Description = "Get the best one from dilership"
            });
            listOfToDo.Add(new ToDo()
            {
                Id = Guid.NewGuid().ToString(),
                Task = "Take children from school",
                Description = "Be at school at 3 pm"
            });
        }
        public void AddTask(ToDo task)
        {
            listOfToDo.Add(task);
        }

        public IEnumerable<ToDo> GetAllTasks()
        {
            return listOfToDo;
        }

        public void RemoveTask(string id)
        {
            listOfToDo.RemoveAll(x => x.Id == id);
        }
    }
}
