using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MountainGoatGang.Repository
{

    //WIP
    public class RepositoryActionResult<T> where T : class
    {
        public T Entity { get; set; }
        public RepositoryActionStatus Status { get; set; }

        public Exception Exception { get; private set; }


        public RepositoryActionResult(T entity, RepositoryActionStatus status)
        {
            Entity = entity;
            Status = status;
        }

        public RepositoryActionResult(T entity, RepositoryActionStatus status, Exception exception) : this(entity, status)
        {
            Exception = exception;
        }

    }

}
