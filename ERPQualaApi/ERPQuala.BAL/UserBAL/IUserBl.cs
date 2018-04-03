using ERPQuala.Crosscutting.Model.Request;
using ERPQuala.Crosscutting.Model.Response;
using ERPQuala.Crosscutting.Model.Response.BaseResponse;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ERPQuala.BAL.UserBAL
{
    public interface IUserBl
    {
        Task<UserResponse> CreateUserAsync(UserRequest user);
        Task<UserResponse> GetUserAsync(UserRequest user);
    }
}
