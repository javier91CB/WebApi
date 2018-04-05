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

        public Task<IEnumerable<Crosscutting.Model.User>> CreateUserAsync(Crosscutting.Model.User user)
        {
            return _userDal.AddUser(user);
        }

        public Task<IEnumerable<Crosscutting.Model.User>> GetUserAsync(Crosscutting.Model.User user)
        {
            return _userDal.GetUserById(user);
        }
    }
}
