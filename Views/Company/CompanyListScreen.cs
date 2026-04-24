using ErpCli.Models;
using ErpCli.Data;
using TECHCOOL.UI;
using System.Runtime.CompilerServices;

namespace ErpCli.Views;
public class CompanyListScreen : Screen
{
    public override string Title {get;set;} = "Virksomheder";

    protected override void Draw()
    {
        ExitOnEscape();
        
        Console.CursorVisible = false;

        ListPage<Company> listPage = new();

       
        listPage.AddKey(ConsoleKey.F1, CreateNewCompany);
        listPage.AddKey(ConsoleKey.F2, EditCompany);
        listPage.AddKey(ConsoleKey.F5, DeleteCompany);


        listPage.AddColumn("Virksomhed", nameof(Company.Name), 40);
        listPage.AddColumn("Land", nameof(Company.Country));
        listPage.AddColumn("Valuta", nameof(Company.Currency), 8);

  
        var companies = Database.Instance.GetAllCompanies();
        foreach (Company model in companies) 
        {
            listPage.Add(model);
        }

        var company = listPage.Select();
        if (company != null)
        {
            Screen.Display(new CompanyDetails(company));
        }
        else
        {
            Quit();
        }
    }
    void CreateNewCompany(Company _)
    {
        Company company = new Company();
        Screen.Display(new CompanyEditScreen(company)); 
    }
    
    void EditCompany(Company company)
    {
        Screen.Display(new CompanyEditScreen(company));
    }

    void DeleteCompany(Company company)
    {
        Database.Instance.DeleteCompany(company.Id);
    }
    
}