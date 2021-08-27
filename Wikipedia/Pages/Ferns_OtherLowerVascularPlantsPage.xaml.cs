using System.Linq;
using Wikipedia.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wikipedia.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ferns_OtherLowerVascularPlantsPage : ContentPage
    {
        public Ferns_OtherLowerVascularPlantsPage()
        {
            InitializeComponent();
        }

        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fernName = (e.CurrentSelection.FirstOrDefault() as Plant).Name;

            await Shell.Current.GoToAsync($"beardetails?name={fernName}");
        }
    }
}