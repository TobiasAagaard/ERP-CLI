namespace ErpCli.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? FullName => $"{FirstName} {LastName}";
        public string? Phone { get; set; }
        public string? Email { get; set; }

        public Address? Address { get; set; }
        public string? Street => Address?.Street;
        public string? Number => Address?.Number;
        public string? PostalCode => Address?.PostalCode;
        public string? City => Address?.City;
        public string? Country => Address?.Country;
    }
}