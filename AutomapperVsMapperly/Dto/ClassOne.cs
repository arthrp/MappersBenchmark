namespace AutomapperVsMapperly.Dto;

public class ClassOne
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string? State { get; set; }
    public string Country { get; set; }
    public string ZipCode { get; set; }
    public string PhoneNumber { get; set; }
    public string Username { get; set; }
    public int Age { get; set; }
    public int Salary { get; set; }
    public int HouseNumber { get; set; }
    public int PostalCode { get; set; }
    public int NumberOfDependents { get; set; }
    public int HoursWorked { get; set; }
    public Department Department { get; set; }
    public CreditRating CreditScore { get; set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime HireDate { get; set; }
    public DateTime? LastPromotionDate { get; set; }
    public DateTime? LastLoginDate { get; set; }
    public DateTime? AccountExpirationDate { get; set; }
}

public enum Department
{
    HumanResources = 1,
    Finance,
    Engineering,
    Sales,
    Marketing,
    IT,
    Operations,
    Legal
}

public enum CreditRating
{
    Excellent = 1,
    Good,
    Fair,
    Poor
}