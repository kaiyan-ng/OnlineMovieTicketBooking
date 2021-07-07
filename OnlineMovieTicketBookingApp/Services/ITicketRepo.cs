using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBookingApp.Services
{
    public interface ITicketRepo<T, K>
    {
        public K Add(T t);
        public ICollection<T> GetAll();

        public T Get(K k);
        public ICollection<T> GetByMovieId(K k);
        public T Edit(K k, T t);
        public bool Delete(K k);
    }
}
