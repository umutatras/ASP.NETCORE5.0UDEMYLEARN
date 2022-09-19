using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ua.UdemyTodoAppNTier.Dtos.Interfaces;

namespace Ua.UdemyTodoAppNTier.Dtos.WorkDtos
{
    public class WorkUpdateDto:IDto
    {
        public int Id { get; set; }
        public string Definition { get; set; }
        public bool IsCompleted { get; set; }
    }
}
