using MvvmHelpers;
using MvvmHelpers.Commands;
using ROIStaffApp.Models;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace ROIStaffApp.ViewModels
{
    internal class HomePageViewModel : ViewModelBase
    {
        public ObservableRangeCollection<Department> Staff { get; set; }
        public AsyncCommand RefreshCommand { get; }

        public HomePageViewModel()
        {
            //Title = "Staff Directory Home";
            Staff = new ObservableRangeCollection<Department>();
            Staff.Add(new Department {Id = 1, Name = "John Smith",  Phone = "02 9988 2211", DepartName="Marketing"});
            Staff.Add(new Department { Id = 2, Name = "Sue White", Phone = "03 8899 2255", DepartName = "IT"});
            Staff.Add(new Department { Id = 3, Name = "Bob O'Bits", Phone = "05 7788 2255", DepartName = "Finance" });
            Staff.Add(new Department { Id = 4, Name = "Mark Sam", Phone = "05 7788 2255", DepartName = "Marketing" });
            Staff.Add(new Department { Id = 5, Name = "Jacky Chen", Phone = "05 7788 2255", DepartName = "IT"});
            Staff.Add(new Department { Id = 6, Name = "James O'Neil", Phone = "05 7788 2255", DepartName = "IT"});

            RefreshCommand = new AsyncCommand(Refresh);
        }
        async Task Refresh()
        {
            IsBusy = true;
            await Task.Delay(500);
            IsBusy = false;
        }

    }
}
