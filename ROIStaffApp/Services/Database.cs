using ROIStaffApp.Models;
using SQLite;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace ROIStaffApp.Services
{
    public static class Database
    {
        static SQLiteAsyncConnection db;
        static async Task Init()
        {
            if (db != null)
                return;

            // Get an absolute path to the database file
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "MyData.db");

            db = new SQLiteAsyncConnection(databasePath);

            await db.CreateTableAsync<Staff>();
        }

        public static async Task AddStaff(string name, string phone, string depart, string st, string city, string state, int zip, string country)
        {
            await Init();
            var staff = new Staff
            {
                Name = name,
                Phone = phone,
                Department = depart,
                Street = st,
                City = city,
                State = state,
                Zip = zip,
                Country = country,
            };
            var id = await db.InsertAsync(staff);
        }
        public static async Task RemoveStaff(int id)
        {
            await Init();

            await db.DeleteAsync<Staff>(id);
        }
        public static async Task<IEnumerable<Staff>> GetStaff()
        {
            await Init();
            var staff = await db.Table<Staff>().ToListAsync();
                return staff;
        }
        public static async Task EditStaff(Staff staff)
        {
            await Init();
            await db.UpdateAsync(staff);
        }
    }
}


//OLD Database code
//readonly SQLiteAsyncConnection _database;
//public Database(string dbPath)
//{
//    _database = new SQLiteAsyncConnection(dbPath);
//    _database.CreateTableAsync<Staff>().Wait();
//}

//public Task<List<Staff>> GetStaffAsync()
//{
//    return _database.Table<Staff>().ToListAsync();
//}

//public Task<int> SaveStaffAsync(Staff staff)
//{
//    return _database.InsertAsync(staff);
//}