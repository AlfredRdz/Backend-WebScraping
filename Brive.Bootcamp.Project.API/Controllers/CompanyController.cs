using Brive.Bootcamp.Project.API.Models;
using Brive.Bootcamp.Project.API.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brive.Bootcamp.Project.API.Controllers
{
    [EnableCors("BootcampProject")]
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private ICompanyService _companyService;
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpPost]
        public ActionResult<List<Company>> SaveCompany([FromBody] Company company)
        {
            try
            {
                if (company.Name == string.Empty)
                    return StatusCode(StatusCodes.Status400BadRequest);
                else
                    return StatusCode(StatusCodes.Status200OK, _companyService.SaveCompany(company));
            }
            catch 
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
        }

        [HttpGet]
        [Route("{order}")]
        public ActionResult<List<Company>> GetOrdernadoCompanys(int order)
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, _companyService.GetCompanys(order));
            }
            catch 
            {

                return StatusCode(StatusCodes.Status400BadRequest);
            }
        }
    }
}
