using dotNetCore6Static.Models;
using Microsoft.EntityFrameworkCore;
using dotNetCore6Static.Models;

namespace dotNetCore6Static.DAL
{
    public class UserDAL : IUserDAL
    {
        private readonly personContext _context;

        public UserDAL(personContext context)
        {
            _context = context;
        }
        public async Task<List<Person>> getUsers()
        {
            try
            {
               // using (var db = new personContext())
                //{
                    return _context.personList.ToList();
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null; 
            }
         

        }


        public async Task<bool> saveUser(Person user)
        {
            try
            {
                // using (var db = new personContext())
                // {
                _context.personList.Add(user);
                _context.SaveChanges();
                    return true;
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public async Task<bool> putUser(Person user)
        {
            try
            {
                //using (var db = new personContext())
                //{
                    var item = _context.personList.Where(u=>u.Code == user.Code).FirstOrDefault();
                    if(item != null)
                    {
                        item.Name = user.Name;
                        _context.SaveChanges();
                    }
                    return true;

              //  }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public async Task<bool> deleteUser(Person user)
        {
            try
            {
               // using (var db = new personContext())
              //  {
                    var item = _context.personList.Where(u => u.Code == user.Code).FirstOrDefault();
                    if( item != null)
                    {
                    _context.Entry(item).State = EntityState.Deleted;
                    _context.SaveChanges();
                    }
                    return true;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
