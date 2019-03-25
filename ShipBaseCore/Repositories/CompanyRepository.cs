using System.Collections.Generic;
using System.Linq;
using ShipBaseCore.Interfaces.Repositories;
using ShipBaseCore.Models.Domain;
using ShipBaseCore.Models.Extensions;
using ShipOnline.Persistence;
using static System.Int32;

namespace ShipBaseCore.Repositories
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(ShipBaseDbContext context) : base(context)
        {
        }


        public IEnumerable<Company> GetAllCompanies()
        {
            return FindAll();
        }

        public Company GetCompanyById(string id)
        {
            return FindByCondition(company => company.ID.Equals(id))
                .DefaultIfEmpty(null)
                .FirstOrDefault();
        }

        public void CreateCompany(Company company)
        {
            var companies = GetAllCompanies();
            var highestId = companies.Select(existingCompany => Parse(existingCompany.ID)).Concat(new[] {0}).Max();
            company.ID = (highestId + 1).ToString();
            Create(company);
            Save();
        }

        public void UpdateCompany(Company dbCompany, Company company)
        {
            dbCompany.Map(company);
            Update(dbCompany);
            Save();
        }

        public void DeleteCompany(Company company)
        {
            Delete(company);
            Save();
        }
    }
}