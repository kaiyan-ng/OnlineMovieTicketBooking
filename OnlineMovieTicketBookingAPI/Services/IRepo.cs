using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBookingAPI.Services
{
    public interface IRepo<T, K>
    {
        public K Add(T t);
        public ICollection<T> GetAll();
        public T Get(K k);
        public T Edit(K k, T t);
        public T Delete(K k);
    }
}
