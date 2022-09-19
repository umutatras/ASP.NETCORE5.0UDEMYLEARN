using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ua.UdemyTodoAppNTier.Entities.Concrete
{
    public class Work:BaseEntity
    {
        
        public string Definition { get; set; }
        public bool IsCompleted { get; set; }
    }
}
