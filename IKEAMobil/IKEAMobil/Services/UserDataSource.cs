using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using IKEAMobil.Models;

namespace IKEAMobil.Services
{
    public class UserDataSource : IDataStore<User>
    {
        public static List<User> Items;

        public UserDataSource()
        {

        }

        public async Task<bool> AddItemAsync(User item)
        {
            Items.Add(item);

            return await Task.FromResult(true);
        }

        public Task<bool> DeleteItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetItemAsync(string id)
        {
            return await Task.FromResult(Items.FirstOrDefault(s => s.Id == id));
        }

        public Task<IEnumerable<User>> GetItemsAsync(bool forceRefresh = false)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateItemAsync(User item)
        {
            throw new NotImplementedException();
        }
    }
}
