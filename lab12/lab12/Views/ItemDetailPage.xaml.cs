using lab12.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace lab12.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}