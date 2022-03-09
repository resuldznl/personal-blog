using PersonalBlog.BLL.Abstract;
using PersonalBlog.DAL.Abstract;
using PersonalBlog.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.BLL.Concrete
{
    public class PersonalInformationManager : IPersonalInformationService
    {
        private readonly IPersonalInformationDal _personalInformationDal;

        public PersonalInformationManager(IPersonalInformationDal personalInformationDal)
        {
            _personalInformationDal = personalInformationDal;
        }
        public async Task<PersonalInformation> GetPersonalInformation()
        {
            return await _personalInformationDal.GetAsync();
        }
        public async Task<bool> UpdatePersonalInformation(PersonalInformation personalInformation)
        {
            return await _personalInformationDal.UpdateAsync(personalInformation);
        }
    }
}
