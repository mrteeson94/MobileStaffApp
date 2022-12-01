using MvvmHelpers;
using MvvmHelpers.Commands;
using ROIStaffApp.Models;
using ROIStaffApp.Services;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace ROIStaffApp.ViewModels
{
    internal class HomePageViewModel : ViewModelBase
    {
        public ObservableRangeCollection<Staff> Staff { get; set; }
        public AsyncCommand RefreshCommand { get; }
        public AsyncCommand AddCommand { get; }
        public AsyncCommand<Staff> RemoveCommand { get; }

        public HomePageViewModel()
        {
            RefreshCommand = new AsyncCommand(Refresh);
        }

        async Task Refresh()
        {
            IsBusy = true;

            await Task.Delay(500);

            var staff = await Database.GetStaff();

            Staff.AddRange(Staff);

            IsBusy = false;
        }


    }
}
