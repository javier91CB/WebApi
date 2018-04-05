using ERPQuala.Crosscutting.Model.Request;
using ERPQuala.Crosscutting.Model.Response;
using ERPQuala.Crosscutting.Model.Response.BaseResponse;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ERPQuala.BAL.UserBAL
{
    public interface IUserBl
    {
        Task<IEnumerable<Crosscutting.Model.User>> CreateUserAsync(Crosscutting.Model.User user);
        Task<IEnumerable<Crosscutting.Model.User>> GetUserAsync(Crosscutting.Model.User user);
    }
}
