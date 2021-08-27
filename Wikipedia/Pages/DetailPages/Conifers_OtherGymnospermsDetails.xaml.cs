using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wikipedia.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wikipedia.Pages.DetailPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty(nameof(Name), "name")]
    public partial class Conifers_OtherGymnospermsDetails : ContentPage
    {
        public string Name

        {
            set
            {
                Loadconifers(value);
            }
        }


        public Conifers_OtherGymnospermsDetails()
        {
            InitializeComponent();
        }

        void Loadconifers(string name)
        {
            try
            {
                Plant plant = Conifers_OtherGymnospermsData.conifers.FirstOrDefault(a => a.Name == name);
                BindingContext = plant;
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to load conifers.");
            }
        }
    }
}



