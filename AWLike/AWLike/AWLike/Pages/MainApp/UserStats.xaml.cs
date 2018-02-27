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
	public partial class UserStats : ContentPage
	{
		public UserStats(ConnectedUser u)
        {
            BindingContext = new UserMainPanelVM(new PageChange(), u);
            InitializeComponent ();
		}
	}
}