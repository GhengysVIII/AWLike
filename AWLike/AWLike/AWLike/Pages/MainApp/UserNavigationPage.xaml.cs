using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AWLike.Models;
using AWLike.ViewModel;
using AWLike.Services;

namespace AWLike
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserNavigationPage : TabbedPage
	{
		public UserNavigationPage (ConnectedUser user)
		{

            BindingContext = this;
            //Children.Add(new PlayedGameList(user));
            //Children.Add(new PlayedGameList(user));

            InitializeComponent ();
            Children.Add(new PlayedGameList(user) { Title = "Your games" });
            Children.Add(new GameList(user) { Title = "Choose a game" });
            Children.Add(new UserStats(user) { Title = "Your stats" });

        }
    }
}