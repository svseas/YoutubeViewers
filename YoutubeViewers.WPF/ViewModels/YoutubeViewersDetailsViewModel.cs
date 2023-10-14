using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeViewers.WPF.ViewModels
{
    public class YoutubeViewersDetailsViewModel : ViewModelBase
    {
        public static implicit operator YoutubeViewersDetailsViewModel(YoutubeViewersListingViewModel v)
        {
            throw new NotImplementedException();
        }
    }
}
