using dotNetCore6Static.DAL;
using dotNetCore6Static.Models;

namespace dotNetCore6Static.BL
{
    public class UserBL : IUserBL
    {
        IUserDAL userDAL;
        public UserBL(IUserDAL userDAL)
        {
            this.userDAL = userDAL;
        }
        public async Task<List<Person>> getUsers()
        {
            return await userDAL.getUsers();
        }


        public async Task<bool> saveUser(Person user)
        {
            return await userDAL.saveUser(user);
        }
        public async Task<bool> putUser(Person user)
        {
            return await userDAL.putUser(user);
        }
        public async Task<bool> deleteUser(Person user)
        {
            return await userDAL.deleteUser(user);
        }
    }
}
