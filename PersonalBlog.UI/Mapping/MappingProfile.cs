using AutoMapper;
using PersonalBlog.Entities.ComplexType;
using PersonalBlog.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.UI.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Contact, CreateContactVM>();
            CreateMap<CreateContactVM, Contact>();
            CreateMap<Contact, ContactListVM>();
            CreateMap<ContactListVM, Contact>();
            CreateMap<PersonalInformation, UpdatePersonelInformationVM>();
            CreateMap<UpdatePersonelInformationVM, PersonalInformation>();
            CreateMap<UpdateSkillVM, Skill>();
            CreateMap<Skill,UpdateSkillVM>();
            CreateMap<GetSkillVM, Skill>();
            CreateMap<Skill, GetSkillVM>();
            CreateMap<CreateSkillVM, Skill>();
            CreateMap<Skill, CreateSkillVM>();
            CreateMap<CreateExperienceVM, Experience>();
            CreateMap<Experience, CreateExperienceVM>();
            CreateMap<UpdateExperienceVM, Experience>();
            CreateMap<Experience, UpdateExperienceVM>();
            CreateMap<Blog, UpdateBlogVM>();
            CreateMap<UpdateBlogVM, Blog>();
            CreateMap<Blog, CreateBlogVM>();
            CreateMap<CreateBlogVM, Blog>();
            CreateMap<Admin, UpdateAdminVM>();
            CreateMap<UpdateAdminVM, Admin>();
        }
    }
}
