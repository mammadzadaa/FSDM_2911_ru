using MVVMTools.Commands;
using MVVMTools.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Input;
using ToDoListMVVM.Model;


namespace ToDoListMVVM.ViewModel
{
    //public class AddTaskCommand : ICommand
    //{
    //    private readonly MainViewModel viewModel;
    //    public AddTaskCommand(MainViewModel viewModel)
    //    {
    //        this.viewModel = viewModel;
    //    }
    //    public void Execute(object parameter)
    //    {
    //        viewModel.AddTask();
    //    }

    //    public event EventHandler CanExecuteChanged;

    //    public bool CanExecute(object parameter) => true;
    //}

    //public class RemoveTaskCommand : ICommand
    //{
    //    private readonly MainViewModel viewModel;
    //    public RemoveTaskCommand(MainViewModel viewModel)
    //    {
    //        this.viewModel = viewModel;
    //    }
    //    public void Execute(object parameter)
    //    {
    //        viewModel.RemoveTask();
    //    }

    //    public event EventHandler CanExecuteChanged;

    //    public bool CanExecute(object parameter) => true;
    //}

    public class MainViewModel : ViewModelBase
    {
        private string taskName;
        private string taskDescription;
        private ObservableCollection<MyTask> myTasks;
        private bool taskDone;
        private DateTime taskDeadline = DateTime.Now;
        private MyTask selectedTask;
        private CommandBase addTaskCommand;
        private CommandBase<MyTask> removeTaskItemCommand;

        public string TaskName
        {
            get => taskName;
            set
            {
                OnChanged(out taskName, value);
                AddTaskCommand.RaiseCanExecuteChanged();
            }
        }

        public string TaskDescription { get => taskDescription; set => OnChanged(out taskDescription, value); }
        public ObservableCollection<MyTask> MyTasks { get => myTasks; set => OnChanged(out myTasks, value); }
        public bool TaskDone { get => taskDone; set => OnChanged(out taskDone, value); }
        public DateTime TaskDeadline { get => taskDeadline; set => OnChanged(out taskDeadline, value); }
        public MyTask SelectedTask
        {
            get => selectedTask;
            set
            {
                OnChanged(out selectedTask, value);
                RemoveTaskCommand.RaiseCanExecuteChanged();
            }
        }

        //public CommandBase AddTaskCommand { get
        //    {
        //        if (addTaskCommand == null)
        //        {
        //            addTaskCommand = new CommandBase(x =>
        //            {
        //                AddTask();
        //            });
        //        }
        //        return addTaskCommand;
        //    }
        //}

        public CommandBase<MyTask> RemoveTaskItemCommand => removeTaskItemCommand ?? (removeTaskItemCommand = new CommandBase<MyTask>((x) =>
        {
            MyTasks.Remove(x);
        } ));

        public CommandBase AddTaskCommand => addTaskCommand ?? (addTaskCommand = new CommandBase(() =>
                    {
                        AddTask();
                    },
                    () =>
                    {
                        return !string.IsNullOrWhiteSpace(TaskName);
                    }));

        public CommandBase RemoveTaskCommand { get; }

        public MainViewModel()
        {
            //AddTaskCommand = new CommandBase(x => AddTask());
            RemoveTaskCommand = new CommandBase(() =>
            {
                if (SelectedTask != null)
                    MyTasks.Remove(SelectedTask);
            },
            () => SelectedTask != null);
            myTasks = new ObservableCollection<MyTask>();
        }
        private void Clear()
        {
            TaskName = string.Empty;
            TaskDescription = string.Empty;
            TaskDeadline = DateTime.Now;
            TaskDone = false;
        }

        public void AddTask()
        {
            MyTasks.Add(new MyTask()
            {
                Name = TaskName,
                Description = TaskDescription,
                IsDone = TaskDone,
                Deadline = TaskDeadline
            });
            Clear();
        }

        //public void RemoveTask()
        //{
        //if (SelectedTask != null)
        //       MyTasks.Remove(SelectedTask);
        //}
    }
}
