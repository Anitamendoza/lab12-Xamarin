using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace lab12.Models
{
    public class TaskModel : INotifyPropertyChanged
    {
        public string Title { get; set; }
        public string Descripcion { get; set; }
        public string Status { get; set; }

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

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
