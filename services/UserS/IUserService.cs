using prov.Models;
using System;
using System.Collections.Generic;

namespace prov.services.UserS
{
    public interface IUserService
    {
        User GetUserById(int userId);
        Task<IEnumerable<User>> GetAllUsers();
        Task CreateUser(User user);
        Task UpdateUser(User user);
        Task DeleteUser(int userId);
    }
}
