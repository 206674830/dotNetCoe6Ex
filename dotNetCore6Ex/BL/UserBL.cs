using dotNetCore6Ex.DAL;
using dotNetCore6Ex.Models;

namespace dotNetCore6Ex.BL
{
    public class UserBL : IUserBL
    {
        IUserDAL userDAL;
        public UserBL(IUserDAL userDAL)
        {
            this.userDAL = userDAL;
        }
        public async Task<List<User>> getUsers()
        {
            return await userDAL.getUsers();
        }


        public async Task<bool> saveUser(User user)
        {
            return await userDAL.saveUser(user);
        }
        public async Task<bool> putUser(User user)
        {
            return await userDAL.putUser(user);
        }
        public async Task<bool> deleteUser(User user)
        {
            return await userDAL.deleteUser(user);
        }
    }
}
