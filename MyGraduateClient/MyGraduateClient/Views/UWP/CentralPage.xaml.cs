using MyGraduateClient.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyGraduateClient.Views.UWP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CentralPage : ContentPage
    {
        public CentralPage()
        {
            InitializeComponent();
            BindingContext = new CentralViewModel(Navigation);
        }
    }
}