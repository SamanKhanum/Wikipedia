using System.Linq;
using Wikipedia.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wikipedia.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cereals_Fruits_Nuts_VegetablesPage : ContentPage
    {
        public Cereals_Fruits_Nuts_VegetablesPage()
        {
            InitializeComponent();
        }

        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string cerealName = (e.CurrentSelection.FirstOrDefault() as Plant).Name;

            await Shell.Current.GoToAsync($"cerealdetails?name={cerealName}");
        }
    }
}