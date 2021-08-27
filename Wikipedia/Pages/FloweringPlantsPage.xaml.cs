using System.Linq;
using Wikipedia.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wikipedia.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FloweringPlantsPage : ContentPage
    {
        public FloweringPlantsPage()
        {
            InitializeComponent();
        }

        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string plantName = (e.CurrentSelection.FirstOrDefault() as Plant).Name;

            await Shell.Current.GoToAsync($"beardetails?name={plantName}");
        }
    }
}