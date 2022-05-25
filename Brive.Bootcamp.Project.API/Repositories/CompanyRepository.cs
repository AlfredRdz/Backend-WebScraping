using Brive.Bootcamp.Project.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brive.Bootcamp.Project.API.Repositories
{
   
    public class CompanyRepository : ICompanyRepository
    {
        private readonly BPContext context;
        public CompanyRepository(BPContext _context)
        {
            context = _context;
        }
        public List<Company> GetCompanys(int order)
        {
            if (order > 0)
            {
                if (order == 1)
                {
                    return context.Company.OrderBy(company => company.Name).ToList();
                }
                if (order == 2)
                {
                    return context.Company.OrderByDescending(company => company.NumberJobs).ToList();
                }
                if (order == 3)
                {
                    return context.Company.OrderBy(company => company.Date).ToList();
                }
            }
            return context.Company.OrderByDescending(company => company.Date).ToList();
        }

        public List<Company> SaveCompany(Company company)
        {
            context.Company.Add(company);
            context.SaveChanges();

            return context.Company.OrderByDescending(company => company.Date).ToList();
        }
    }
}
