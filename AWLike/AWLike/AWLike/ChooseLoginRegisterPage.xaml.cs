using AWLike.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AWLike
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChooseLoginRegisterPage : ContentPage
	{
		public ChooseLoginRegisterPage ()
		{
            BindingContext = new SignInRegisterVM();
			InitializeComponent ();
		}

        public async void LoadModalLoginPage()
        {
            await Navigation.PushModalAsync(new LoginPage());

        }


    }
}