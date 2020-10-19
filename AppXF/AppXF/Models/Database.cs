using SQLite;
using System;
using System.Collections.Generic;
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
    }
}
