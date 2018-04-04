using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MountainGoatGang.Repository
{
    //WIP
    public enum RepositoryActionStatus
    {
        Ok,
        Created,
        Updated,
        NotFound,
        Deleted,
        NothingModified,
        Error
    }
}