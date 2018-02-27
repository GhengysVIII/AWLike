using AWLike.Models;
using AWLike.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AWLike.ViewModel
{
    public class UserMainPanelVM
    {
        ConnectedUser user;
        private readonly IPageChange _navigation;

        public UserMainPanelVM(IPageChange P, ConnectedUser user)
        {            
            _navigation = P;
            this.user = user;
        }

    }
}
