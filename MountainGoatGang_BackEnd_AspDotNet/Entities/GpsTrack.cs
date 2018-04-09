using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MountainGoatGang.Repository
{
    public class GpsTrack
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IQueryable<string> GpsPoints { get; set; }
    }
}