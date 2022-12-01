using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MvvmHelpers;
using MvvmHelpers.Commands;
using ROIStaffApp.Models;
using ROIStaffApp.Services;

namespace ROIStaffApp.ViewModels
{
    internal class CreatePageViewModel : ViewModelBase
    {
        public ObservableRangeCollection<Staff> Staff { get; set; }
        public AsyncCommand AddCommand { get; }

        public CreatePageViewModel()
        {
            Staff = new ObservableRangeCollection<Staff>();

        }
    }
}
