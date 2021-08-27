using System;
using System.Linq;
using Wikipedia.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wikipedia.Pages.DetailPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty(nameof(Name), "name")]
    public partial class Ferns_OtherLowerVascularPlantsDetails : ContentPage
    {
        public string Name

        {
            set
            {
                Loadferns(value);
            }
        }


        public Ferns_OtherLowerVascularPlantsDetails()
        {
            InitializeComponent();
        }

        void Loadferns(string name)
        {
            try
            {
                Plant plant = Ferns_OtherLowerVascularPlantsData.ferns.FirstOrDefault(a => a.Name == name);
                BindingContext = plant;
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to load ferns.");
            }
        }
    }
}
