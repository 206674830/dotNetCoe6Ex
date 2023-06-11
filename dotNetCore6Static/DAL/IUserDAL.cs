using dotNetCore6Static.Models;

namespace dotNetCore6Static.DAL
{
    public interface IUserDAL
    {
        Task<List<Person>> getUsers();
        Task<bool> saveUser(Person user);
        Task<bool> putUser(Person user);
        Task<bool> deleteUser(Person user);
    }
}
