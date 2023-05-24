using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IKEAMobil.Models
{
    public class ProductManager
    {
        readonly SQLiteAsyncConnection database;

        public ProductManager(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Furniture>().Wait();
        }

        public Task<List<Furniture>> GetAllAsync()
        {
            //Get all notes.
            return database.Table<Furniture>().ToListAsync();
        }

        public Task<Furniture> GetAsync(string id)
        {
            // Get a specific note.
            return database.Table<Furniture>()
                            .Where(i => i.Id == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveAsync(Furniture note)
        {
            //if (note.Id != "")
            //{
            //    // Update an existing note.
            //    return database.UpdateAsync(note);
            //}
            //else
            //{
            // Save a new note.
            return database.InsertAsync(note);
            //}
        }
    }
}
