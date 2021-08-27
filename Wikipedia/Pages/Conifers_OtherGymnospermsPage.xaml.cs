using System.Linq;
using Wikipedia.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wikipedia.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Conifers_OtherGymnospermsPage : ContentPage
    {
        public Conifers_OtherGymnospermsPage()
        {
            InitializeComponent();
        }

        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string conifersName = (e.CurrentSelection.FirstOrDefault() as Plant).Name;

            await Shell.Current.GoToAsync($"beardetails?name={conifersName}");
        }
    }
}