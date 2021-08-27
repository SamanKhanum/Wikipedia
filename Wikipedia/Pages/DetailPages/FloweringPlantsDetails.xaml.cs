using System;
using System.Linq;
using Wikipedia.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wikipedia.Pages.DetailPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty(nameof(Name), "name")]
    public partial class FloweringPlantsDetails : ContentPage
    {
        public string Name

        {
            set
            {
                Loadflower(value);
            }
        }


        public FloweringPlantsDetails()
        {
            InitializeComponent();
        }

        void Loadflower(string name)
        {
            try
            {
                Plant plant = FloweringPlantsData.flower.FirstOrDefault(a => a.Name == name);
                BindingContext = plant;
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to load flower.");
            }
        }
    }
}
