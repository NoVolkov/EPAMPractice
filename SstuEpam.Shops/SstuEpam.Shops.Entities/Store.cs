using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SstuEpam.Shops.Entities
{
    public class Store
    {
        public long Id { get; }
        public string name { get; }
        public char rating { get; } // от 0 до 5
        public string address { get; }
        public string website { get; }

        public Store(long id, string name, char rating, string address, string website)
        {
            Id = id;
            this.name = name;
            this.rating = rating;
            this.address = address;
            this.website = website;
        }
    }
}
