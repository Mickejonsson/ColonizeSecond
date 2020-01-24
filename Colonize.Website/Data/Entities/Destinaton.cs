using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colonize.Website.Data.Entities
{
    public class Destinaton
    {
        public Destinaton(string name, string description, Uri imageUrl)
        {
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
        }

        public Destinaton(int id, string name, string description, Uri imageUrl)
              : this(name, description, imageUrl)
        {
            Id = id;
        }

        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public Uri ImageUrl { get; protected set; }
    }
}
