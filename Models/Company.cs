namespace ErpCli.Models
{
    public class Company
    {
        int Id { get; set; }
        string? CompanyName { get; set; }
        string? Street { get; set; }
        string? HouseNumber { get; set; }
        string? PostalCode { get; set; }
        string? City { get; set; }
        string? Country { get; set; }
        Currency Currency { get; set; }
    }
}