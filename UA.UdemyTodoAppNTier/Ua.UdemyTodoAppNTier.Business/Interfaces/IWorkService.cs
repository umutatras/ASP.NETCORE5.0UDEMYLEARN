using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ua.UdemyTodoAppNTier.Common.ResponseObjects;
using Ua.UdemyTodoAppNTier.Dtos.Interfaces;
using Ua.UdemyTodoAppNTier.Dtos.WorkDtos;

namespace Ua.UdemyTodoAppNTier.Business.Interfaces
{
    public interface IWorkService
    {
        Task<IResponse< List<WorkListDto>>> GetAll();
        Task <IResponse<WorkCreateDto>> Create(WorkCreateDto dto);

        Task<IResponse<IDto>> GetById<IDto>(int id);

        Task <IResponse>Remove(int id);

        Task<IResponse<WorkUpdateDto>> Update(WorkUpdateDto dto);
    }
}
