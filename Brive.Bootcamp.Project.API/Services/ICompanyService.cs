using Brive.Bootcamp.Project.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brive.Bootcamp.Project.API.Services
{
    public interface ICompanyService
    {
        List<Company> GetCompanys(int order);
        List<Company> SaveCompany(Company company);
    }
}
