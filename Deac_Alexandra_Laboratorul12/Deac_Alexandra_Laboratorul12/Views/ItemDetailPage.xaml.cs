using Deac_Alexandra_Laboratorul12.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Deac_Alexandra_Laboratorul12.Views
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