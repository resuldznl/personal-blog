﻿using PersonalBlog.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.BLL.Abstract
{
    public interface IPersonalInformationService
    {
         Task<PersonalInformation> GetPersonalInformation();
         Task<bool> UpdatePersonalInformation(PersonalInformation personalInformation);
    }
}
