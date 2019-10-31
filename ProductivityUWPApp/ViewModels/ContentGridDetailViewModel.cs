using System;
using System.Linq;
using System.Threading.Tasks;

using GalaSoft.MvvmLight;

using ProductivityUWPApp.Core.Models;
using ProductivityUWPApp.Core.Services;

namespace ProductivityUWPApp.ViewModels
{
    public class ContentGridDetailViewModel : ViewModelBase
    {
        private SampleOrder _item;

        public SampleOrder Item
        {
            get { return _item; }
            set { Set(ref _item, value); }
        }

        public ContentGridDetailViewModel()
        {
        }

        public async Task InitializeAsync(long orderID)
        {
            var data = await SampleDataService.GetContentGridDataAsync();
            Item = data.First(i => i.OrderID == orderID);
        }
    }
}
