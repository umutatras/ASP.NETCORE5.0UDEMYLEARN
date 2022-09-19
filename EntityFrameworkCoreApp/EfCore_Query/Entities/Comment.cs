using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore_Query.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
        public /*lazy loadingde virtual kullanılmalı virtual*/ Blog Blog { get; set; }
    }
}
