using ErpCli.Models;

namespace ErpCli.Data
{
    public partial class Database
    {
        List<Company> Companies = new List<Company>()
        {
            new Company { Id = 1, Name = "NovoNordisk", Street = "Vinkelvej", Number = "142", PostalCode = "9000", City = "Aalborg", Country = "Danmark", Currency = Currency.DKK },
            new Company { Id = 2, Name = "Microsoft", Street = "Micro Street", Number = "2", PostalCode = "98033", City = "Redmond", Country = "USA", Currency = Currency.USD },
        };

        public Company? GetCompanyById(int id)
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
            if (company.Id != 0)
            {
                return;
            }
            company.Id = Companies.Count + 1;
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
