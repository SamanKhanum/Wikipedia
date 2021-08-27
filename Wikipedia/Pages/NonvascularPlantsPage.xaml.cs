using System.Linq;
using Wikipedia.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wikipedia.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NonvascularPlantsPage : ContentPage
    {
        public NonvascularPlantsPage()
        {
            InitializeComponent();
        }

        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string nonvascularName = (e.CurrentSelection.FirstOrDefault() as Plant).Name;

            await Shell.Current.GoToAsync($"beardetails?name={nonvascularName}");
        }
    }
}