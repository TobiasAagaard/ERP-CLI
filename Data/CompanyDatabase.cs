using ErpCli.Models;

namespace ErpCli.Data
{
    public partial class Database
    {
        List<Company> Companies = new List<Company>()
        {
            new Company { Id = 1, CompanyName = "TechCool", Street = "Main Street", HouseNumber = "123", PostalCode = "12345", City = "TechCity", Country = "TechLand", Currency = Currency.USD },
            new Company { Id = 2, CompanyName = "CodeMasters", Street = "Second Street", HouseNumber = "456", PostalCode = "67890", City = "CodeTown", Country = "CodeLand", Currency = Currency.EUR },
        };

        public Company GetCompanyById(int id)
        {
            for (int i = 0; i < Companies.Count; i++)
            {
                Company company = Companies[i];
                if (company.Id == id)
                {
                    return company;
                }
            }
             return null;
        }

        public List<Company> GetAllCompanies()
        {
            List<Company> companyCopy = new List<Company>();
            companyCopy.AddRange(Companies);
            return companyCopy;
        }

        public void AddCompany(Company company)
        {
            if (company.Id == 0)
            {
                for (int i = 0; i < Companies.Count; i++)
                {
                    company.Id = i + 1;
                }
            }
            Companies.Add(company);
        }

        public void UpdateCompany(Company updatedCompany)
        {
            for (int i = 0; i < Companies.Count; i++)
            {
                Company company = Companies[i];
                if (company.Id == updatedCompany.Id)
                {
                    Companies[i] = updatedCompany;
                }
            }
        }
        public void DeleteCompany(int id)
        {
            for (int i = 0; i < Companies.Count; i++)
            {
                Company company = Companies[i];
                if (company.Id == id)
                {
                    Companies.RemoveAt(i);
                }
            }
        }
    }

}
