using System.Collections.Generic;
using System.Threading.Tasks;
using ERPQuala.Crosscutting.Model;
using ERPQuala.Crosscutting.Model.Request;
using ERPQuala.Crosscutting.Model.Response;

namespace ERPQuala.DAL.User.Reposiroty
{
    public class UserDal : IUserDal
    {
        private readonly WebAPIDataContext _webAPIDataContext;

        public UserDal(WebAPIDataContext webAPIDataContext)
        {
            _webAPIDataContext = webAPIDataContext;
        }

        public Task<IEnumerable<Crosscutting.Model.User>> AddUser(Crosscutting.Model.User user)
        {
            var response = _webAPIDataContext.User.AddAsync(user);
            _webAPIDataContext.SaveChanges();
            return Task.FromResult(response as IEnumerable<Crosscutting.Model.User>);
        }

        public Task<IEnumerable<Crosscutting.Model.User>> GetUserById(Crosscutting.Model.User user)
        {
            var response = _webAPIDataContext.User.FindAsync(user.UserName, user.Password);
            return Task.FromResult(response as IEnumerable<Crosscutting.Model.User>);
        }

    }
}
