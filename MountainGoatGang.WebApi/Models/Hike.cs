using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MountainGoatGang.WebApi.Models
{
    public class Hike
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Hike Status { get; set; }
        public IQueryable<Trail> Trails { get; set; }
    }
}