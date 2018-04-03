using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ERPQuala.Crosscutting.Model.Request;
using ERPQuala.Crosscutting.Model.Response;
using ERPQuala.Crosscutting.Model.Response.BaseResponse;
using ERPQuala.DAL.User.Reposiroty;

namespace ERPQuala.BAL.UserBAL
{
    public class UserBl : IUserBl
    {
        private IUserDal _userDal;
        public UserBl(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public Task<UserResponse> CreateUserAsync(UserRequest user)
        {
            return _userDal.AddUser(user);
        }

        public Task<UserResponse> GetUserAsync(UserRequest user)
        {
            return _userDal.GetUserById(user);
        }
    }
}
