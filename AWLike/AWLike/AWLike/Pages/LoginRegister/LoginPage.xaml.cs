using AWLike.Models;
using AWLike.Services;
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
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
            BindingContext = new SignInRegisterVM(new PageChange());
            InitializeComponent ();
		}
	}
}