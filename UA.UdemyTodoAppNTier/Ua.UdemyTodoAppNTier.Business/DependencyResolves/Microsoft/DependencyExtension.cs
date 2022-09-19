using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ua.UdemyTodoAppNTier.Business.Interfaces;
using Ua.UdemyTodoAppNTier.Business.Mappings.AutoMapper;
using Ua.UdemyTodoAppNTier.Business.Services;
using Ua.UdemyTodoAppNTier.Business.ValidationRules;
using Ua.UdemyTodoAppNTier.Dtos.WorkDtos;
using Ua.UdemyTodoNTier.DataAccess.Contexts;
using Ua.UdemyTodoNTier.DataAccess.UnitOfWork;

namespace Ua.UdemyTodoAppNTier.Business.DependencyResolves.Microsoft
{
    public static class DependencyExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddDbContext<TodoContext>(opt =>
            {
                opt.UseSqlServer("server=DESKTOP-2GOA1TF;database=DbToDo;integrated security=true;");
                
            });
            var configuration = new MapperConfiguration(opt =>
              {
                  opt.AddProfile(new WorkProfile());
              });
            var mapper = configuration.CreateMapper();
       
            services.AddSingleton(mapper);
            services.AddScoped<IUow,Uow>();
            services.AddScoped<IWorkService, WorkService>();
            services.AddTransient<IValidator<WorkCreateDto>, WorkCreateDtoValidator>();
            services.AddTransient<IValidator<WorkUpdateDto>, WorkUpdateDtoValidator>();
        }
    }
}
