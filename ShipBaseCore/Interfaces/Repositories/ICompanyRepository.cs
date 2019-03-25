using System.Collections.Generic;
using ShipBaseCore.Models.Domain;

namespace ShipBaseCore.Interfaces.Repositories
{
    public interface ICompanyRepository : IRepositoryBase<Company>
    {
        IEnumerable<Company> GetAllCompanies();
        Company GetCompanyById(string id);
        void CreateCompany(Company company);
        void UpdateCompany(Company dbCompany, Company company);
        void DeleteCompany(Company company);
    }
}