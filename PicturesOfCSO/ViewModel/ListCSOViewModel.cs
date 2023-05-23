using DataFromGUS.Interface;
using PicturesOfCSO.Model;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace PicturesOfCSO.ViewModel
{
    public class ListCSOViewModel : BaseViewModelClass
    {
        private ObservableCollection<Area> areas;

        public ObservableCollection<Area> Areas
        {
            get { return areas; }
            set
            {
                areas = value;
                OnPropertyChanged(nameof(Areas));
            }
        }

        private IGUSdbwAreaAPIService _gusdbwAreaAPIService { get; }

        public ListCSOViewModel(IGUSdbwAreaAPIService gusdbwAreaAPIService)
        {
            _gusdbwAreaAPIService = gusdbwAreaAPIService;
            GetAreasDataAsync();
        }

        private async Task GetAreasDataAsync()
        {
            Areas = await _gusdbwAreaAPIService.GetAreasDataAsync();
        }

    }
}
