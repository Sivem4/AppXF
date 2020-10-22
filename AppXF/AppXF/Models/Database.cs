using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace AppXF.Models
{
    public class Database
    {
        readonly SQLiteAsyncConnection database;

        public Database(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<M_Person>().Wait();
        }

        
        public Task<int> SavePersonAsync(M_Person person)
        {
            return database.InsertAsync(person);
        }
        public Task DeletePersonAsync(M_Person person)
        {
            return database.DeleteAsync(person);
        }

        public Task<List<M_Person>> GetPeopleAsync()
        {
            return database.Table<M_Person>().ToListAsync();
        }
    }
}
