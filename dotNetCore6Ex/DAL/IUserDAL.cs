using dotNetCore6Ex.Models;

namespace dotNetCore6Ex.DAL
{
    public interface IUserDAL
    {
        Task<List<User>> getUsers();
        Task<bool> saveUser(User user);
        Task<bool> putUser(User user);
        Task<bool> deleteUser(User user);
    }
}
