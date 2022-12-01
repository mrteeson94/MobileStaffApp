using MvvmHelpers;
using MvvmHelpers.Commands;
using ROIStaffApp.Models;
using ROIStaffApp.Services;
using ROIStaffApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace ROIStaffApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreatePage : ContentPage
    {
        public AsyncCommand AsyncCommand { get; }

        public CreatePage()
        {
            InitializeComponent();
            BindingContext = new CreatePageViewModel();
        }

        async void Button_Clicked(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameEntry.Text) &&
               !string.IsNullOrWhiteSpace(phoneNoEntry.Text) &&
               !string.IsNullOrWhiteSpace(DepartmentEntry.Text) &&
               !string.IsNullOrWhiteSpace(streetEntry.Text) &&
               !string.IsNullOrWhiteSpace(cityEntry.Text) &&
               !string.IsNullOrWhiteSpace(stateEntry.Text) &&
               !string.IsNullOrWhiteSpace(zipEntry.Text) &&
               !string.IsNullOrWhiteSpace(countryEntry.Text))
            {
                await Database.AddStaff(nameEntry.Text, phoneNoEntry.Text, DepartmentEntry.Text, streetEntry.Text, cityEntry.Text, (stateEntry.Text).ToUpper(), int.Parse(zipEntry.Text), countryEntry.Text);
                collectionView.ItemsSource = await Database.GetStaff();
            }
        }
    }
}