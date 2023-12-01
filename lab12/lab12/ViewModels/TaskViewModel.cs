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
            string title;
            public string Title
            {
                get { return title; }
                set
                {
                    if (title != value)
                    {
                        title = value;
                        OnPropertyChanged();
                    }
                }
            }

            string descripcion;
            public string Descripcion
            {
                get { return descripcion; }
                set
                {
                    if (descripcion != value)
                    {
                        descripcion = value;
                    OnPropertyChanged();
                    }
                }
            }

            string status;
            public string Status
            {
                get { return status; }
                set
                {
                    if (status != value)
                    {
                        status = value;
                        OnPropertyChanged();
                    }
                }
            }
         
            List<TaskModel> tasks;
        public List<TaskModel> Tasks
        {
            get { return tasks; }
            set
            {
                if (tasks != value)
                {
                    tasks = value;
                    OnPropertyChanged();
                }
            }
        }
        public ICommand Save { protected set; get; }
        public ICommand Get { protected set; get; }
        public ObservableCollection<TaskModel> Tasks { get; set; }

        public TaskViewModel()
        {
            Tasks = new ObservableCollection<TaskModel>();

            Save = new Command(() =>
            {
                TaskModel newTask = new TaskModel
                {
                    Title = this.Title,
                    Descripcion = this.Descripcion,
                    Status = this.Status
                };

                Tasks.Add(newTask);
            });

            Get = new Command(() =>
            {
                Tasks = new ObservableCollection<TaskModel>(Tasks);
            });
          

           
            
        }
    }
    

