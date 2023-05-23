using DataFromGUS.Interface;
using DataFromGUS.Service;
using PicturesOfCSO.Model;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PicturesOfCSO.ViewModel
{
    class MainWindowModel : BaseViewModelClass
    {
        private UserControl _currentWindow;

        public UserControl CurrentWindow
        {
            get { return _currentWindow; }
            set
            {
                _currentWindow = value;
                OnPropertyChanged("CurrentWindow");
            }
        }
    }
}
