using TECHCOOL.UI;
using ErpCli.Models;
using ErpCli.Data;

namespace ErpCli.Views
{
    public class SalesEditScreen : Screen
    {
        public override string Title { get; set; } = "Salgsordre";
        SalesOrderHeader salesOrderHeader = new();

        public SalesEditScreen(SalesOrderHeader salesOrderHeader)
        {
            if (salesOrderHeader.OrderNumber > 0)
            {
                Title = "Redigerer for " + salesOrderHeader.OrderNumber;
            }
            else
            {
                Title = "Opret ny salgsordre";
            }
            this.salesOrderHeader = salesOrderHeader;
        }

        protected override void Draw()
        {
            ExitOnEscape();

            Customer? customer;
            if (Database.Instance.GetCustomerById(salesOrderHeader.CustomerId) != null)
            {
                customer = Database.Instance.GetCustomerById(salesOrderHeader.CustomerId);
            }
            else
            {
                customer = new();
            }
            

            Form<Customer> form = new();

            form.TextBox("Fornavn", nameof(customer.FirstName));
            form.TextBox("Efternavn", nameof(customer.LastName));
            form.TextBox("Vej", nameof(customer.Street));
            form.TextBox("Husnummer", nameof(customer.Number));
            form.TextBox("Postnummer", nameof(customer.PostalCode));
            form.TextBox("By", nameof(customer.City));
            form.TextBox("Telefonnummer", nameof(customer.Phone));
            form.TextBox("Email", nameof(customer.Email));

            if (form.Edit(customer)) 
            {
                if (customer.Id != 0)
                {
                    Database.Instance.UpdateCustomer(customer);

                }
                else
                {
                    Database.Instance.AddCustomer(customer);
                }
                Console.WriteLine("Ændringerne blev gemt");
            }
            else
            {
                Console.WriteLine("Ingen ændringer");
            }
        }
    }
}