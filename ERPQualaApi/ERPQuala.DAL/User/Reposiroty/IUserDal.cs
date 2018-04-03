using ERPQuala.Crosscutting.Model.Request;
using ERPQuala.Crosscutting.Model.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERPQuala.DAL.User.Reposiroty
{
    public interface IUserDal
    {
        Task<UserResponse> AddUser(UserRequest product);
        Task<UserResponse> GetUserById(UserRequest product);
    }
}
