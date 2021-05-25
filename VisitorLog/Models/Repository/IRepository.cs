using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorLog.Models.Repository
{
    interface IRepository<T> : IDisposable
        where T : class
    {

    }
}
