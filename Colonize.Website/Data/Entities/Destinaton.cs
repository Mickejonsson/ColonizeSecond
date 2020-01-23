using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colonize.Website.Data.Entities
{
    public class Destinaton
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Uri ImageUrl { get; set; }
    }
}
