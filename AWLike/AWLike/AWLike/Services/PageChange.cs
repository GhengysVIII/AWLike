using AWLike.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AWLike.Services
{
    public class PageChange : IPageChange
    {
        public async Task PopModal()
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }

        public async Task PopPage()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }

        public async Task PushModal(Page page)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(page);

        }

        public async Task PushPage(Page page)
        {
            await Application.Current.MainPage.Navigation.PushAsync(page);
        }
    }
}
