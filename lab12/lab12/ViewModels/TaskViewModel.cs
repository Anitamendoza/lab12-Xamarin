using lab12.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace lab12.ViewModels
{ 
        public class TaskViewModel : BaseViewModel

        {
        private ObservableCollection<Models.TaskModel> tasks;
        private string Title;
        private string Descripcion;
        private string Status;
        private ObservableCollection<Models.TaskModel> storedTasks;
        public ObservableCollection<Models.TaskModel> Tasks
        {
            get => tasks;
            set
            {
                tasks = value;
                OnPropertyChanged();
            }
        }
        public string title
        {
            get => Title;
            set
            {
                Title = value;
                OnPropertyChanged();
            }
        }
        public string descripcion
        {
            get => Descripcion;
            set
            {
                Descripcion = value;
                OnPropertyChanged();
            }
        }
        public string status
        {
            get => Status;
            set
            {
                Status = value;
                OnPropertyChanged();
            }
        }

        public ICommand Save => new Command(ExecuteSave);
        public ICommand Get => new Command(ExecuteGet);

        public TaskViewModel()
        {
            storedTasks = new ObservableCollection<Models.TaskModel>();
            tasks = new ObservableCollection<Models.TaskModel>();
        }

        private void ExecuteSave()
        {
            var newTask = new Models.TaskModel
            {
                Title = Title,
                Descripcion = Descripcion,
                Status = Status
            };

            storedTasks.Add(newTask);

            Title = string.Empty;
            Descripcion = string.Empty;
            Status = string.Empty;
        }

        private void ExecuteGet()
        {
            Tasks.Clear();

            foreach (var task in storedTasks)
            {
                Tasks.Add(task);
            }
        }
    }
}


