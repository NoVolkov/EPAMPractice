using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SstuEpam.Shops.Entities
{
    public class Comment
    {
        public long Id_store { get; }
        public long Id_user { get; }
        public string text { get; }
        public char rating { get; }
    }
}
