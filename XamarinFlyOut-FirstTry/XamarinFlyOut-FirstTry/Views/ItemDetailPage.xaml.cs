using System.ComponentModel;
using Xamarin.Forms;
using XamarinFlyOut_FirstTry.ViewModels;

namespace XamarinFlyOut_FirstTry.Views
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