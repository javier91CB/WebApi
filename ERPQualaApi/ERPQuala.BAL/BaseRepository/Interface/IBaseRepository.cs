using System.Net.Http;
using System.Threading.Tasks;

namespace ERPQuala.BAL.BaseRepository.Interface
{
    public interface IBaseRepository<T>
    {
        Task<HttpResponseMessage> UpdateAsync(T parameters);
    }
}
