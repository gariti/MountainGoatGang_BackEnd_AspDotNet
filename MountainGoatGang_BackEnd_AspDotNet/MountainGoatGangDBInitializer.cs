using MountainGoatGang.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MountainGoatGang.Repository
{
    public class MountainGoatGangDBInitializer : CreateDatabaseIfNotExists<MountainGoatGangContext>
    {
        protected override void Seed(MountainGoatGangContext context)
        {
            base.Seed(context);
        }
    }
}