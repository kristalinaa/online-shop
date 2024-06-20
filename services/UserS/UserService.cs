using prov.Data;
using prov.Models;
using prov.Repository.UserRepository;
using System;

namespace prov.services.UserS
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly ProvDbContext _context;

        public UserService(IUserRepository userRepository, ProvDbContext context)
        {
            _userRepository = userRepository;
            _context = context;
        }

        public User GetUserById(int userId)
        {
            return _userRepository.GetById(userId);
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            try
            {
                return await _userRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw ex; // Rethrow the exception
            }
        }

        public async Task CreateUser(User user)
        {
            try
            {
                _userRepository.Add(user);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex) {
                throw new ApplicationException("Error creating user", ex);

            }
        }

        public async Task UpdateUser(User user)
        {
             _userRepository.Update(user);
        }

        public async Task DeleteUser(int userId)
        {
            _userRepository.Delete(userId);
        }
    }
    //public class UserService : IUserService
    //{
    //    private readonly ProvDbContext dbContext;
    //    private readonly UserRepository userRepository;
    //    public UserService(ProvDbContext dbContext, UserRepository userRepository)
    //    {
    //        dbContext = dbContext;
    //        this.userRepository = userRepository;
    //    }

    //    public void CreateUser(User user)
    //    {
    //        var User = new User()
    //        {
    //            Id = user.Id,
    //            Name = user.Name,
    //            Surname = user.Surname,
    //            Adress = user.Adress,
    //            Email = user.Email,
    //            Password = user.Password,
    //            PhoneNumber = user.PhoneNumber

    //        };
    //        dbContext.User.Add(User);
    //        dbContext.SaveChanges();

    //    }
    //    public List<User> findAll()
    //    {
    //        var optional = userRepository.findById(Id);
    //    }

    //    public User findById(int Id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void UpdateUser(User user)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void DeleteUser(User user)
    //    {
    //        throw new NotImplementedException();
    //    }






    //}



}
