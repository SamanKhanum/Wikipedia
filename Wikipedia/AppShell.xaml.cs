using System;
using System.Collections.Generic;
using Wikipedia.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wikipedia
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        
            public Dictionary<string, Type> Routes { get; private set; } = new Dictionary<string, Type>();
       public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }

        void RegisterRoutes()
        {
            Routes.Add("Cereals_Fruits_Nuts_VegetablesDetails", typeof(Cereals_Fruits_Nuts_VegetablesPage));
            Routes.Add("Conifers_OtherGymnospermsDetails", typeof(Conifers_OtherGymnospermsPage));
            Routes.Add("Ferns_OtherLowerVascularPlantsDetails", typeof(Ferns_OtherLowerVascularPlantsPage));
            Routes.Add("FloweringPlantsDetails", typeof(FloweringPlantsPage));
            Routes.Add("NonvascularPlantsDetails", typeof(NonvascularPlantsPage));

            foreach (var item in Routes)
            {
                Routing.RegisterRoute(item.Key, item.Value);
            }
        }
    }
}