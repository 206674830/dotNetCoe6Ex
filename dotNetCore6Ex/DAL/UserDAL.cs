using dotNetCore6Ex.Models;
using Microsoft.EntityFrameworkCore;

namespace dotNetCore6Ex.DAL
{
    public class UserDAL : IUserDAL
    {
        public async Task<List<User>> getUsers()
        {
            try
            {
                using (var db = new UserContext())
                {
                    return db.Users.ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null; 
            }
         

        }


        public async Task<bool> saveUser(User user)
        {
            try
            {
                using (var db = new UserContext())
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public async Task<bool> putUser(User user)
        {
            try
            {
                using (var db = new UserContext())
                {
                    var item = db.Users.Where(u=>u.Code == user.Code).FirstOrDefault();
                    if(item != null)
                    {
                        item.Name = user.Name;
                        db.SaveChanges();
                    }
                    return true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public async Task<bool> deleteUser(User user)
        {
            try
            {
                using (var db = new UserContext())
                {
                    var item = db.Users.Where(u => u.Code == user.Code).FirstOrDefault();
                    if( item != null)
                    {
                      db.Entry(item).State = EntityState.Deleted;
                        db.SaveChanges();
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
