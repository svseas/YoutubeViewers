using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace YoutubeViewers.WPF.ViewModels
{
    class YoutubeViewersViewModel : ViewModelBase
    {
        public ICommand? AddYoutubeViewersCommand { get; }

        public YoutubeViewersListingViewModel? YoutubeViewersListingViewModel { get; }
        public YoutubeViewersDetailsViewModel? YoutubeViewersDetailsViewModel { get; }

        public YoutubeViewersViewModel()
        {
            YoutubeViewersListingViewModel = new YoutubeViewersListingViewModel();
            YoutubeViewersDetailsViewModel = new YoutubeViewersDetailsViewModel();
        }
    }
}
