using System;
using OptiSourceProject.Models;

namespace OptiSourceProject.Services
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        User Create(User user, string password);
    }
}
