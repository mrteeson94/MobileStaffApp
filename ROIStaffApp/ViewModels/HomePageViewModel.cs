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
            //Title = "Staff Directory Home";
            Staff = new ObservableRangeCollection<Staff>();
            Staff.Add(new Staff {Id = 1, Name = "John Smith",  Phone = "02 9988 2211", Department="Marketing"});
            Staff.Add(new Staff { Id = 2, Name = "Sue White", Phone = "03 8899 2255", Department = "IT"});
            Staff.Add(new Staff { Id = 3, Name = "Bob O'Bits", Phone = "05 7788 2255", Department = "Finance" });
            Staff.Add(new Staff { Id = 4, Name = "Mark Sam", Phone = "05 7788 2255", Department = "Marketing" });
            Staff.Add(new Staff { Id = 5, Name = "Jacky Chen", Phone = "05 7788 2255", Department = "IT"});
            Staff.Add(new Staff { Id = 6, Name = "James O'Neil", Phone = "05 7788 2255", Department = "IT"});

            RefreshCommand = new AsyncCommand(Refresh);
        }


        async Task Remove(Staff staff)
        {
            await Database.RemoveStaff(staff.Id);
            await Refresh();
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
