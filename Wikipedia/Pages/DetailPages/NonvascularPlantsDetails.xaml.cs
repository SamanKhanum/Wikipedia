using System;
using System.Linq;
using Wikipedia.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wikipedia.Pages.DetailPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty(nameof(Name), "name")]
    public partial class NonvascularPlantsDetails : ContentPage
    {
        public string Name

        {
            set
            {
                Loadnonvascular(value);
            }
        }


        public NonvascularPlantsDetails()
        {
            InitializeComponent();
        }

        void Loadnonvascular(string name)
        {
            try
            {
                Plant plant = NonvascularPlantsData.nonvascular.FirstOrDefault(a => a.Name == name);
                BindingContext = plant;
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to load nonvascular.");
            }
        }
    }
}
