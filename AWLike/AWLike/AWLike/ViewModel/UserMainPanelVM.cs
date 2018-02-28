using AWLike.Models;
using AWLike.Models.GameObjects;
using AWLike.Models.Interfaces;
using AWLike.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
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

            GamesAvailable.CollectionChanged += Names_CollectionChanged;
            GamesIn.CollectionChanged += Names_CollectionChanged;

            LoadGamesAvailable();
            
        }

        static void Names_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            Debug.WriteLine("Change type: " + e.Action);
            if (e.NewItems != null)
            {
                Debug.WriteLine("Items added: ");
                foreach (var item in e.NewItems)
                {
                    Debug.WriteLine(item);
                }
            }

            if (e.OldItems != null)
            {
                Debug.WriteLine("Items removed: ");
                foreach (var item in e.OldItems)
                {
                    Debug.WriteLine(item);
                }
            }
        }

        public async void LoadGamesAvailable()
        {
            _GamesAvailable =  new ObservableCollection<GameInfo>(await GameService.GetAllAvailable());
        }        
    }
}
