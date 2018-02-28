using AWLike.Models;
using AWLike.Models.GameObjects;
using AWLike.Models.Interfaces;
using AWLike.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AWLike.ViewModel
{
    public class UserMainPanelVM
    {
        ConnectedUser user;
        private readonly IPageChange _navigation;

        private ObservableCollection<GameInfo> _GamesAvailable;
        public ObservableCollection<GameInfo> GamesAvailable
        {
            get { return _GamesAvailable; }
            set {
                    _GamesAvailable = value;
                    OnPropertyChange(GamesAvailable);
            }
        }

        private ObservableCollection<GameInfo> _GamesIn;

        public ObservableCollection<GameInfo> GamesIn
        {
            get { return _GamesIn; }
            set { _GamesIn = value; }
        }

        

        public UserMainPanelVM(IPageChange P, ConnectedUser user)
        {            
            _navigation = P;
            this.user = user;

            LoadGamesAvailable();
            GamesAvailable.


        }
        
        public async void LoadGamesAvailable()
        {
            _GamesAvailable =  new ObservableCollection<GameInfo>(await GameService.GetAllAvailable());
        }
        
    }
}
