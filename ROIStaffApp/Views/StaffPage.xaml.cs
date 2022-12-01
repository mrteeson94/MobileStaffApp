using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ROIStaffApp.Models;
using ROIStaffApp.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ROIStaffApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StaffPage : ContentPage
    {
        private Models.Staff _staff;
        public StaffPage(Models.Staff staff)
        {
            InitializeComponent();
            _staff = staff;

            labelId.Text = "ID: " + _staff.Id.ToString();
            nameEntry.Text = _staff.Name;
            phoneEntry.Text = _staff.Phone;
            DepartmentEntry.Text = _staff.Department;
            streetEntry.Text = _staff.Street;
            cityEntry.Text = _staff.City;
            stateEntry.Text = _staff.State;
            zipEntry.Text = _staff.Zip.ToString();
            countryEntry.Text = _staff.Country;
        }
        /// <summary>
        /// Method saves updated fields and stores into db
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Button_Clicked(object sender, EventArgs e)
        {
            _staff.Name = nameEntry.Text;
            _staff.Phone = phoneEntry.Text;
            _staff.Department = DepartmentEntry.Text;
            _staff.City = cityEntry.Text;
            _staff.State = stateEntry.Text;
            _staff.Zip = Convert.ToInt32(zipEntry.Text);
            _staff.Country = countryEntry.Text;

            await Services.Database.EditStaff(_staff);
            await DisplayAlert("Update!", $"{_staff.Name} details updated!", "OK");
            await Navigation.PushAsync(new HomePage());


        }
        /// <summary>
        /// Method deletes staff records 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var result = await DisplayAlert("Delete", $"Delete {_staff.Name} from ROI database", "Yes", "No");
            if (result)
            {
                await Services.Database.RemoveStaff(_staff.Id);
                await Navigation.PushAsync(new HomePage());
            }
        }
    }
}