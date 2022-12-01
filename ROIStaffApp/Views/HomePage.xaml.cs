using ROIStaffApp.Models;
using ROIStaffApp.Services;
using ROIStaffApp.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ROIStaffApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {

        public HomePage()
        {
            InitializeComponent();
            BindingContext = new HomePageViewModel();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreatePage());
        }
        protected override async void OnAppearing() 
        {
            base.OnAppearing();
                ListView.ItemsSource = await Services.Database.GetStaff();
        }

        //private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    var staff = e.SelectedItem as Staff;
        //    var staffPage = new StaffPage();
        //    staffPage.BindingContext = staff;
        //    await Navigation.PushAsync(staffPage);
        //}

        async void Button_Clicked_1(object sender, EventArgs e)
        {
            var item = sender as Button;
            var staff = item.CommandParameter as Staff;
            await Navigation.PushAsync(new StaffPage(staff));
        }
    }
}