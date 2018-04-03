using ERPQuala.BAL.BaseRepository.Interface;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ERPQuala.BAL.BaseRepository.Class
{
    public class BaseRepository<T> : IBaseRepository<T>
    {
        //public override Task<HttpResponseMessage> UpdateAsync(T parameters)
        //{
        //    throw new NotImplementedException();
        //}
        public Task<HttpResponseMessage> UpdateAsync(T parameters)
        {
            throw new NotImplementedException();
        }
    }
}
