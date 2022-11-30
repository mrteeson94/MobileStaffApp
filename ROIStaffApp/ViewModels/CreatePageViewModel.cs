using System;
using System.Collections.Generic;
using System.Text;
using MvvmHelpers;
using MvvmHelpers.Commands;
using ROIStaffApp.Models;

namespace ROIStaffApp.ViewModels
{
    internal class CreatePageViewModel : ViewModelBase
    {
        public ObservableRangeCollection<Department> Staff { get; set; }

        public CreatePageViewModel()
        {
            Staff = new ObservableRangeCollection<Department>();

        }
    }
}
