using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    interface IRepository<T> where T : class
    {
        public void Add(T t);

        public List<T> GetAll();
    }
}
