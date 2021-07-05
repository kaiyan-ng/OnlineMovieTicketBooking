using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBookingApp.Services
{
    public interface IWebRepo<T, K>
    {
        Task<K> Add(T t);
        public Task<ICollection<T>> GetAll();
        Task<T> Get(K k);
        Task<T> Edit(K k, T t);
        Task<T> Delete(K k);
    }
}
