using Brive.Bootcamp.Project.API.Models;
using Brive.Bootcamp.Project.API.Repositories;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brive.Bootcamp.Project.API.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }
        public List<Company> GetCompanys(int order)
        {
            return _companyRepository.GetCompanys(order);
        }

        public List<Company> SaveCompany(Company company)
        {
            Company newCompany = new Company();
            string search = company.Name.Replace(" ", "-");
            string url = "https://www.occ.com.mx/empleos/de-" + search + "/";
            HtmlWeb web = new HtmlWeb();
            HtmlDocument htmlDoc = web.Load(url);
            HtmlNode node = htmlDoc.DocumentNode.SelectSingleNode(@"//body/div[1]/div[2]/div[1]/div/div/div[2]/div/div/div[1]/p/text()[1]");
            newCompany.Name = company.Name;
            string numJobs = node.InnerText.Replace(",", "");
            int num = int.Parse(numJobs);
            newCompany.NumberJobs = num;
            newCompany.Date = DateTime.UtcNow;
            return _companyRepository.SaveCompany(newCompany);
        }
    }

}
