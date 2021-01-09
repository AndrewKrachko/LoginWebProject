using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginWebProject.Interfaces
{
    interface IRepository
    {
        IEnumerable<IUser> GetUsers();
    }
}
