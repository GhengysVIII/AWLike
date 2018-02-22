using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AWLike.Models.Interfaces
{
    public interface IPageChange
    {
        Task PushModal(Page page);
        Task PushPage(Page page);
        Task PopModal();
        Task PopPage();
    }
}
