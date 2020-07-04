using System.Collections.Generic;
using TokenDemoDonNetCore3._1.Entities;
using TokenDemoDonNetCore3._1.Models;

namespace TokenDemoDonNetCore3._1.Services
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model, string ipAddress);
        AuthenticateResponse RefreshToken(string token, string ipAddress);
        bool RevokeToken(string token, string ipAddress);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}
