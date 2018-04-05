using ERPQuala.Crosscutting.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERPQuala.DAL.User.Reposiroty
{
    public interface IUserDal
    {
        Task<IEnumerable<Crosscutting.Model.User>> AddUser(Crosscutting.Model.User product);
        Task<IEnumerable<Crosscutting.Model.User>> GetUserById(Crosscutting.Model.User user);
    }
}
