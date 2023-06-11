using dotNetCore6Ex.Models;

namespace dotNetCore6Ex.BL
{
    public interface IUserBL
    {
        Task<List<User>> getUsers();
        Task<bool> saveUser(User user);
        Task<bool> putUser(User user);
        Task<bool> deleteUser(User user);


    }
}
