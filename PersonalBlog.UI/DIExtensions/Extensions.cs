using Microsoft.Extensions.DependencyInjection;
using PersonalBlog.BLL.Abstract;
using PersonalBlog.BLL.Concrete;
using PersonalBlog.DAL.Abstract;
using PersonalBlog.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.UI.DIExtensions
{
    public static class Extensions
    {
        public static IServiceCollection AddDataAccessLayer(this IServiceCollection services)
        {
            services.AddScoped<IAdminDal, AdminDal>();
            services.AddScoped<IBlogDal, BlogDal>();
            services.AddScoped<IContactDal, ContactDal>();
            services.AddScoped<IExperienceDal, ExperienceDal>();
            services.AddScoped<IPersonalInformationDal, PersonalInformationDal>();
            services.AddScoped<ISkillDal, SkillDal>();
            return services;
        }
        public static IServiceCollection AddBusinessLogicLayer(this IServiceCollection services)
        {
            services.AddScoped<IAdminService, AdminManager>();
            services.AddScoped<IBlogService, BlogManager>();
            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IExperienceService, ExperienceManager>();
            services.AddScoped<IPersonalInformationService, PersonalInformationManager>();
            services.AddScoped<ISkillService, SkillManager>();
            return services;
        }
    }
}
