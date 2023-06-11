using dotNetCore6Static.Models;

namespace dotNetCore6Static.BL
{
    public interface IUserBL
    {
        Task<List<Person>> getUsers();
        Task<bool> saveUser(Person user);
        Task<bool> putUser(Person user);
        Task<bool> deleteUser(Person user);


    }
}
