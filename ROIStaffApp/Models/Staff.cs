using SQLite;

namespace ROIStaffApp.Models
{
    public class Staff
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        [MaxLength(12)]
        public string Phone { get; set; }
        public string Department { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        [MaxLength(3)]
        public string State { get; set; }
        [MaxLength(4)]
        public int Zip { get; set; }
        public string Country { get; set; }
    }
}
