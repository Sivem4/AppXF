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
        readonly SQLiteAsyncConnection databaseConnection;

        public Database(string dbPath)
        {
            databaseConnection = new SQLiteAsyncConnection(dbPath);
            databaseConnection.CreateTableAsync<M_Person>().Wait();

            //var syncDatabase = database.GetConnection();
            //People = new ObservableCollection<M_Person>(syncDatabase.Table<M_Person>().ToList());
        }

        
        public Task<int> SavePersonAsync(M_Person person)
        {
            return databaseConnection.InsertAsync(person);
        }
        public Task DeletePersonAsync(M_Person person)
        {
            return databaseConnection.DeleteAsync(person);
        }

        public Task<List<M_Person>> GetPeopleAsync()
        {
            return databaseConnection.Table<M_Person>().ToListAsync();
        }
        //public async Task<ObservableCollection<M_Person>> GetPeopleAsync()
        //{
        //    var list = await database.Table<M_Person>().ToListAsync();
        //    return new ObservableCollection<M_Person>(list);
        //}
    }
}
