using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GestionContact.Client.Services.Http.Interfaces
{
    public interface IContactService<T>
    {
        Task<IEnumerable<T>> Get(int userId);
        Task<T> GetOne(int id, int userId);
        Task<HttpResponseMessage> Post(T entity);
        Task<HttpResponseMessage> Put(int id, T entity);
        Task<HttpResponseMessage> Delete(int id);
    }
}
