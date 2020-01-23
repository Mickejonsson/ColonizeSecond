using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colonize.Website.Data.Entities
{
    public class Voyage
    {
        public int Id { get; set; }
        public Destinaton Destination { get; set; }
        public Ship Ship { get; set; }
        public DateTime DepartureAt { get; set; }
        public DateTime ArrivalAt { get; set; }
    }
}
