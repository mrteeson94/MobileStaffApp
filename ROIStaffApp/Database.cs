using ROIStaffApp.Models;
using SQLite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ROIStaffApp
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;
        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Staff>().Wait();
        }

        public Task<List<Staff>> GetStaffAsync()
        {
            return _database.Table<Staff>().ToListAsync();
        }

        public Task<int> SaveStaffAsync(Staff staff)
        {
            return _database.InsertAsync(staff);
        }
    }
}
