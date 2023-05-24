using System;
using System.Collections.Generic;
using System.Text;
using IKEAMobil.Services;

namespace IKEAMobil.Models
{
    public class User
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("N");
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string PhoneNumber { get; set; }

        public bool UserControl()
        {
            User ds = UserDataSource.Items.Find(x => x.Email == this.Email.Trim() && x.Password == this.Password);
            if (ds != null)
            {
                Session.LoggedInUserData = ds;
                Session.LoginDate = DateTime.Now;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UserRegister()
        {
            UserDataSource userService = new UserDataSource();

            return userService.AddItemAsync(this).Result;
        }
    }
}
