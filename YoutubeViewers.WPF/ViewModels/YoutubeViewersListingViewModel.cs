﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeViewers.WPF.ViewModels
{
    public class YoutubeViewersListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<YoutubeViewersListingItemViewModel> _youtubeViewersListingItemViewModels;
        public IEnumerable<YoutubeViewersListingItemViewModel> YoutubeViewersListingItemViewModel => _youtubeViewersListingItemViewModels;

        public YoutubeViewersListingViewModel()
        {
            _youtubeViewersListingItemViewModels = new ObservableCollection<YoutubeViewersListingItemViewModel>();
            _youtubeViewersListingItemViewModels.Add(new YoutubeViewersListingItemViewModel("Mary"));
            _youtubeViewersListingItemViewModels.Add(new YoutubeViewersListingItemViewModel("Sean"));
            _youtubeViewersListingItemViewModels.Add(new YoutubeViewersListingItemViewModel("Alan"));
        }
    }
}
