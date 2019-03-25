using System;
using Microsoft.AspNetCore.Mvc;
using ShipBaseCore.Interfaces.Repositories;
using ShipBaseCore.Models.Domain;

namespace Api.ShipOnline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private IRepositoryWrapper _repository;

        public CompaniesController(IRepositoryWrapper repository)
        {
            _repository = repository;
        }


        // GET /api/companies
        [HttpGet]
        public IActionResult GetCompanies()
        {
            try
            {
            var companies = _repository.Company.GetAllCompanies();
            return Ok(companies);
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // GET /api/companies/1
        [HttpGet("{id}", Name = "CompanyById")]
        public IActionResult GetCompany(string id)
        {
            try
            {
                var company = _repository.Company.GetCompanyById(id);

                if (company == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(company);
                }
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // POST /api/companies
        [HttpPost]
        public IActionResult CreateCompany([FromBody]Company company)
        {
            try
            {
                if (company == null)
                {
                    return BadRequest("Company object is null");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }
                _repository.Company.CreateCompany(company);
                return CreatedAtRoute("CompanyById", new {id = company.ID}, company);
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // PUT /api/companies/1
        [HttpPut("{id}")]
        public IActionResult UpdateCompany(string id, Company company)
        {
            try
            {
                if (company == null)
                {
                    return BadRequest("Company object is null");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                var dbCompany = _repository.Company.GetCompanyById(id);
                if (dbCompany == null)
                {
                    return NotFound();
                }

                _repository.Company.UpdateCompany(dbCompany, company);

                return Ok();
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // PUT /api/companies/1
        [HttpDelete("{id}")]
        public IActionResult DeleteCompany(string id)
        {
            try
            {
                var company = _repository.Company.GetCompanyById(id);
                if (company == null)
                {
                    return NotFound();
                }
                _repository.Company.DeleteCompany(company);
                return Ok();
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }

    }
}