using System;
using System.Linq;
using Wikipedia.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wikipedia.Pages.DetailPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty(nameof(Name), "name")]
    public partial class Cereals_Fruits_Nuts_VegetablesDetails : ContentPage
    {

        public string Name

        {
            set
            {
                LoadCereals(value);
            }
        }


        public Cereals_Fruits_Nuts_VegetablesDetails()
        {
            InitializeComponent();
        }

        void LoadCereals(string name)
        {
            try
            {
                Plant plant = Cereals_Fruits_Nuts_VegetablesData.Cereals.FirstOrDefault(a => a.Name == name);
                BindingContext = plant;
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to load Cereals.");
            }
        }
    }
}



