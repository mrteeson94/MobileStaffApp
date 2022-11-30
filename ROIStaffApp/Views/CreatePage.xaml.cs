using ROIStaffApp.Models;
using ROIStaffApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace ROIStaffApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreatePage : ContentPage
    {
        public CreatePage()
        {
            InitializeComponent();
            BindingContext = new CreatePageViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetStaffAsync();
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
                await App.Database.SaveStaffAsync(new Staff
                {
                    Name = nameEntry.Text,
                    Phone = phoneNoEntry.Text,
                    Department = DepartmentEntry.Text,
                    Street = streetEntry.Text,
                    City = cityEntry.Text,
                    State = stateEntry.Text,
                    Zip = int.Parse(zipEntry.Text),
                    Country = countryEntry.Text,
                });
                nameEntry.Text = phoneNoEntry.Text = DepartmentEntry.Text = streetEntry.Text = cityEntry.Text = stateEntry.Text = zipEntry.Text = countryEntry.Text = string.Empty;
                collectionView.ItemsSource = await App.Database.GetStaffAsync();
            }
        }
    }
}