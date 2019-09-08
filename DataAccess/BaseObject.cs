
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BaseObject
    {
        public IRepository _Repo;

        public BaseObject()
            : this(new Repository())
        { }

        public BaseObject(IRepository Repo)
        {
            _Repo = Repo;
        }
    }
}
