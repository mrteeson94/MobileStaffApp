using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ROIStaffApp.Models
{
    public class Staff
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Department { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string Country { get; set; }

    }

    public class Department : Staff
    {
        [Indexed]
        public int DepartId { get; set; }
        public string DepartName { get; set; }
    }
}
