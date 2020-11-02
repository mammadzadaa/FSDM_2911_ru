using System;

namespace Bridge
{
    partial class Program
    {
        static void Main(string[] args)
        {
            ToDoList toDoList = new ToDoList(new XmlSaveLoad<ToDo>());
            toDoList.Add(new ToDo() { Task = "Wash your dishes", isDone = true });
            toDoList.Add(new ToDo() { Task = "Wash your teeth", isDone = false });
            toDoList.Add(new ToDo() { Task = "Wash your hands", isDone = true });
            toDoList.Save("todo.xml");

            Products Products = new Products(new JSONSaveLoad<Product>());
            Products.Add(new Product() {Name = "Potatos", Price = 0.4 });
            Products.Add(new Product() { Name = "Tomatos", Price = 2.5 });
            Products.Add(new Product() { Name = "Cucumbers", Price = 1.8 });

            Products.Save("products.json");
        }
    }

}
