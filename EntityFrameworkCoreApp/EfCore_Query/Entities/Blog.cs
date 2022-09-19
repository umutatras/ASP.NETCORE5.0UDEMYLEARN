using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore_Query.Entities
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public /*lazy loadingde virtual kullanılmalı virtual*/ List<Comment> Comments { get; set; }
    }
}
