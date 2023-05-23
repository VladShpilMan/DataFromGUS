using PicturesOfCSO.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFromGUS.Interface
{
    public interface IGUSdbwAreaAPIService
    {
        Task<ObservableCollection<Area>> GetAreasDataAsync();
    }
}
