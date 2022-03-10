using MyGraduateClient.Views.UWP;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyGraduateClient.ViewModels
{
    class LoginViewModel: BaseViewModel
    {
        public ICommand NavigCentralCommand { get; set; }
        public LoginViewModel(INavigation navigation): base(navigation)
        {
            NavigCentralCommand = new Command(async () => await OnNavCentralPage());
        }

        private async Task OnNavCentralPage()
        {
            await Navigation.PushAsync(new CentralPage());
        }
    }
}
